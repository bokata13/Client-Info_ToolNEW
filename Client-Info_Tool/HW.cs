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

namespace Client_Info_Tool
{
    public partial class HW : UserControl
    {
        public HW()
        {
            InitializeComponent();

        }

        private void HW_Load(object sender, EventArgs e)
        {

            mlview_Mainboard.BeginUpdate();
            mlview_Mainboard.Items.Clear();
            mlview_Mainboard.View = View.Details;
            MainBoard();
            mlview_Mainboard.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            mlview_Mainboard.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            mlview_Mainboard.EndUpdate();
            mlview_Mainboard.AllowSorting = true;


            mlview_Processor.BeginUpdate();
            mlview_Processor.Items.Clear();
            mlview_Processor.View = View.Details;
            mlview_Processor.View = View.Details;
            Processor();
            mlview_Processor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            mlview_Processor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            mlview_Processor.EndUpdate();
            mlview_Processor.AllowSorting = true;


            mlview_memoria.BeginUpdate();
            mlview_memoria.Items.Clear();
            mlview_memoria.View = View.Details;
            mlview_memoria.View = View.Details;
            Memoria();
            mlview_memoria.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            mlview_memoria.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            mlview_memoria.EndUpdate();
            mlview_memoria.AllowSorting = true;

            mlv_network.BeginUpdate();
            mlv_network.Items.Clear();
            mlv_network.View = View.Details;
            mlv_network.View = View.Details;
            NetworkCards();
            mlv_network.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            mlv_network.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            mlv_network.EndUpdate();
            mlv_network.AllowSorting = true;
            
        }



        private void MainBoard()
        {
            List<string> lista = new List<string>();
            List<string> lista2 = new List<string>();
            string Description = "";
            string Manufacturer = "";
            string Name = "";
            string Product = "";
            string SerialNumber = "";
            string Tag = "";
            string Status = "";
            string Version = "";
            ListViewItem lvimotherboard;
            lista.Clear();
            lista2.Clear();

            try
            {

                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_BaseBoard");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Description = Convert.ToString(queryObj["Description"]);
                    Manufacturer = Convert.ToString(queryObj["Manufacturer"]);
                    Name = Convert.ToString(queryObj["Name"]);
                    Product = Convert.ToString(queryObj["Product"]);
                    SerialNumber = Convert.ToString(queryObj["SerialNumber"]);
                    Tag = Convert.ToString(queryObj["Tag"]);
                    Version = Convert.ToString(queryObj["Version"]);
                    Status = Convert.ToString(queryObj["Status"]);

                    lista.Add(Convert.ToString(Description));
                    lista.Add(Convert.ToString(Manufacturer));
                    lista.Add(Convert.ToString(Name));
                    lista.Add(Convert.ToString(SerialNumber));
                    lista.Add(Convert.ToString(Tag));
                    lista.Add(Convert.ToString(Version));
                    lista.Add(Convert.ToString(Status));

                    lista2.Add("Description");
                    lista2.Add("Manufacturer");
                    lista2.Add("Name");
                    lista2.Add("SerialNumber");
                    lista2.Add("Tag");
                    lista2.Add("Version");
                    lista2.Add("Status");
                }

                


                for (int i = 0; i < lista.Count; i++)
                {
                    lvimotherboard = new ListViewItem(new string[] { lista2[i], lista[i] });
                    mlview_Mainboard.Items.Add(lvimotherboard);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }

        }

