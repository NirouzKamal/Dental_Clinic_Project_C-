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

                 while (true)
                 {
                     using (var login = new LoginForm())
                     {
                         if (login.ShowDialog() != DialogResult.OK)
                             break;
                     }

                     using (var shell = new UI.MainShellFormUI())
                     {
                         shell.ShowDialog();
                         if (!shell.LogoutRequested)
                             break;
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString(), "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }
    }
}
