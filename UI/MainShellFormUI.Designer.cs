namespace DentalClinicProject.UI
{
    partial class MainShellFormUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnRevenues = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.panelHeaderBorder = new System.Windows.Forms.Panel();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.White;
            this.panelSidebar.Controls.Add(this.btnPayroll);
            this.panelSidebar.Controls.Add(this.btnStaff);
            this.panelSidebar.Controls.Add(this.btnRevenues);
            this.panelSidebar.Controls.Add(this.btnRecords);
            this.panelSidebar.Controls.Add(this.btnAppointments);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.lblLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 761);
            this.panelSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(250, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "DentCare";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(155)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 80);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(250, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "لوحة التحكم";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackColor = System.Drawing.Color.White;
            this.btnAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointments.FlatAppearance.BorderSize = 0;
            this.btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAppointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnAppointments.Location = new System.Drawing.Point(0, 130);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAppointments.Size = new System.Drawing.Size(250, 50);
            this.btnAppointments.TabIndex = 2;
            this.btnAppointments.Text = "إدارة المواعيد";
            this.btnAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppointments.UseVisualStyleBackColor = false;
            // 
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.Color.White;
            this.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnRecords.Location = new System.Drawing.Point(0, 180);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRecords.Size = new System.Drawing.Size(250, 50);
            this.btnRecords.TabIndex = 3;
            this.btnRecords.Text = "سجل الحالات";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecords.UseVisualStyleBackColor = false;
            // 
            // btnRevenues
            // 
            this.btnRevenues.BackColor = System.Drawing.Color.White;
            this.btnRevenues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenues.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevenues.FlatAppearance.BorderSize = 0;
            this.btnRevenues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRevenues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnRevenues.Location = new System.Drawing.Point(0, 230);
            this.btnRevenues.Name = "btnRevenues";
            this.btnRevenues.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRevenues.Size = new System.Drawing.Size(250, 50);
            this.btnRevenues.TabIndex = 4;
            this.btnRevenues.Text = "الإيرادات";
            this.btnRevenues.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRevenues.UseVisualStyleBackColor = false;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.White;
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnStaff.Location = new System.Drawing.Point(0, 280);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(250, 50);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "إدارة الموظفين";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaff.UseVisualStyleBackColor = false;
            // 
            // btnPayroll
            // 
            this.btnPayroll.BackColor = System.Drawing.Color.White;
            this.btnPayroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayroll.FlatAppearance.BorderSize = 0;
            this.btnPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayroll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPayroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnPayroll.Location = new System.Drawing.Point(0, 330);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPayroll.Size = new System.Drawing.Size(250, 50);
            this.btnPayroll.TabIndex = 6;
            this.btnPayroll.Text = "إدارة الرواتب";
            this.btnPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayroll.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblDate);
            this.panelHeader.Controls.Add(this.lblUserInfo);
            this.panelHeader.Controls.Add(this.panelHeaderBorder);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(934, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // panelHeaderBorder
            // 
            this.panelHeaderBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panelHeaderBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderBorder.Location = new System.Drawing.Point(0, 59);
            this.panelHeaderBorder.Name = "panelHeaderBorder";
            this.panelHeaderBorder.Size = new System.Drawing.Size(934, 1);
            this.panelHeaderBorder.TabIndex = 0;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblUserInfo.Location = new System.Drawing.Point(20, 20);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(175, 21);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "مرحباً: د. ريم الطبيب";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblDate.Location = new System.Drawing.Point(600, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(150, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "الأحد ، 01 يونيو 2026";
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(250, 60);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(934, 701);
            this.panelMainContent.TabIndex = 2;
            // 
            // MainShellFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Name = "MainShellFormUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DentCare - النظام الأساسي";
            this.panelSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnRevenues;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelHeaderBorder;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panelMainContent;
    }
}


