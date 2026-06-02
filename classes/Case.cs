using System;
using System.Collections.Generic;

namespace DentalClinicProject.classes
{
    public enum CaseStatus { Waiting, InProgress, Completed, Cancelled }

    public class Case
    {
        public string CaseId { get; set; }
        public string CaseNumber { get; set; }      // رقم الحالة التلقائي
        public DateTime Date { get; set; }
        public string PatientId { get; set; }
        public string PatientFileNumber { get; set; }
        public string PatientName { get; set; }
        public string DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Diagnosis { get; set; }       // التشخيص
        public string Treatment { get; set; }       // اسم الحالة / العلاج
        public int ToothCount { get; set; }         // عدد الأسنان
        public decimal Price { get; set; }          // السعر
        public decimal Discount { get; set; }       // التخفيض
        public decimal FinalPrice => Price - Discount; // السعر النهائي
        public string Notes { get; set; }           // ملاحظات
        public CaseStatus Status { get; set; } = CaseStatus.Waiting;
        public DateTime OpenedDate { get; set; } = DateTime.Now;
        public DateTime? ClosedAt { get; set; }
        public bool SentToReception { get; set; } = false;
        /// <summary>Groups multiple services saved together in one doctor visit.</summary>
        public string VisitBatchId { get; set; }
        // سجل ملاحظات الطبيب (append-only)
        public List<string> DoctorNotes { get; set; } = new List<string>();
        public decimal TotalFee { get; internal set; }
    }
}