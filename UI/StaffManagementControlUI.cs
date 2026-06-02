using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DentalClinicProject.Data;

namespace DentalClinicProject.UI
{
    public partial class StaffManagementControlUI : System.Windows.Forms.UserControl
    {
        public StaffManagementControlUI()
        {
            InitializeComponent();
            SetupLogic();
        }

        private void SetupLogic()
        {
            // ── تطبيق ألوان رأس الجدول هنا (بعد EndInit) لتجنب الخطأ ──────
            this.Load += (s, e) =>
            {
                ApplyGridHeaderStyle();
                LoadStaff();
            };

            // تنسيق الخلايا لتجنب استدعاء DefaultCellStyle أثناء الإضافة مما يسبب خطأ
            dgvStaff.CellFormatting += DgvStaff_CellFormatting;

            // البحث الفوري
            txtSearch.TextChanged += (s, e) => LoadStaff(txtSearch.Text);
            txtSearch.Enter += (s, e) =>
            { if (txtSearch.Text == "ابحث بالاسم...") txtSearch.Text = ""; };
            txtSearch.Leave += (s, e) =>
            { if (string.IsNullOrWhiteSpace(txtSearch.Text)) txtSearch.Text = "ابحث بالاسم..."; };

            // إضافة موظف
            btnAddStaff.Click += (s, e) =>
            {
                using (var form = new AddStaffFormUI())
                    if (form.ShowDialog() == DialogResult.OK) LoadStaff();
            };

            // حذف موظف
            btnDeleteStaff.Click += OnDeleteStaff;

            // تفعيل/تعطيل زر الحذف حسب التحديد
            dgvStaff.SelectionChanged += (s, e) =>
                btnDeleteStaff.Enabled = dgvStaff.SelectedRows.Count > 0;
        }

        private void DgvStaff_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // إذا كان الموظف موقوفاً، نجعل لونه رمادياً
            var statusVal = dgvStaff.Rows[e.RowIndex].Cells[5].Value?.ToString();
            if (statusVal == "✗ موقوف")
            {
                e.CellStyle.ForeColor = Color.FromArgb(170, 170, 170);
            }
            else
            {
                e.CellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            }
        }

