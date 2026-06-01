using DentalClinicProject.classes;
using DentalClinicProject.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DentalClinicProject
{
    public partial class PatientRecordForm : Form
    {
        public PatientRecordForm()
        {
            InitializeComponent();
        }
   
     
        private void PatientRecordForm_Load(object sender, EventArgs e)
        {
            
            searchCmb.Items.Add("أحمد");
            searchCmb.Items.Add("علي");
         

        }

    }
}
                                                                                          