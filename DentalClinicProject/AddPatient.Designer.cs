namespace DentalClinicProject
{
    partial class AddPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatient));
            this.FullName = new System.Windows.Forms.Label();
            this.NumberPho = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.fullNameTxt = new System.Windows.Forms.TextBox();
            this.NumPhoneTxt = new System.Windows.Forms.TextBox();
            this.noteTxt = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newPatientLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.NewBtn = new System.Windows.Forms.Button();
            this.FileNo = new System.Windows.Forms.Label();
            this.TextFileNum = new System.Windows.Forms.Label();
            this.saveAndCloseBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(1184, 44);
            this.FullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullName.Name = "FullName";
            this.FullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FullName.Size = new System.Drawing.Size(167, 46);
            this.FullName.TabIndex = 0;
            this.FullName.Text = "الاسم كامل:";
            this.FullName.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumberPho
            // 
            this.NumberPho.AutoSize = true;
            this.NumberPho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberPho.Location = new System.Drawing.Point(453, 273);
            this.NumberPho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberPho.Name = "NumberPho";
            this.NumberPho.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NumberPho.Size = new System.Drawing.Size(169, 46);
            this.NumberPho.TabIndex = 1;
            this.NumberPho.Text = "رقم الهاتف:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(1252, 273);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AgeLabel.Size = new System.Drawing.Size(99, 46);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "العمر:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(486, 448);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenderLabel.Size = new System.Drawing.Size(111, 46);
            this.GenderLabel.TabIndex = 4;
            this.GenderLabel.Text = "الجنس:";
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.Location = new System.Drawing.Point(855, 90);
            this.fullNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.fullNameTxt.Multiline = true;
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.Size = new System.Drawing.Size(327, 77);
            this.fullNameTxt.TabIndex = 6;
            // 
            // NumPhoneTxt
            // 
            this.NumPhoneTxt.Location = new System.Drawing.Point(94, 275);
            this.NumPhoneTxt.Margin = new System.Windows.Forms.Padding(4);
            this.NumPhoneTxt.Multiline = true;
            this.NumPhoneTxt.Name = "NumPhoneTxt";
            this.NumPhoneTxt.Size = new System.Drawing.Size(351, 58);
            this.NumPhoneTxt.TabIndex = 7;
            // 
            // noteTxt
            // 
            this.noteTxt.Location = new System.Drawing.Point(718, 442);
            this.noteTxt.Margin = new System.Windows.Forms.Padding(4);
            this.noteTxt.Multiline = true;
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.Size = new System.Drawing.Size(472, 67);
            this.noteTxt.TabIndex = 11;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(1198, 445);
            this.notesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notesLabel.Size = new System.Drawing.Size(153, 46);
            this.notesLabel.TabIndex = 12;
            this.notesLabel.Text = "ملاحظات:";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(867, 273);
            this.Age.Margin = new System.Windows.Forms.Padding(4);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(323, 53);
            this.Age.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.newPatientLabel);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 122);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // newPatientLabel
            // 
            this.newPatientLabel.AutoSize = true;
            this.newPatientLabel.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.newPatientLabel.Location = new System.Drawing.Point(1058, 21);
            this.newPatientLabel.Name = "newPatientLabel";
            this.newPatientLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.newPatientLabel.Size = new System.Drawing.Size(349, 61);
            this.newPatientLabel.TabIndex = 53;
            this.newPatientLabel.Text = "بيانات مريض جديد";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(135, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 47);
            this.label11.TabIndex = 52;
            this.label11.Text = "DentCare";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.cmbGender);
            this.panel2.Controls.Add(this.NewBtn);
            this.panel2.Controls.Add(this.FileNo);
            this.panel2.Controls.Add(this.TextFileNum);
            this.panel2.Controls.Add(this.Age);
            this.panel2.Controls.Add(this.saveAndCloseBtn);
            this.panel2.Controls.Add(this.notesLabel);
            this.panel2.Controls.Add(this.noteTxt);
            this.panel2.Controls.Add(this.NumPhoneTxt);
            this.panel2.Controls.Add(this.fullNameTxt);
            this.panel2.Controls.Add(this.GenderLabel);
            this.panel2.Controls.Add(this.AgeLabel);
            this.panel2.Controls.Add(this.NumberPho);
            this.panel2.Controls.Add(this.FullName);
            this.panel2.Location = new System.Drawing.Point(13, 132);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1399, 707);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(222, 442);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(228, 54);
            this.cmbGender.TabIndex = 18;
            // 
            // NewBtn
            // 
            this.NewBtn.BackColor = System.Drawing.Color.LightGray;
            this.NewBtn.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBtn.Location = new System.Drawing.Point(336, 563);
            this.NewBtn.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(223, 62);
            this.NewBtn.TabIndex = 34;
            this.NewBtn.Text = "جديد";
            this.NewBtn.UseVisualStyleBackColor = false;
            // 
            // FileNo
            // 
            this.FileNo.AutoSize = true;
            this.FileNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNo.Location = new System.Drawing.Point(324, 90);
            this.FileNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileNo.Name = "FileNo";
            this.FileNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FileNo.Size = new System.Drawing.Size(147, 46);
            this.FileNo.TabIndex = 17;
            this.FileNo.Text = "رقم الملف";
            // 
            // TextFileNum
            // 
            this.TextFileNum.AutoSize = true;
            this.TextFileNum.Location = new System.Drawing.Point(229, 90);
            this.TextFileNum.Name = "TextFileNum";
            this.TextFileNum.Size = new System.Drawing.Size(0, 46);
            this.TextFileNum.TabIndex = 16;
            // 
            // saveAndCloseBtn
            // 
            this.saveAndCloseBtn.BackColor = System.Drawing.Color.Blue;
            this.saveAndCloseBtn.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAndCloseBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveAndCloseBtn.Location = new System.Drawing.Point(39, 563);
            this.saveAndCloseBtn.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.saveAndCloseBtn.Name = "saveAndCloseBtn";
            this.saveAndCloseBtn.Size = new System.Drawing.Size(282, 68);
            this.saveAndCloseBtn.TabIndex = 35;
            this.saveAndCloseBtn.Text = "حفظ وإغلاق";
            this.saveAndCloseBtn.UseVisualStyleBackColor = false;
            this.saveAndCloseBtn.Click += new System.EventHandler(this.saveAndCloseBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(911, 715);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 46);
            this.label4.TabIndex = 16;
            this.label4.Text = "|";
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1417, 862);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPatient";
            this.Text = "AddPatient";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label NumberPho;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.TextBox fullNameTxt;
        private System.Windows.Forms.TextBox NumPhoneTxt;
        private System.Windows.Forms.TextBox noteTxt;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.DateTimePicker Age;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label newPatientLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button saveAndCloseBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TextFileNum;
        private System.Windows.Forms.Label FileNo;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}