using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Client_Info_Tool
{
    public partial class StartBuiltInApps : UserControl
    {
        public StartBuiltInApps()
        {
            InitializeComponent();
        }

        private void StartBuiltInApps_Load(object sender, EventArgs e)
        {

        }

        private void bt_msinfo32_Click(object sender, EventArgs e)
        {
            StartProcess("msinfo32.exe");
        }

        private void bt_controlpanel_Click(object sender, EventArgs e)
        {
            StartProcess("appwiz.cpl");
        }

        private void bt_compmgmt_Click(object sender, EventArgs e)
        {
            StartProcess("compmgmt.msc");
        }

        private void bt_esemenynaplo_Click(object sender, EventArgs e)
        {
            StartProcess("eventvwr.msc");
        }

        private void StartProcess(string procname) 
        {
            Process process = new Process();
            process.StartInfo.FileName = procname;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.Start();
            process.WaitForExit();// Waits here for the process to exit.
        }
    }
}
