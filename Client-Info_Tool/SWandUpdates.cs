using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;

namespace Client_Info_Tool
{
    public partial class SWandUpdates : UserControl
    {
        public SWandUpdates()
        {
            InitializeComponent();
        }

        private void SWandUpdates_Load(object sender, EventArgs e)
        {

            metroListView1.BeginUpdate();
            metroListView1.Items.Clear();
            metroListView1.View = View.Details;

            string uninstallKey = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            getinstalledHKLMsw(uninstallKey);
            metroListView1.Items.Clear();
            string uninstallKey64 = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            getinstalledHKLMsw(uninstallKey64);


            string uninstallKeyCU = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            getinstalledHKCUsw(uninstallKeyCU);

            metroListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            metroListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            metroListView1.EndUpdate();
            metroListView1.AllowSorting = true;


            metroListView2.BeginUpdate();
            metroListView2.Items.Clear();
            metroListView2.View = View.Details;
            MyWMIQuery();
            metroListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            metroListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            metroListView2.EndUpdate();
            metroListView2.AllowSorting = true;


        }


        private void getinstalledHKLMsw(string uninstallKey)
        {
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                            var displayName = sk.GetValue("DisplayName");
                            var displayVersion = sk.GetValue("DisplayVersion");
                            var publisher = sk.GetValue("Publisher");
                            string instdate = Convert.ToString(sk.GetValue("InstallDate"));
                            //DateTime dt = DateTime.ParseExact(instdate, "yyyyMMdd", null);
                            ListViewItem lvi;
                            lvi = new ListViewItem(new string[] { Convert.ToString(displayName), Convert.ToString(displayVersion), Convert.ToString(publisher), Convert.ToString(instdate) });
                            if (displayName != null)
                            {
                                metroListView1.Items.Add(lvi);
                            }


                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(Convert.ToString(e));
                        }
                    }
                }

            }
        }


        private void getinstalledHKCUsw(string uninstallKey)
        {
            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                            var displayName = sk.GetValue("DisplayName");
                            var displayVersion = sk.GetValue("DisplayVersion");
                            var publisher = sk.GetValue("Publisher");
                            string instdate = Convert.ToString(sk.GetValue("InstallDate"));
                            //DateTime dt = DateTime.ParseExact(instdate, "yyyyMMdd", null);
                            ListViewItem lvi;
                            lvi = new ListViewItem(new string[] { Convert.ToString(displayName), Convert.ToString(displayVersion), Convert.ToString(publisher), Convert.ToString(instdate) });
                            if (displayName != null)
                            {
                                metroListView1.Items.Add(lvi);
                            }


                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(Convert.ToString(e));
                        }
                    }
                }

            }
        }


        private void MyWMIQuery()
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_QuickFixEngineering");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    var Caption = queryObj["Caption"];
                    var Description = queryObj["Description"];
                    var HotFixID = queryObj["HotFixID"];
                    string InstalledOn = Convert.ToString(queryObj["InstalledOn"]);
                    //string instdate = Convert.ToString(sk.GetValue("InstallDate"));
                    //DateTime dt = DateTime.ParseExact(InstalledOn, "yyyyMMdd", null);
                    ListViewItem lvi1;
                    lvi1 = new ListViewItem(new string[] { Convert.ToString(HotFixID), Convert.ToString(Description), Convert.ToString(Caption), Convert.ToString(InstalledOn) });
                    metroListView2.Items.Add(lvi1);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }
    }
} 
