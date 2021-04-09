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
    public partial class BasicInformation : UserControl
    {



        public BasicInformation()
        {
            InitializeComponent();
        }

        string path;
        private void BasicInformation_Load(object sender, EventArgs e)
        {
            lb_client.Text = System.Windows.Forms.SystemInformation.ComputerName;
            lb_dom.Text = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            if (lb_dom.Text == "")
            {
                lb_dom.Text = "WORKGROUP";
            }


            ManagementObjectSearcher searcher =
                     new ManagementObjectSearcher("root\\CIMV2",
                     "SELECT * FROM Win32_NetworkAdapter");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                var MACAddress = queryObj["MACAddress"];
                var NetConnectionID = queryObj["NetConnectionID"];
                if (Convert.ToString(NetConnectionID) == "Wi-Fi")
                {
                    lb_WLAN.Text = Convert.ToString(MACAddress);
                }

                if (Convert.ToString(NetConnectionID) == "Ethernet")
                {
                    lb_ethernet.Text = Convert.ToString(MACAddress);
                }
            }

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ipInterface = nic.GetIPProperties();
                    if (ipInterface.GatewayAddresses.Count > 0)
                    {
                        foreach (UnicastIPAddressInformation unicastAddress in ipInterface.UnicastAddresses)
                        {
                            if ((unicastAddress.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) && (unicastAddress.IPv4Mask.ToString() != "0.0.0.0"))
                            {
                                lb_IP.Text = unicastAddress.Address.ToString();
                                break;

                            }
                        }
                    }

                }
            }
            lb_felhasznalo.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').Last();
            string maj = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentMajorVersionNumber", "").ToString();
            string min = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentMinorVersionNumber", "").ToString();
            string build = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", "").ToString();
            string release = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseId", "").ToString();
            string upd = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "InstallDate", "").ToString();

            lb_os.Text = "Windows " + maj + "." + min;
            lb_currentbuild.Text = build + " (" + release + ")";


            //https://stackoverflow.com/questions/1584711/how-do-i-search-for-a-list-of-files-using-wildcard
            //https://stackoverflow.com/questions/23243336/how-to-get-file-created-date-and-modified-date
            //https://docs.microsoft.com/en-us/dotnet/api/system.io.file.getlastwritetime?view=net-5.0
            DirectoryInfo folder = new DirectoryInfo(@"C:\Windows\Logs\WindowsUpdate");
            DateTime dt = File.GetLastWriteTime(Convert.ToString(folder));
            lb_lastup.Text = Convert.ToString(dt);

            //https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-computersystem
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            if (moc.Count != 0)
            {
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    lb_gyarto.Text = mo["Manufacturer"].ToString();
                    lb_modell.Text = mo["Model"].ToString();
                }
            }

            //https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-bios
            //https://stackoverflow.com/questions/10320493/trying-to-get-win32-bios-version-by-using-a-path-string
            ManagementClass bios = new ManagementClass("Win32_BIOS");
            ManagementObjectCollection bs = bios.GetInstances();
            if (bs.Count != 0)
            {
                foreach (ManagementObject bss in bios.GetInstances())
                {
                    lb_biosver.Text = bss["SMBIOSBIOSVersion"].ToString();
                }
            }

            DriveInfo[] allDrives = DriveInfo.GetDrives();


            //https://docs.microsoft.com/en-us/dotnet/api/system.io.driveinfo.availablefreespace?view=net-5.0
            //https://stackoverflow.com/questions/781905/getting-a-list-of-logical-drives
            string[] drives = System.IO.Directory.GetLogicalDrives();
            string windrive = Path.GetPathRoot(Environment.SystemDirectory);

            foreach (DriveInfo d in allDrives)
            {
                var Name = d.Name;
                    var TotalFreeSpace = d.TotalFreeSpace;
                    if (windrive.Contains(Convert.ToString(Name)))
                    {
                        long meret = Convert.ToInt64(TotalFreeSpace);
                        string gb = Convert.ToString(ConvertBytesToGigabytes(meret));
                        lb_sysdrive.Text = Convert.ToString(gb+ " GB");
                    }
            }


            using (StreamWriter sw = new StreamWriter(Environment.GetEnvironmentVariable("TEMP")+ @"\info.txt"))
            {
                sw.WriteLine(lb_client.Text);
                sw.WriteLine(lb_dom.Text);
                sw.WriteLine(lb_felhasznalo.Text);
                sw.WriteLine(lb_sysdrive.Text);
                sw.WriteLine(lb_os.Text);
                sw.WriteLine(lb_currentbuild.Text);
                sw.WriteLine(lb_lastup.Text);
                sw.WriteLine(lb_ethernet.Text);
                sw.WriteLine(lb_WLAN.Text);
                sw.WriteLine(lb_IP.Text);
                sw.WriteLine(lb_gyarto.Text);
                sw.WriteLine(lb_modell.Text);
                sw.WriteLine(lb_biosver.Text);
                sw.Close();

            }
            
        }


        static double ConvertBytesToGigabytes(long bytes)
        {
            int giga = Convert.ToInt32(((bytes / 1024f) / 1024f) / 1024f);
            return giga;
        }

        
        private void bt_export_Click(object sender, EventArgs e)
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.Copy((Environment.GetEnvironmentVariable("TEMP") + @"\info.txt"), path + @"\info.txt", true);

        }

        private void bt_tovabbidrive_Click(object sender, EventArgs e)
        {
            Diskinfo disk = new Diskinfo();
            disk.Show();

        }
    }
}
