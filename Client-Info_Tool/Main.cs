using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.Globalization;
using System.Management;
using System.Text.RegularExpressions;

namespace Client_Info_Tool
{
    public partial class ClientInfo : Form
    {
        
        public ClientInfo()
        {
            InitializeComponent();            
        }


        private void ClientInfo_Load(object sender, EventArgs e)
        {
            sWandUpdates1.Hide();
            basicInformation1.Show();
            hw1.Hide();
            detectedErrors1.Hide();
            startBuiltInApps1.Hide();
            contactHD1.Hide();
        }
        private void bt_alapvetoinfo_Click(object sender, EventArgs e)
        {
            sWandUpdates1.Hide();
            basicInformation1.Show();
            hw1.Hide();
            detectedErrors1.Hide();
            startBuiltInApps1.Hide();
            contactHD1.Hide();

        }

        private void bt_installeswupd_Click(object sender, EventArgs e)
        {
            sWandUpdates1.Show();
            basicInformation1.Hide();
            hw1.Hide();
            detectedErrors1.Hide();
            startBuiltInApps1.Hide();
            contactHD1.Hide();
        }

        private void bt_hwinf_Click(object sender, EventArgs e)
        {
            sWandUpdates1.Hide();
            basicInformation1.Hide();
            hw1.Show();
            detectedErrors1.Hide();
            startBuiltInApps1.Hide();
            contactHD1.Hide();
        }

        private void bt_failure_Click(object sender, EventArgs e)
        {
            sWandUpdates1.Hide();
            basicInformation1.Hide();
            hw1.Hide();
            detectedErrors1.Show();
            startBuiltInApps1.Hide();
            contactHD1.Hide();
        }

        public void bt_hd_Click(object sender, EventArgs e)
        {
            sWandUpdates1.Hide();
            basicInformation1.Hide();
            hw1.Hide();
            detectedErrors1.Hide();
            startBuiltInApps1.Hide();
            contactHD1.Show();

        }

        private void bt_wintools_Click(object sender, EventArgs e)
        {
            sWandUpdates1.Hide();
            basicInformation1.Hide();
            hw1.Hide();
            detectedErrors1.Hide();
            startBuiltInApps1.Show();
            contactHD1.Hide();
        }

        string path;
        private void ClientInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            path = Environment.GetEnvironmentVariable("TEMP");
            File.Delete(path + @"\info.txt");
        }
    }
}
