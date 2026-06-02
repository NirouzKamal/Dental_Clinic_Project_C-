using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DentalClinicProject.Reports;

namespace DentalClinicProject.classes
{
    /// <summary>
    /// Prints receipts using Crystal Reports (.rpt).
    /// Uses reflection so the solution builds without Crystal DLLs on machines that only design code.
    /// </summary>
    public static class CrystalReceiptPrinter
    {
        private const string VisitKashf = "كشف";
        private const string KashfReportFileName = "KashfReceipt.rpt";
        private const string PaymentReportFileName = "PaymentReceipt.rpt";

        public static bool ShouldPrint(string visitType)
        {
            return string.Equals(visitType?.Trim(), VisitKashf, StringComparison.Ordinal);
        }

        /// <summary>Show Crystal preview for كشف; no-op for مراجعة.</summary>
        public static void PrintKashfReceiptIfApplicable(KashfReceiptPrintModel model, bool showPreview = true)
        {
            if (model == null || !ShouldPrint(model.VisitType))
                return;

            if (!TryPrintCrystalReport(KashfReportFileName, (object)model.ToDataTable(), "معاينة إيصال الكشف", showPreview))
            {
                var result = MessageBox.Show(
                    "تعذر فتح تقرير Crystal Reports.\r\n\r\n" +
                    "تأكد من تثبيت Crystal Reports runtime ووجود الملف:\r\n" +
                    $"Reports\\{KashfReportFileName}\r\n\r\n" +
                    "هل تريد الطباعة بالتنسيق البديل (معاينة عادية)؟",
                    "Crystal Reports",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    PrintManager.PrintKashfReceipt(model, showPreview);
            }
        }

        /// <summary>Print combined payment invoice after تأكيد الدفع.</summary>
        public static void PrintPaymentReceipt(PaymentReceiptPrintModel model, bool showPreview = true)
        {
            if (model == null)
                return;

            string reportPath = GetReportPath(PaymentReportFileName);
            if (!File.Exists(reportPath))
            {
                PrintManager.PrintPaymentReceipt(model, showPreview);
                return;
            }

            if (!TryPrintCrystalReport(PaymentReportFileName, model.ToDataSet(), "معاينة فاتورة الدفع", showPreview))
                PrintManager.PrintPaymentReceipt(model, showPreview);
        }

        public static string GetReportPath(string reportFileName)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", reportFileName);
        }

        private static bool TryPrintCrystalReport(
            string reportFileName,
            object dataSource,
            string previewTitle,
            bool showPreview)
        {
            string reportPath = GetReportPath(reportFileName);
            if (!File.Exists(reportPath))
                return false;

            try
            {
                Assembly engineAsm = LoadCrystalAssembly(
                    "CrystalDecisions.CrystalReports.Engine",
                    "CrystalDecisions.CrystalReports.Engine, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304");

                if (engineAsm == null)
                    return false;

                Type reportType = engineAsm.GetType("CrystalDecisions.CrystalReports.Engine.ReportDocument", true);
                object report = Activator.CreateInstance(reportType);
                reportType.GetMethod("Load", new[] { typeof(string) })
                    ?.Invoke(report, new object[] { reportPath });

                reportType.GetMethod("SetDataSource", new[] { typeof(object) })
                    ?.Invoke(report, new object[] { dataSource });

                if (showPreview)
                    ShowCrystalPreview(report, engineAsm, previewTitle);
                else
                    reportType.GetMethod("PrintToPrinter", Type.EmptyTypes)?.Invoke(report, null);

                reportType.GetMethod("Close")?.Invoke(report, null);
                reportType.GetMethod("Dispose")?.Invoke(report, null);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static void ShowCrystalPreview(object report, Assembly engineAsm, string previewTitle)
        {
            Assembly winFormsAsm = LoadCrystalAssembly(
                "CrystalDecisions.Windows.Forms",
                "CrystalDecisions.Windows.Forms, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304");

            if (winFormsAsm == null)
            {
                engineAsm.GetType("CrystalDecisions.CrystalReports.Engine.ReportDocument", true)
                    ?.GetMethod("PrintToPrinter", Type.EmptyTypes)
                    ?.Invoke(report, null);
                return;
            }

            Form previewForm = new Form
            {
                Text = previewTitle ?? "معاينة التقرير",
                Width = 900,
                Height = 700,
                StartPosition = FormStartPosition.CenterScreen,
                RightToLeft = RightToLeft.Yes,
                RightToLeftLayout = true
            };

            Type viewerType = winFormsAsm.GetType("CrystalDecisions.Windows.Forms.CrystalReportViewer", true);
            Control viewer = (Control)Activator.CreateInstance(viewerType);
            viewer.Dock = DockStyle.Fill;
            viewerType.GetProperty("ToolPanelView")?.SetValue(viewer, 0);
            viewerType.GetProperty("ReportSource")?.SetValue(viewer, report);
            previewForm.Controls.Add(viewer);
            previewForm.ShowDialog();
        }

        private static Assembly LoadCrystalAssembly(string simpleName, string fullName)
        {
            try
            {
                return Assembly.Load(fullName);
            }
            catch
            {
                foreach (string path in GetCrystalProbePaths(simpleName))
                {
                    if (!File.Exists(path))
                        continue;
                    try
                    {
                        return Assembly.LoadFrom(path);
                    }
                    catch
                    {
                        // try next path
                    }
                }
            }
            return null;
        }

        private static string[] GetCrystalProbePaths(string dllFileName)
        {
            string file = dllFileName + ".dll";
            return new[]
            {
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file),
                Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                    @"SAP BusinessObjects\Crystal Reports for .NET Framework 4.0\Common\SAP BusinessObjects Enterprise XI 4.0\win32_x86\dotnet",
                    file),
                Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                    @"SAP BusinessObjects\Crystal Reports for .NET Framework 4.0\Common\SAP BusinessObjects Enterprise XI 4.0\win32_x86\dotnet",
                    file)
            };
        }
    }
}
