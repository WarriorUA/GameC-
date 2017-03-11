using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Microsoft.Win32.RegistryKey reg;
            reg =
                Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {

                reg.SetValue("MyProgram", Application.ExecutablePath);

                reg.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             if (MessageBox.Show("Off", "off", MessageBoxButtons.OKCancel) == DialogResult.OK)
             {
            System.Diagnostics.Process.Start("cmd", "/c shutdown -s -f -t 00");
        }

        Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