        private void Processor()
        {
            List<string> lista3 = new List<string>();
            List<string> lista4 = new List<string>();
            string Description = "";
            string Manufacturer = "";
            string Name = "";
            string ThreadCount = "";
            string SerialNumber = "";
            string NumberOfCores = "";
            string Status = "";
            string NumberOfLogicalProcessors = "";
            ListViewItem lviprocessor;
            lista3.Clear();
            lista4.Clear();

            try
            {

                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Processor");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Name = Convert.ToString(queryObj["Name"]);
                    Description = Convert.ToString(queryObj["Description"]);
                    Manufacturer = Convert.ToString(queryObj["Manufacturer"]);
                    NumberOfCores = Convert.ToString(queryObj["NumberOfCores"]);
                    NumberOfLogicalProcessors = Convert.ToString(queryObj["NumberOfLogicalProcessors"]);
                    ThreadCount = Convert.ToString(queryObj["ThreadCount"]);
                    SerialNumber = Convert.ToString(queryObj["SerialNumber"]);
                    Status = Convert.ToString(queryObj["Status"]);

                    lista3.Add(Convert.ToString(Name));
                    lista3.Add(Convert.ToString(Description));
                    lista3.Add(Convert.ToString(Manufacturer));
                    lista3.Add(Convert.ToString(NumberOfCores));
                    lista3.Add(Convert.ToString(NumberOfLogicalProcessors));
                    lista3.Add(Convert.ToString(ThreadCount));
                    lista3.Add(Convert.ToString(Status));

                    lista4.Add("Name");
                    lista4.Add("Description");
                    lista4.Add("Manufacturer");
                    lista4.Add("NumberOfCores");
                    lista4.Add("NumberOfLogicalProcessors");
                    lista4.Add("ThreadCount");
                    lista4.Add("Status");
                }

                


                for (int i = 0; i < lista3.Count; i++)
                {
                    lviprocessor = new ListViewItem(new string[] { lista4[i], lista3[i] });
                    mlview_Processor.Items.Add(lviprocessor);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }

        private void Memoria()
        {
            List<string> memoria1 = new List<string>();
            List<string> memoria2 = new List<string>();
            string Description = "";
            string Manufacturer = "";
            string Name = "";
            string Capacity = "";
            string SerialNumber = "";
            string Speed = "";
            string Status = "";
            //string NumberOfLogicalProcessors = "";
            ListViewItem lvimemoria;
            int osszes = 1;
            memoria1.Clear();
            memoria2.Clear();
            try
            {

                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_PhysicalMemory");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Name = Convert.ToString(queryObj["Name"]);
                    Description = Convert.ToString(queryObj["Description"]);
                    Manufacturer = Convert.ToString(queryObj["Manufacturer"]);
                    Speed = Convert.ToString(queryObj["Speed"]);
                    Capacity = Convert.ToString(queryObj["Capacity"]);
                    SerialNumber = Convert.ToString(queryObj["SerialNumber"]);
                    Status = Convert.ToString(queryObj["Status"]);

                    memoria1.Add(Convert.ToString(Name));
                    memoria1.Add(Convert.ToString(Description));
                    memoria1.Add(Convert.ToString(Manufacturer));
                    memoria1.Add(Convert.ToString(Speed));
                    memoria1.Add(Convert.ToString(Capacity));
                    memoria1.Add("###############################");
                    memoria1.Add("");
                    //memoria1.Add(Convert.ToString(Status));

                    memoria2.Add("Name");
                    memoria2.Add("Description");
                    memoria2.Add("Manufacturer");
                    memoria2.Add("Speed");
                    memoria2.Add("Capacity");
                    memoria2.Add("###############################");
                    memoria2.Add("");
                    //memoria2.Add("Status");
                }




                for (int i = 0; i < memoria1.Count; i++)
                {
                    lvimemoria = new ListViewItem(new string[] { memoria2[i], memoria1[i] });
                    mlview_memoria.Items.Add(lvimemoria);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }


        }


        private void NetworkCards()
        {
            List<string> NIC = new List<string>();
            List<string> NIC2 = new List<string>();

            string Name = "";
            string DeviceID = "";
            string DeviceName = "";
            string DriverDate = "";
            string DriverDescription = "";
            string DriverName = "";
            string DriverVersionString = "";

            ListViewItem lvinic;
            int osszes = 0;
            NIC.Clear();
            NIC2.Clear();
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\StandardCimv2",
                    "SELECT * FROM MSFT_NetAdapter");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Name = Convert.ToString(queryObj["Name"]);
                    DeviceID = Convert.ToString(queryObj["DeviceID"]);
                    DeviceName = Convert.ToString(queryObj["DeviceName"]);
                    DriverDate = Convert.ToString(queryObj["DriverDate"]);
                    DriverDescription = Convert.ToString(queryObj["DriverDescription"]);
                    DriverName = Convert.ToString(queryObj["DriverName"]);
                    DriverVersionString = Convert.ToString(queryObj["DriverVersionString"]);

                    NIC.Add(Convert.ToString(Name));
                    NIC.Add(Convert.ToString(DeviceID));
                    NIC.Add(Convert.ToString(DeviceName));
                    NIC.Add(Convert.ToString(DriverDate));
                    NIC.Add(Convert.ToString(DriverDescription));
                    NIC.Add(Convert.ToString(DriverName));
                    NIC.Add(Convert.ToString(DriverVersionString));
                    NIC.Add("###############################");
                    NIC.Add("");

                    NIC2.Add("Name");
                    NIC2.Add("DeviceID");
                    NIC2.Add("DeviceName");
                    NIC2.Add("DriverDate");
                    NIC2.Add("DriverDescription");
                    NIC2.Add("DriverName");
                    NIC2.Add("DriverVersionString");
                    NIC2.Add("###############################");
                    NIC2.Add("");
                }

                for (int i = 0; i < NIC.Count; i++)
                {
                    lvinic = new ListViewItem(new string[] { NIC2[i], NIC[i] });
                    mlv_network.Items.Add(lvinic);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }


        }
    }
}
