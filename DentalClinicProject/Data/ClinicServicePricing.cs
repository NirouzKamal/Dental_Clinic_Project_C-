using System.Collections.Generic;

namespace DentalClinicProject.data
{
    /// <summary>
    /// In-memory pricing until servicesTable is connected from the database.
    /// Replace <see cref="GetPrice"/> with a DB query when ready.
    /// </summary>
    internal static class ClinicServicePricing
    {
        private static readonly Dictionary<string, decimal> ServicesFromTable = new Dictionary<string, decimal>
        {
            { "كشف", 40m },
            { "مراجعة", 0m },
            { "حشو عادي", 120m },
            { "حشوة تجميلية", 150m },
            { "خلع عادي", 100m },
            { "خلع جراحي", 450m },
            { "تغليف سن (Zirconia/E-max)", 600m },
            { "(علاج عصب (خلفي /طواحن", 750m },
            { "علاج عصب امامي", 500m },
            { "فينير", 1200m },
            { "علاج لثة عميق", 400m },
            { "تنظيف جير وتلميع", 190m },
        };

        public static decimal GetPrice(string serviceName)
        {
            if (string.IsNullOrWhiteSpace(serviceName))
                return 0m;
            return ServicesFromTable.TryGetValue(serviceName.Trim(), out decimal price) ? price : 0m;
        }
    }
}
