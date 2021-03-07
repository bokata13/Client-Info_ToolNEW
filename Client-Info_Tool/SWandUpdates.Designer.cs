namespace Client_Info_Tool
{
    partial class SWandUpdates
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mt_installedSW = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.DisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DisplayVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InstallDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroListView2 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mt_installedSW.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mt_installedSW
            // 
            this.mt_installedSW.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mt_installedSW.Controls.Add(this.metroTabPage1);
            this.mt_installedSW.Controls.Add(this.metroTabPage2);
            this.mt_installedSW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mt_installedSW.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.mt_installedSW.HotTrack = true;
            this.mt_installedSW.Location = new System.Drawing.Point(0, 0);
            this.mt_installedSW.Name = "mt_installedSW";
            this.mt_installedSW.SelectedIndex = 0;
            this.mt_installedSW.Size = new System.Drawing.Size(880, 599);
            this.mt_installedSW.TabIndex = 0;
            this.mt_installedSW.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroTabPage1.Controls.Add(this.metroListView1);
            this.metroTabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroTabPage1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(872, 554);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Telepített szoftverek";
            this.metroTabPage1.UseVisualStyleBackColor = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroListView1
            // 
            this.metroListView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.metroListView1.AllowSorting = true;
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DisplayName,
            this.DisplayVersion,
            this.Publisher,
            this.InstallDate});
            this.metroListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.GridLines = true;
            this.metroListView1.Location = new System.Drawing.Point(0, 0);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroListView1.Size = new System.Drawing.Size(868, 550);
            this.metroListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // DisplayName
            // 
            this.DisplayName.Text = "Név";
            this.DisplayName.Width = 10;
            // 
            // DisplayVersion
            // 
            this.DisplayVersion.Text = "Verzió";
            this.DisplayVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DisplayVersion.Width = 10;
            // 
            // Publisher
            // 
            this.Publisher.Text = "Gyártó";
            this.Publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Publisher.Width = 10;
            // 
            // InstallDate
            // 
            this.InstallDate.Text = "Installálás dátuma";
            this.InstallDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InstallDate.Width = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroTabPage2.Controls.Add(this.metroListView2);
            this.metroTabPage2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.metroTabPage2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(872, 554);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Telepített update-ek";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroListView2
            // 
            this.metroListView2.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.metroListView2.AllowSorting = true;
            this.metroListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.metroListView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroListView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroListView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView2.FullRowSelect = true;
            this.metroListView2.GridLines = true;
            this.metroListView2.Location = new System.Drawing.Point(0, 0);
            this.metroListView2.Name = "metroListView2";
            this.metroListView2.OwnerDraw = true;
            this.metroListView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroListView2.Size = new System.Drawing.Size(868, 550);
            this.metroListView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.metroListView2.TabIndex = 3;
            this.metroListView2.UseCompatibleStateImageBehavior = false;
            this.metroListView2.UseSelectable = true;
            this.metroListView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "HotfixID";
            this.columnHeader1.Width = 10;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Leírás";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 355;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Link";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 10;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Installálás dátuma";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 10;
            // 
            // SWandUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mt_installedSW);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "SWandUpdates";
            this.Size = new System.Drawing.Size(880, 599);
            this.Load += new System.EventHandler(this.SWandUpdates_Load);
            this.mt_installedSW.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader DisplayName;
        private System.Windows.Forms.ColumnHeader DisplayVersion;
        private System.Windows.Forms.ColumnHeader Publisher;
        private System.Windows.Forms.ColumnHeader InstallDate;
        public MetroFramework.Controls.MetroTabControl mt_installedSW;
        private MetroFramework.Controls.MetroListView metroListView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public MetroFramework.Controls.MetroTabPage metroTabPage1;
        public MetroFramework.Controls.MetroTabPage metroTabPage2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
