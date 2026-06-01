using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DentalClinicProject.classes;
using DentalClinicProject.data;

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
            this.Load += (s, e) => LoadStaff();

            txtSearch.TextChanged += (s, e) => LoadStaff(txtSearch.Text);
            
            txtSearch.Enter += (s, e) => { if (txtSearch.Text == "ابحث بالاسم...") txtSearch.Text = ""; };
            txtSearch.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtSearch.Text)) txtSearch.Text = "ابحث بالاسم..."; };

            btnAddStaff.Click += (s, e) => {
                var addForm = new UI.AddStaffFormUI();
                if (addForm.ShowDialog() == DialogResult.OK) LoadStaff();
            };
        }

        private void LoadStaff(string searchTerm = "")
        {
            dgvStaff.Rows.Clear();

            var users = DataStore.Users.AsEnumerable();

            if (!string.IsNullOrEmpty(searchTerm) && searchTerm != "ابحث بالاسم...")
            {
                users = users.Where(u => 
                    (u.FullName != null && u.FullName.Contains(searchTerm)) ||
                    (u.Username != null && u.Username.Contains(searchTerm)));
            }

            foreach (var u in users)
            {
                string roleName = "موظف";
                switch (u.Role)
                {
                    case UserRole.Admin: roleName = "مدير نظام"; break;
                    case UserRole.Doctor: roleName = "طبيب"; break;
                    case UserRole.Receptionist: roleName = "استقبال"; break;
                }

                dgvStaff.Rows.Add(
                    u.UserId,
                    u.FullName ?? "غير محدد",
                    u.Username,
                    roleName,
                    u.Phone ?? "غير محدد"
                );
            }
        }
    }
}
