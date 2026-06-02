namespace DentalClinicProject.UI
{
    partial class AddStaffFormUI
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelHeader          = new System.Windows.Forms.Panel();
            this.lblTitle             = new System.Windows.Forms.Label();
            this.panelHeaderLine      = new System.Windows.Forms.Panel();
            this.panelMain            = new System.Windows.Forms.Panel();

            // ── Basic Info ──
            this.grpBasic             = new System.Windows.Forms.GroupBox();
            this.tlpBasic             = new System.Windows.Forms.TableLayoutPanel();
            this.txtFullName          = new System.Windows.Forms.TextBox();
            this.txtUsername          = new System.Windows.Forms.TextBox();
            this.txtPassword          = new System.Windows.Forms.TextBox();
            this.cmbRole              = new System.Windows.Forms.ComboBox();
            this.txtPhone             = new System.Windows.Forms.TextBox();
            this.lblPhoneError        = new System.Windows.Forms.Label();
            this.cmbGender            = new System.Windows.Forms.ComboBox();
            this.lblHireDateValue     = new System.Windows.Forms.Label();

            // ── Doctor Info ──
            this.panelDoctorFields    = new System.Windows.Forms.Panel();
            this.grpDoctor            = new System.Windows.Forms.GroupBox();
            this.tlpDoctor            = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSpeciality        = new System.Windows.Forms.ComboBox();
            this.cmbRoom              = new System.Windows.Forms.ComboBox();
            this.txtPercentage        = new System.Windows.Forms.TextBox();
            this.lblPercentageError   = new System.Windows.Forms.Label();
            this.txtLicense           = new System.Windows.Forms.TextBox();
            this.txtExperience        = new System.Windows.Forms.TextBox();

            // ── Schedule ──
            this.panelScheduleArea    = new System.Windows.Forms.Panel();
            this.grpSchedule          = new System.Windows.Forms.GroupBox();
            this.panelScheduleContent = new System.Windows.Forms.Panel();

            // ── Footer ──
            this.panelFooter          = new System.Windows.Forms.Panel();
            this.panelFooterLine      = new System.Windows.Forms.Panel();
            this.btnSave              = new System.Windows.Forms.Button();
            this.btnCancel            = new System.Windows.Forms.Button();

            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.grpBasic.SuspendLayout();
            this.tlpBasic.SuspendLayout();
            this.panelDoctorFields.SuspendLayout();
            this.grpDoctor.SuspendLayout();
            this.tlpDoctor.SuspendLayout();
            this.panelScheduleArea.SuspendLayout();
            this.grpSchedule.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════
            //  HEADER
            // ════════════════════════════
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.panelHeaderLine);
            this.panelHeader.Dock    = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height  = 52;
            this.panelHeader.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);

            this.lblTitle.AutoSize  = true;
            this.lblTitle.Dock      = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.lblTitle.Text      = "إضافة موظف جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.panelHeaderLine.BackColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.panelHeaderLine.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderLine.Height    = 2;

            // ════════════════════════════
            //  SCROLLABLE MAIN
            // ════════════════════════════
            this.panelMain.AutoScroll = true;
            this.panelMain.Dock       = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Padding    = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.panelMain.Controls.Add(this.panelScheduleArea);
            this.panelMain.Controls.Add(this.panelDoctorFields);
            this.panelMain.Controls.Add(this.grpBasic);

            // ════════════════════════════
            //  GROUP: المعلومات الأساسية
            // ════════════════════════════
            this.grpBasic.Dock      = System.Windows.Forms.DockStyle.Top;
            this.grpBasic.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpBasic.ForeColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.grpBasic.Text      = "المعلومات الأساسية";
            this.grpBasic.Padding   = new System.Windows.Forms.Padding(8);
            this.grpBasic.Height    = 250;
            this.grpBasic.Controls.Add(this.tlpBasic);

            // ── TableLayoutPanel: 4 cols × 4 rows ──
            this.tlpBasic.Dock        = System.Windows.Forms.DockStyle.Fill;
            this.tlpBasic.ColumnCount = 4;
            this.tlpBasic.RowCount    = 4;
            this.tlpBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115));
            this.tlpBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50));
            this.tlpBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115));
            this.tlpBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50));
            this.tlpBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48));
            this.tlpBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48));
            this.tlpBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60)); // phone row (taller for error label)
            this.tlpBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48));

            // Row 0: الاسم الكامل | اسم المستخدم
            this.tlpBasic.Controls.Add(MakeLbl("الاسم الكامل *"),    0, 0);
            this.tlpBasic.Controls.Add(this.txtFullName,               1, 0);
            this.tlpBasic.Controls.Add(MakeLbl("اسم المستخدم *"),    2, 0);
            this.tlpBasic.Controls.Add(this.txtUsername,               3, 0);
            // Row 1: كلمة المرور | الدور
            this.tlpBasic.Controls.Add(MakeLbl("كلمة المرور *"),     0, 1);
            this.tlpBasic.Controls.Add(this.txtPassword,               1, 1);
            this.tlpBasic.Controls.Add(MakeLbl("الدور الوظيفي *"),   2, 1);
            this.tlpBasic.Controls.Add(this.cmbRole,                   3, 1);
            // Row 2: الهاتف (مع رسالة خطأ) | الجنس
            this.tlpBasic.Controls.Add(MakeLbl("رقم الهاتف"),        0, 2);
            this.tlpBasic.Controls.Add(this.BuildPhonePanel(),         1, 2);
            this.tlpBasic.Controls.Add(MakeLbl("الجنس"),              2, 2);
            this.tlpBasic.Controls.Add(this.cmbGender,                 3, 2);
            // Row 3: تاريخ التعيين
            this.tlpBasic.Controls.Add(MakeLbl("تاريخ التعيين"),     0, 3);
            this.tlpBasic.Controls.Add(this.lblHireDateValue,          1, 3);

            StyleTxt(this.txtFullName);
            StyleTxt(this.txtUsername);
            StyleTxt(this.txtPassword); this.txtPassword.PasswordChar = '*';
            StyleCmb(this.cmbRole);
            StyleCmb(this.cmbGender);

            this.lblHireDateValue.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblHireDateValue.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHireDateValue.ForeColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.lblHireDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHireDateValue.Margin    = new System.Windows.Forms.Padding(4);

            // ════════════════════════════
            //  GROUP: معلومات الطبيب
            // ════════════════════════════
            this.panelDoctorFields.Dock    = System.Windows.Forms.DockStyle.Top;
            this.panelDoctorFields.Height  = 170;
            this.panelDoctorFields.Visible = false;
            this.panelDoctorFields.Controls.Add(this.grpDoctor);

            this.grpDoctor.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.grpDoctor.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDoctor.ForeColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.grpDoctor.Text      = "معلومات الطبيب";
            this.grpDoctor.Padding   = new System.Windows.Forms.Padding(8);
            this.grpDoctor.Controls.Add(this.tlpDoctor);

            this.tlpDoctor.Dock        = System.Windows.Forms.DockStyle.Fill;
            this.tlpDoctor.ColumnCount = 6;
            this.tlpDoctor.RowCount    = 2;
            this.tlpDoctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90));
            this.tlpDoctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34));
            this.tlpDoctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90));
            this.tlpDoctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33));
            this.tlpDoctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90));
            this.tlpDoctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33));
            this.tlpDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50));
            this.tlpDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65)); // row with error label

            // Row 0: التخصص | رقم الغرفة | نسبة الطبيب
            this.tlpDoctor.Controls.Add(MakeLbl("التخصص *"),          0, 0);
            this.tlpDoctor.Controls.Add(this.cmbSpeciality,             1, 0);
            this.tlpDoctor.Controls.Add(MakeLbl("رقم الغرفة"),        2, 0);
            this.tlpDoctor.Controls.Add(this.cmbRoom,                   3, 0);
            this.tlpDoctor.Controls.Add(MakeLbl("نسبة الطبيب %"),     4, 0);
            this.tlpDoctor.Controls.Add(this.BuildPercentagePanel(),    5, 0);
            // Row 1: رقم الرخصة | سنوات الخبرة
            this.tlpDoctor.Controls.Add(MakeLbl("رقم الرخصة"),        0, 1);
            this.tlpDoctor.Controls.Add(this.txtLicense,                1, 1);
            this.tlpDoctor.Controls.Add(MakeLbl("سنوات الخبرة"),      2, 1);
            this.tlpDoctor.Controls.Add(this.txtExperience,             3, 1);

            StyleCmb(this.cmbSpeciality);
            StyleCmb(this.cmbRoom);
            StyleTxt(this.txtLicense);
            StyleTxt(this.txtExperience);

            // ════════════════════════════
            //  GROUP: جدول الدوام
            // ════════════════════════════
            this.panelScheduleArea.Dock    = System.Windows.Forms.DockStyle.Top;
            this.panelScheduleArea.Height  = 300;
            this.panelScheduleArea.Visible = false;
            this.panelScheduleArea.Controls.Add(this.grpSchedule);

            this.grpSchedule.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.grpSchedule.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpSchedule.ForeColor = System.Drawing.Color.FromArgb(0, 75, 155);
            this.grpSchedule.Text      = "جدول أوقات الدوام الأسبوعي";
            this.grpSchedule.Padding   = new System.Windows.Forms.Padding(8);
            this.grpSchedule.Controls.Add(this.panelScheduleContent);

            this.panelScheduleContent.Dock       = System.Windows.Forms.DockStyle.Fill;
            this.panelScheduleContent.AutoScroll = true;
            this.panelScheduleContent.Padding    = new System.Windows.Forms.Padding(4);

            // ════════════════════════════
            //  FOOTER
            // ════════════════════════════
            this.panelFooter.BackColor = System.Drawing.Color.White;
            this.panelFooter.Controls.Add(this.btnSave);
            this.panelFooter.Controls.Add(this.btnCancel);
            this.panelFooter.Controls.Add(this.panelFooterLine);
            this.panelFooter.Dock    = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Height  = 54;
            this.panelFooter.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);

            this.panelFooterLine.BackColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.panelFooterLine.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelFooterLine.Height    = 1;

            this.btnSave.BackColor                 = System.Drawing.Color.FromArgb(0, 75, 155);
            this.btnSave.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock                      = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor                 = System.Drawing.Color.White;
            this.btnSave.Text                      = "حفظ الموظف  ✓";
            this.btnSave.Width                     = 155;
            this.btnSave.UseVisualStyleBackColor   = false;

            this.btnCancel.BackColor                 = System.Drawing.Color.FromArgb(240, 243, 246);
            this.btnCancel.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock                      = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font                      = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor                 = System.Drawing.Color.FromArgb(70, 70, 70);
            this.btnCancel.Text                      = "إلغاء";
            this.btnCancel.Width                     = 100;
            this.btnCancel.Margin                    = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.btnCancel.UseVisualStyleBackColor   = false;

            // ════════════════════════════
            //  FORM
            // ════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize          = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle   = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize       = new System.Drawing.Size(700, 480);
            this.MaximizeBox       = false;
            this.MinimizeBox       = false;
            this.Name              = "AddStaffFormUI";
            this.RightToLeft       = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition     = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text              = "إضافة موظف جديد";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.grpBasic.ResumeLayout(false);
            this.tlpBasic.ResumeLayout(false);
            this.tlpBasic.PerformLayout();
            this.panelDoctorFields.ResumeLayout(false);
            this.grpDoctor.ResumeLayout(false);
            this.tlpDoctor.ResumeLayout(false);
            this.tlpDoctor.PerformLayout();
            this.panelScheduleArea.ResumeLayout(false);
            this.grpSchedule.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // ── صنع حقل الهاتف مع رسالة الخطأ ──────────────────────────────
        private System.Windows.Forms.Panel BuildPhonePanel()
        {
            var panel = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Fill, Margin = new System.Windows.Forms.Padding(4, 6, 4, 2) };
            this.txtPhone.Dock          = System.Windows.Forms.DockStyle.Top;
            this.txtPhone.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPhone.BorderStyle   = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Height        = 26;
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.Dock     = System.Windows.Forms.DockStyle.Top;
            this.lblPhoneError.Font     = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPhoneError.ForeColor = System.Drawing.Color.FromArgb(200, 0, 0);
            this.lblPhoneError.Text     = "* رقم الهاتف يجب أن يكون 10 أرقام";
            this.lblPhoneError.Visible  = false;
            panel.Controls.Add(this.lblPhoneError);
            panel.Controls.Add(this.txtPhone);
            return panel;
        }

        // ── صنع حقل النسبة مع رسالة الخطأ ──────────────────────────────
        private System.Windows.Forms.Panel BuildPercentagePanel()
        {
            var panel = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Fill, Margin = new System.Windows.Forms.Padding(4, 6, 4, 2) };
            this.txtPercentage.Dock        = System.Windows.Forms.DockStyle.Top;
            this.txtPercentage.Font        = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPercentage.Text        = "40";
            this.txtPercentage.Height      = 26;
            this.lblPercentageError.AutoSize  = true;
            this.lblPercentageError.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblPercentageError.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPercentageError.ForeColor = System.Drawing.Color.FromArgb(200, 0, 0);
            this.lblPercentageError.Text      = "* يجب أن تكون ≤ 100";
            this.lblPercentageError.Visible   = false;
            panel.Controls.Add(this.lblPercentageError);
            panel.Controls.Add(this.txtPercentage);
            return panel;
        }

        // ── مساعدات بناء الـ UI ─────────────────────────────────────────
        private static System.Windows.Forms.Label MakeLbl(string text) =>
            new System.Windows.Forms.Label
            {
                Text      = text,
                Font      = new System.Drawing.Font("Segoe UI", 9F),
                ForeColor = System.Drawing.Color.FromArgb(55, 65, 81),
                Dock      = System.Windows.Forms.DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleRight,
                Margin    = new System.Windows.Forms.Padding(2)
            };

        private static void StyleTxt(System.Windows.Forms.TextBox t)
        {
            t.Dock        = System.Windows.Forms.DockStyle.Fill;
            t.Font        = new System.Drawing.Font("Segoe UI", 9.5F);
            t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            t.Margin      = new System.Windows.Forms.Padding(4, 8, 4, 4);
        }

        private static void StyleCmb(System.Windows.Forms.ComboBox c)
        {
            c.Dock          = System.Windows.Forms.DockStyle.Fill;
            c.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            c.Margin        = new System.Windows.Forms.Padding(4, 8, 4, 4);
        }

        #endregion

        // ── Fields ──────────────────────────────────────────────────────
        private System.Windows.Forms.Panel            panelHeader, panelHeaderLine, panelMain;
        private System.Windows.Forms.Label            lblTitle;
        private System.Windows.Forms.GroupBox         grpBasic;
        private System.Windows.Forms.TableLayoutPanel tlpBasic;
        private System.Windows.Forms.TextBox          txtFullName, txtUsername, txtPassword, txtPhone;
        private System.Windows.Forms.Label            lblPhoneError, lblHireDateValue;
        private System.Windows.Forms.ComboBox         cmbRole, cmbGender;
        private System.Windows.Forms.Panel            panelDoctorFields;
        private System.Windows.Forms.GroupBox         grpDoctor;
        private System.Windows.Forms.TableLayoutPanel tlpDoctor;
        private System.Windows.Forms.ComboBox         cmbSpeciality, cmbRoom;
        private System.Windows.Forms.TextBox          txtPercentage, txtLicense, txtExperience;
        private System.Windows.Forms.Label            lblPercentageError;
        private System.Windows.Forms.Panel            panelScheduleArea;
        private System.Windows.Forms.GroupBox         grpSchedule;
        private System.Windows.Forms.Panel            panelScheduleContent;
        private System.Windows.Forms.Panel            panelFooter, panelFooterLine;
        private System.Windows.Forms.Button           btnSave, btnCancel;
    }
}
