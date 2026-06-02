using System.Drawing;
using System.Windows.Forms;

namespace DentalClinicProject
{
    public static class ThemeManager
    {
        // ─── COLOR PALETTE ──────────────────────────────────────────────────
        public static readonly Color PrimaryColor = ColorTranslator.FromHtml("#004B9B");
        public static readonly Color BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
        public static readonly Color AppBackgroundColor = ColorTranslator.FromHtml("#F3F4F6");

        public static readonly Color TextDark = ColorTranslator.FromHtml("#212529");
        public static readonly Color TextMuted = ColorTranslator.FromHtml("#6C757D");

        public static readonly Color BorderLight = ColorTranslator.FromHtml("#DEE2E6");

        // Semantic / Status Colors
        public static readonly Color SuccessColor = ColorTranslator.FromHtml("#28A745"); // Soft Green
        public static readonly Color DangerColor = ColorTranslator.FromHtml("#DC3545");  // Soft Red
        public static readonly Color WarningColor = ColorTranslator.FromHtml("#FFC107"); // Soft Yellow/Orange

        // ─── TYPOGRAPHY ─────────────────────────────────────────────────────
        public static readonly Font PrimaryFont = UiFont.Regular;
        public static readonly Font HeaderFont = UiFont.Bold;

        // ─── STYLING HELPER METHODS ─────────────────────────────────────────

        public static void StyleForm(Form form)
        {
            form.BackColor = AppBackgroundColor;
            form.Font = PrimaryFont;
            form.ForeColor = TextDark;
            form.RightToLeft = RightToLeft.Yes;
            form.RightToLeftLayout = true;
        }

        public static void StyleButton(Button btn, bool isPrimary = true)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = PrimaryFont;
            btn.Cursor = Cursors.Hand;

            if (isPrimary)
            {
                btn.BackColor = PrimaryColor;
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = BorderLight;
                btn.ForeColor = TextDark;
            }
        }

        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = BackgroundColor;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = BorderLight;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RightToLeft = RightToLeft.Yes;

            // Header Style
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = AppBackgroundColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextMuted;
            dgv.ColumnHeadersDefaultCellStyle.Font = UiFont.Bold;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 40;

            // Row Style
            dgv.DefaultCellStyle.BackColor = BackgroundColor;
            dgv.DefaultCellStyle.ForeColor = TextDark;
            dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#E9ECEF");
            dgv.DefaultCellStyle.SelectionForeColor = TextDark;
            dgv.DefaultCellStyle.Font = PrimaryFont;
            dgv.DefaultCellStyle.Padding = new Padding(5);
            dgv.RowTemplate.Height = 45;
        }

        public static void StyleTextBox(TextBox tb)
        {
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.BackColor = BackgroundColor;
            tb.ForeColor = TextDark;
            tb.Font = PrimaryFont;
        }

        public static void StyleComboBox(ComboBox cb)
        {
            cb.FlatStyle = FlatStyle.Flat;
            
            Color parentColor = cb.Parent != null ? cb.Parent.BackColor : AppBackgroundColor;
            if (parentColor == BackgroundColor || (parentColor.R == 255 && parentColor.G == 255 && parentColor.B == 255))
            {
                cb.BackColor = AppBackgroundColor;
            }
            else
            {
                cb.BackColor = BackgroundColor;
            }
            
            cb.ForeColor = TextDark;
            cb.Font = PrimaryFont;
        }

        public static void ApplyThemeToControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Button btn)
                {
                    bool isPrimary = btn.Text.Contains("حفظ") || btn.Text.Contains("إضافة") || btn.Text.Contains("دخول") || btn.Text.Contains("تأكيد") || btn.Text.Contains("جديد");
                    StyleButton(btn, isPrimary);
                }
                else if (ctrl is DataGridView dgv)
                {
                    StyleDataGridView(dgv);
                }
                else if (ctrl is TextBox tb)
                {
                    StyleTextBox(tb);
                }
                else if (ctrl is ComboBox cb)
                {
                    StyleComboBox(cb);
                }
                else if (ctrl is Form frm)
                {
                    StyleForm(frm);
                }

                if (ctrl.HasChildren)
                {
                    ApplyThemeToControls(ctrl.Controls);
                }
            }
        }
    }
}