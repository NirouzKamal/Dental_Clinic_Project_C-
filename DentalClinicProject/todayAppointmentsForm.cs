using DentalClinicProject.classes;
using DentalClinicProject.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicProject
{
    public partial class todayAppointmentsForm : Form
    {
        private Doctor currentDoctor;
        public todayAppointmentsForm()
        {
            InitializeComponent();

        }
        public todayAppointmentsForm(Doctor doctor)
        {
            InitializeComponent();
            currentDoctor = doctor;
        }

        private void todayAppointmentsForm_Load(object sender, EventArgs e)
        {
            LoadTodayCases();
        }
        private void LoadTodayCases()
        {
            todayAppointmentsDgv.Rows.Clear();

            var todayCases = DataStore.Cases
                .Where(c =>
                    c.DoctorId == currentDoctor.DoctorId &&
                    c.OpenedDate.Date == DateTime.Today)
                .OrderByDescending(c => c.OpenedDate)
                .ToList();

            foreach (var c in todayCases)
            {
                todayAppointmentsDgv.Rows.Add(
                   
                    c.PatientFileNumber,
                    c.PatientName,
                    currentDoctor.FullName,
                     c.OpenedDate.ToString("hh:mm tt"),
                    c.Treatment,

                   c.Price,  
                   
                    c.Notes,
                    c.Status.ToString(),
                    c.CaseId
                );
            }
        }

        private void todayAppointmentsDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex < 0) return;

                int caseId = Convert.ToInt32(
                    todayAppointmentsDgv.Rows[e.RowIndex].Cells[8].Value);

                var selectedCase = DataStore.Cases
                    .FirstOrDefault(c => c.CaseId == caseId);

                if (selectedCase == null) return;

                CaseCreation frm =
    new CaseCreation(selectedCase, CaseFormMode.DoctorEdit);

                frm.ShowDialog();

                LoadTodayCases();
            }
        }

        private void todayAppointmentsDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