        // ── تطبيق ألوان الرأس بعد تحميل الكنترول ─────────────────────────
        private void ApplyGridHeaderStyle()
        {
            var headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(0, 75, 155),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            dgvStaff.ColumnHeadersDefaultCellStyle = headerStyle;

            var cellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(210, 225, 245),
                SelectionForeColor = Color.FromArgb(33, 37, 41)
            };
            dgvStaff.DefaultCellStyle = cellStyle;
        }

        // ════════════════════════════════════════════════════════════════
        //  تحميل الموظفين من SQL Server
        // ════════════════════════════════════════════════════════════════
        private void LoadStaff(string search = "")
        {
            dgvStaff.Rows.Clear();

            const string sql = @"
                SELECT
                     u.UserId,
                     u.FullName,
                     u.UserName,
                     ISNULL(u.Phone, '') AS Phone,
                     u.IsActive,
                     CASE
                         WHEN u.UserId LIKE 'ADM%' THEN N'مدير نظام'
                         WHEN u.UserId LIKE 'DOC%' THEN N'طبيب'
                         WHEN u.UserId LIKE 'REC%' THEN N'استقبال'
                         ELSE N'غير محدد'
                     END AS RoleName
                 FROM dbo.Users u
                 WHERE (@Search = ''
                        OR u.FullName LIKE '%' + @Search + '%'
                        OR u.UserName LIKE '%' + @Search + '%')
                 ORDER BY u.UserId";

            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var cmd  = new SqlCommand(sql, conn))
                {
                    string term = (search == "ابحث بالاسم..." || string.IsNullOrWhiteSpace(search))
                                  ? "" : search.Trim();
                    cmd.Parameters.Add(new SqlParameter("@Search", SqlDbType.NVarChar, 100) { Value = term });

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            bool active = Convert.ToBoolean(rdr["IsActive"]);
                            dgvStaff.Rows.Add(
                                rdr["UserId"].ToString(),
                                rdr["FullName"].ToString(),
                                rdr["UserName"].ToString(),
                                rdr["RoleName"].ToString(),
                                rdr["Phone"].ToString(),
                                active ? "✓ نشط" : "✗ موقوف"
                            );
                        }
                    }
                }
            }
            catch (SqlException)
            {
                // لا يوجد اتصال بقاعدة البيانات — نعرض الجدول فارغاً بدون خطأ
                dgvStaff.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "تعذّر تحميل قائمة الموظفين.\nالسبب: " + ex.Message,
                    "خطأ في تحميل البيانات",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
        }

        // ════════════════════════════════════════════════════════════════
        //  حذف الموظف المحدد
        // ════════════════════════════════════════════════════════════════
        private void OnDeleteStaff(object sender, EventArgs e)
        {
            // ── التأكد من وجود صف محدد ───────────────────────────────────
            if (dgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "يرجى تحديد موظف من القائمة أولاً.",
                    "لم يتم التحديد",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }

            DataGridViewRow selectedRow = dgvStaff.SelectedRows[0];

            // ── استخراج البيانات بالفهرس (أكثر أماناً من الاسم) ──────────
            string userId   = selectedRow.Cells[0].Value?.ToString();  // colId   (index 0)
            string fullName = selectedRow.Cells[1].Value?.ToString();  // colName (index 1)

            if (string.IsNullOrWhiteSpace(userId))
            {
                MessageBox.Show(
                    "تعذّر تحديد هوية الموظف المحدد. يرجى إعادة المحاولة.",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }

            // ── تأكيد الحذف مع اسم الموظف ────────────────────────────────
            var confirm = MessageBox.Show(
                $"هل أنت متأكد من حذف الموظف:\n\n" +
                $"   الاسم : {fullName}\n" +
                $"   المعرّف : {userId}\n\n" +
                "⚠  سيتم حذف جميع بياناته نهائياً ولا يمكن التراجع عن هذا الإجراء.",
                "تأكيد الحذف النهائي",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

            if (confirm != DialogResult.Yes) return;

            // ── تنفيذ الحذف بترتيب صحيح داخل Transaction ────────────────
            try
            {
                using (var conn = DbHelper.GetConnection())
                using (var tx   = conn.BeginTransaction())
                {
                    // 1) حذف جدول الدوام
                    ExecuteNonQuery(conn, tx,
                        @"DELETE ds FROM dbo.DentistSchedule ds
                          INNER JOIN dbo.Dentist d ON ds.DentistId = d.DentistId
                          WHERE d.UserId = @UserId",
                        userId);

                    // 2) حذف سجل الطبيب
                    ExecuteNonQuery(conn, tx,
                        "DELETE FROM dbo.Dentist WHERE UserId = @UserId",
                        userId);

                    // 3) حذف المستخدم
                    ExecuteNonQuery(conn, tx,
                        "DELETE FROM dbo.Users WHERE UserId = @UserId",
                        userId);

                    tx.Commit();
                }

                MessageBox.Show(
                    $"تم حذف الموظف «{fullName}» وجميع بياناته بنجاح.",
                    "تم الحذف",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                LoadStaff(txtSearch.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "تعذّر حذف الموظف من قاعدة البيانات.\n" +
                    "قد يكون هناك سجلات مرتبطة تمنع الحذف.\n\n" +
                    "تفاصيل: " + ex.Message,
                    "خطأ في الحذف",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "حدث خطأ غير متوقع أثناء الحذف.\n\nالتفاصيل: " + ex.Message,
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
        }

        // ── مساعد: تنفيذ استعلام حذف داخل Transaction ───────────────────
        private static void ExecuteNonQuery(SqlConnection conn, SqlTransaction tx, string sql, string userId)
        {
            using (var cmd = new SqlCommand(sql, conn, tx))
            {
                cmd.Parameters.Add(new SqlParameter("@UserId", SqlDbType.NVarChar, 50) { Value = userId });
                cmd.ExecuteNonQuery();
            }
        }
    }
}
