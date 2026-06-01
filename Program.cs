using DentalClinicProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             try
             {
                 DataStore.Initialize();
                 LoginForm login = new LoginForm();
                 if (login.ShowDialog() == DialogResult.OK)
                 {
                     Application.Run(new UI.MainShellFormUI());
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString(), "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }
    }
}
