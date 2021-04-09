using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace Client_Info_Tool
{
    public partial class Diskinfo : Form
    {
        public Diskinfo()
        {
            InitializeComponent();
        }

        private void Diskinfo_Load(object sender, EventArgs e)
        {

            mlv_diskinfo.BeginUpdate();
            mlv_diskinfo.Items.Clear();
            mlv_diskinfo.View = View.Details;
            mlv_diskinfo.View = View.Details;
            GetDisks();
            mlv_diskinfo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            mlv_diskinfo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            mlv_diskinfo.EndUpdate();
            mlv_diskinfo.AllowSorting = true;
        }

        private void GetDisks()
        {
            List<string> Disk1 = new List<string>();
            List<string> Disk2 = new List<string>();

            string Caption = "";
            string Description = "";
            string DeviceID = "";
            string InterfaceType = "";
            string Manufacturer = "";
            string MediaType = "";
            string Model = "";
            string Name = "";
            string Partitions = "";
            string PNPDeviceID = "";
            string Size = "";
            string Status = "";

            ListViewItem lvidisk;
            int osszes = 0;
            Disk1.Clear();
            Disk2.Clear();
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_DiskDrive");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Caption = Convert.ToString(queryObj["Caption"]);
                    Description = Convert.ToString(queryObj["Description"]);
                    DeviceID = Convert.ToString(queryObj["DeviceID"]);
                    InterfaceType = Convert.ToString(queryObj["InterfaceType"]);
                    Manufacturer = Convert.ToString(queryObj["Manufacturer"]);
                    MediaType = Convert.ToString(queryObj["MediaType"]);
                    Model = Convert.ToString(queryObj["Model"]);
                    Name = Convert.ToString(queryObj["Name"]);
                    Partitions = Convert.ToString(queryObj["Partitions"]);
                    PNPDeviceID = Convert.ToString(queryObj["PNPDeviceID"]);
                    Size = Convert.ToString(queryObj["Size"]);
                    Status = Convert.ToString(queryObj["Status"]);

                    Disk1.Add(Convert.ToString(Caption));
                    Disk1.Add(Convert.ToString(Description));
                    Disk1.Add(Convert.ToString(DeviceID));
                    Disk1.Add(Convert.ToString(InterfaceType));
                    Disk1.Add(Convert.ToString(Manufacturer));
                    Disk1.Add(Convert.ToString(MediaType));
                    Disk1.Add(Convert.ToString(Model));
                    Disk1.Add(Convert.ToString(Name));
                    Disk1.Add(Convert.ToString(Partitions));
                    Disk1.Add(Convert.ToString(PNPDeviceID));
                    Disk1.Add(Convert.ToString(Size));
                    Disk1.Add(Convert.ToString(Status));
                    Disk1.Add("###############################");
                    Disk1.Add("");

                    Disk2.Add("Caption");
                    Disk2.Add("Description");
                    Disk2.Add("DeviceID");
                    Disk2.Add("InterfaceType");
                    Disk2.Add("Manufacturer");
                    Disk2.Add("MediaType");
                    Disk2.Add("Model");
                    Disk2.Add("Name");
                    Disk2.Add("Partitions");
                    Disk2.Add("PNPDeviceID");
                    Disk2.Add("Size");
                    Disk2.Add("Status");
                    Disk2.Add("###############################");
                    Disk2.Add("");
                }

                for (int i = 0; i < Disk1.Count; i++)
                {
                    lvidisk = new ListViewItem(new string[] { Disk2[i], Disk1[i] });
                    mlv_diskinfo.Items.Add(lvidisk);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }


        }
    }
}
