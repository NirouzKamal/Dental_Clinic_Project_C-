using System;
using System.Collections.Generic;
using System.Linq;
using DentalClinicProject.data;

namespace DentalClinicProject.classes
{
    /// <summary>Groups case lines that belong to one patient visit / one combined invoice.</summary>
    public static class CaseVisitGrouping
    {
        public static string NewVisitBatchId() =>
            $"VB-{DateTime.Now:yyyyMMddHHmmss}-{Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper()}";

        public static List<Case> GetPendingVisitCases(Case anchor)
        {
            if (anchor == null)
                return new List<Case>();

            IEnumerable<Case> query = DataStore.Cases.Where(c =>
                c.SentToReception
                && c.Status == CaseStatus.Waiting
                && c.PatientId == anchor.PatientId);

            if (!string.IsNullOrWhiteSpace(anchor.VisitBatchId))
            {
                return query
                    .Where(c => c.VisitBatchId == anchor.VisitBatchId)
                    .OrderBy(c => c.OpenedDate)
                    .ThenBy(c => c.CaseId)
                    .ToList();
            }

            return query
                .Where(c =>
                    c.DoctorId == anchor.DoctorId
                    && Math.Abs((c.OpenedDate - anchor.OpenedDate).TotalMinutes) < 3)
                .OrderBy(c => c.OpenedDate)
                .ThenBy(c => c.CaseId)
                .ToList();
        }

        public static string GetVisitGroupKey(Case c)
        {
            if (c == null) return "";
            if (!string.IsNullOrWhiteSpace(c.VisitBatchId))
                return c.VisitBatchId;
            return $"LEGACY|{c.PatientId}|{c.DoctorId}|{c.OpenedDate:yyyyMMddHHmm}";
        }

        public static List<List<Case>> GetPendingVisitGroups()
        {
            return DataStore.Cases
                .Where(c => c.SentToReception && c.Status == CaseStatus.Waiting)
                .GroupBy(GetVisitGroupKey)
                .Select(g => g.OrderBy(c => c.OpenedDate).ToList())
                .OrderBy(g => g.First().OpenedDate)
                .ToList();
        }

        public static decimal SumFinalPrice(IEnumerable<Case> cases) =>
            cases?.Sum(c => c.FinalPrice) ?? 0;

        public static decimal SumGrossPrice(IEnumerable<Case> cases) =>
            cases?.Sum(c => c.Price) ?? 0;

        public static decimal SumDiscount(IEnumerable<Case> cases) =>
            cases?.Sum(c => c.Discount) ?? 0;
    }
}
