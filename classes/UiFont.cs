using System.Drawing;
using System.Windows.Forms;

namespace DentalClinicProject
{
    /// <summary>
    /// Project-wide UI font: Times New Roman, 12pt (bold/italic preserved where set).
    /// </summary>
    public static class UiFont
    {
        public const string FamilyName = "Times New Roman";
        public const float DefaultSize = 12f;

        private static Font _regular;
        private static Font _bold;

        public static Font Regular =>
            _regular ?? (_regular = new Font(FamilyName, DefaultSize, FontStyle.Regular));

        public static Font Bold =>
            _bold ?? (_bold = new Font(FamilyName, DefaultSize, FontStyle.Bold));

        /// <summary>Hook forms and user controls when they are shown.</summary>
        public static void Install()
        {
            Application.AddMessageFilter(new ShowWindowFontFilter());
        }

        /// <summary>Apply the clinic font to a form, user control, or any control tree.</summary>
        public static void ApplyTo(Control root)
        {
            if (root == null)
                return;

            ApplyControlFont(root);
            foreach (Control child in root.Controls)
                ApplyTo(child);
        }

        private static void ApplyControlFont(Control control)
        {
            if (!NeedsUpdate(control.Font))
                control.Font = MapFont(control.Font);

            if (control is DataGridView dgv)
            {
                if (!NeedsUpdate(dgv.ColumnHeadersDefaultCellStyle.Font))
                    dgv.ColumnHeadersDefaultCellStyle.Font = MapFont(dgv.ColumnHeadersDefaultCellStyle.Font);
                if (!NeedsUpdate(dgv.DefaultCellStyle.Font))
                    dgv.DefaultCellStyle.Font = MapFont(dgv.DefaultCellStyle.Font);
                if (!NeedsUpdate(dgv.AlternatingRowsDefaultCellStyle.Font))
                    dgv.AlternatingRowsDefaultCellStyle.Font = MapFont(dgv.AlternatingRowsDefaultCellStyle.Font);
            }
            else if (control is ToolStrip strip)
            {
                if (!NeedsUpdate(strip.Font))
                    strip.Font = MapFont(strip.Font);
                foreach (ToolStripItem item in strip.Items)
                {
                    if (item.Font != null && !NeedsUpdate(item.Font))
                        item.Font = MapFont(item.Font);
                }
            }
        }

        private static bool NeedsUpdate(Font font)
        {
            if (font == null)
                return false;
            return font.FontFamily.Name == FamilyName &&
                   font.SizeInPoints >= DefaultSize - 0.01f &&
                   font.SizeInPoints <= DefaultSize + 0.01f;
        }

        public static Font MapFont(Font current)
        {
            FontStyle style = current?.Style ?? FontStyle.Regular;
            return new Font(FamilyName, DefaultSize, style);
        }

        private sealed class ShowWindowFontFilter : IMessageFilter
        {
            private const int WmShowWindow = 0x0018;

            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg != WmShowWindow)
                    return false;

                var control = Control.FromHandle(m.HWnd);
                if (control is Form || control is UserControl)
                    ApplyTo(control);

                return false;
            }
        }
    }
}
