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
using System.Diagnostics.Eventing.Reader;

namespace Client_Info_Tool
{
    public partial class DetectedErrors : UserControl
    {
        public DetectedErrors()
        {
            InitializeComponent();
        }

        private void DetectedErrors_Load(object sender, EventArgs e)
        {
            mlv_system.BeginUpdate();
            mlv_system.Items.Clear();
            mlv_system.View = View.Details;
            GetEventLogSys();
            mlv_system.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            mlv_system.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            mlv_system.EndUpdate();
            mlv_system.AllowSorting = true;


            mlv_app.BeginUpdate();
            mlv_app.Items.Clear();
            mlv_app.View = View.Details;
            GetEventLogApp();
            mlv_app.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            mlv_app.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            mlv_app.EndUpdate();
            mlv_app.AllowSorting = true;

        }

        private void GetEventLogSys()
        {
            EventLog myLog = new EventLog();

            myLog.Log = "System";
            foreach (EventLogEntry entry in myLog.Entries)

            {
                ListViewItem sys;
                
                if (entry.EntryType.ToString() == "Error")
                {
                    sys = new ListViewItem(new string[] { Convert.ToString(entry.Source), Convert.ToString(entry.TimeGenerated), Convert.ToString(entry.InstanceId), Convert.ToString(entry.Message) });
                    Console.WriteLine(sys);
                    mlv_system.Items.Add(sys);


                }


            }
        }


        private void GetEventLogApp()
        {
            EventLog myLog = new EventLog();
            myLog.Log = "Application";
            foreach (EventLogEntry entry in myLog.Entries)

            {
                ListViewItem app;

                if (entry.EntryType.ToString() == "Error")
                {
                    app = new ListViewItem(new string[] { Convert.ToString(entry.Source), Convert.ToString(entry.TimeGenerated), Convert.ToString(entry.InstanceId), Convert.ToString(entry.Message) });
                    mlv_system.Items.Add(app);
                }
            }
        }
    }
}
