namespace Client_Info_Tool
{
    partial class HW
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
            this.metroTabControlHW = new MetroFramework.Controls.MetroTabControl();
            this.memoria = new System.Windows.Forms.TabPage();
            this.mlview_memoria = new MetroFramework.Controls.MetroListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alaplap = new MetroFramework.Controls.MetroTabPage();
            this.mlview_Mainboard = new MetroFramework.Controls.MetroListView();
            this.Properties = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Values = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preocessor = new System.Windows.Forms.TabPage();
            this.mlview_Processor = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.merevlemez = new MetroFramework.Controls.MetroTabPage();
            this.mlv_disks = new MetroFramework.Controls.MetroListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hangkartya = new System.Windows.Forms.TabPage();
            this.mlv_sound = new MetroFramework.Controls.MetroListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.videokartya = new System.Windows.Forms.TabPage();
            this.mlv_graphic = new MetroFramework.Controls.MetroListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.halokarty = new System.Windows.Forms.TabPage();
            this.mlv_network = new MetroFramework.Controls.MetroListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.illesztoprogramok = new System.Windows.Forms.TabPage();
            this.metroListView5 = new MetroFramework.Controls.MetroListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kijelzok = new System.Windows.Forms.TabPage();
            this.metroListView6 = new MetroFramework.Controls.MetroListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabControlHW.SuspendLayout();
            this.memoria.SuspendLayout();
            this.alaplap.SuspendLayout();
            this.preocessor.SuspendLayout();
            this.merevlemez.SuspendLayout();
            this.hangkartya.SuspendLayout();
            this.videokartya.SuspendLayout();
            this.halokarty.SuspendLayout();
            this.illesztoprogramok.SuspendLayout();
            this.kijelzok.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControlHW
            // 
            this.metroTabControlHW.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControlHW.Controls.Add(this.memoria);
            this.metroTabControlHW.Controls.Add(this.alaplap);
            this.metroTabControlHW.Controls.Add(this.preocessor);
            this.metroTabControlHW.Controls.Add(this.merevlemez);
            this.metroTabControlHW.Controls.Add(this.hangkartya);
            this.metroTabControlHW.Controls.Add(this.videokartya);
            this.metroTabControlHW.Controls.Add(this.halokarty);
            this.metroTabControlHW.Controls.Add(this.illesztoprogramok);
            this.metroTabControlHW.Controls.Add(this.kijelzok);
            this.metroTabControlHW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControlHW.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControlHW.Location = new System.Drawing.Point(0, 0);
            this.metroTabControlHW.Name = "metroTabControlHW";
            this.metroTabControlHW.SelectedIndex = 6;
            this.metroTabControlHW.Size = new System.Drawing.Size(862, 582);
            this.metroTabControlHW.TabIndex = 0;
            this.metroTabControlHW.UseSelectable = true;
            // 
            // memoria
            // 
            this.memoria.Controls.Add(this.mlview_memoria);
            this.memoria.Location = new System.Drawing.Point(4, 41);
            this.memoria.Name = "memoria";
            this.memoria.Size = new System.Drawing.Size(854, 537);
            this.memoria.TabIndex = 10;
            this.memoria.Text = "Memória";
            // 
            // mlview_memoria
            // 
            this.mlview_memoria.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.mlview_memoria.AllowColumnReorder = true;
            this.mlview_memoria.AllowSorting = true;
            this.mlview_memoria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16});
            this.mlview_memoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.mlview_memoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlview_memoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlview_memoria.FullRowSelect = true;
            this.mlview_memoria.GridLines = true;
            this.mlview_memoria.Location = new System.Drawing.Point(0, 0);
            this.mlview_memoria.Name = "mlview_memoria";
            this.mlview_memoria.OwnerDraw = true;
            this.mlview_memoria.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mlview_memoria.Size = new System.Drawing.Size(854, 537);
            this.mlview_memoria.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mlview_memoria.TabIndex = 5;
            this.mlview_memoria.UseCompatibleStateImageBehavior = false;
            this.mlview_memoria.UseSelectable = true;
            this.mlview_memoria.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Tulajdonságok";
            this.columnHeader15.Width = 282;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Értékek";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader16.Width = 543;
            // 
            // alaplap
            // 
            this.alaplap.Controls.Add(this.mlview_Mainboard);
            this.alaplap.HorizontalScrollbarBarColor = true;
            this.alaplap.HorizontalScrollbarHighlightOnWheel = false;
            this.alaplap.HorizontalScrollbarSize = 10;
            this.alaplap.Location = new System.Drawing.Point(4, 41);
            this.alaplap.Name = "alaplap";
            this.alaplap.Size = new System.Drawing.Size(854, 537);
            this.alaplap.TabIndex = 0;
            this.alaplap.Text = "Alaplap";
            this.alaplap.VerticalScrollbarBarColor = true;
            this.alaplap.VerticalScrollbarHighlightOnWheel = false;
            this.alaplap.VerticalScrollbarSize = 10;
            // 
            // mlview_Mainboard
            // 
            this.mlview_Mainboard.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.mlview_Mainboard.AllowColumnReorder = true;
            this.mlview_Mainboard.AllowSorting = true;
            this.mlview_Mainboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Properties,
            this.Values});
            this.mlview_Mainboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.mlview_Mainboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlview_Mainboard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlview_Mainboard.FullRowSelect = true;
            this.mlview_Mainboard.GridLines = true;
            this.mlview_Mainboard.Location = new System.Drawing.Point(0, 0);
            this.mlview_Mainboard.Name = "mlview_Mainboard";
            this.mlview_Mainboard.OwnerDraw = true;
            this.mlview_Mainboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mlview_Mainboard.Size = new System.Drawing.Size(854, 537);
            this.mlview_Mainboard.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mlview_Mainboard.TabIndex = 3;
            this.mlview_Mainboard.UseCompatibleStateImageBehavior = false;
            this.mlview_Mainboard.UseSelectable = true;
            this.mlview_Mainboard.View = System.Windows.Forms.View.Details;
            // 
            // Properties
            // 
            this.Properties.Text = "Tulajdonságok";
            this.Properties.Width = 282;
            // 
            // Values
            // 
            this.Values.Text = "Értékek";
            this.Values.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Values.Width = 543;
            // 
            // preocessor
            // 
            this.preocessor.Controls.Add(this.mlview_Processor);
            this.preocessor.Location = new System.Drawing.Point(4, 41);
            this.preocessor.Name = "preocessor";
            this.preocessor.Size = new System.Drawing.Size(854, 537);
            this.preocessor.TabIndex = 9;
            this.preocessor.Text = "Processzor";
            // 
            // mlview_Processor
            // 
            this.mlview_Processor.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.mlview_Processor.AllowColumnReorder = true;
            this.mlview_Processor.AllowSorting = true;
            this.mlview_Processor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.mlview_Processor.Cursor = System.Windows.Forms.Cursors.Default;
            this.mlview_Processor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlview_Processor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlview_Processor.FullRowSelect = true;
            this.mlview_Processor.GridLines = true;
            this.mlview_Processor.Location = new System.Drawing.Point(0, 0);
            this.mlview_Processor.Name = "mlview_Processor";
            this.mlview_Processor.OwnerDraw = true;
            this.mlview_Processor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mlview_Processor.Size = new System.Drawing.Size(854, 537);
            this.mlview_Processor.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mlview_Processor.TabIndex = 4;
            this.mlview_Processor.UseCompatibleStateImageBehavior = false;
            this.mlview_Processor.UseSelectable = true;
            this.mlview_Processor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tulajdonságok";
            this.columnHeader1.Width = 282;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Értékek";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 543;
            // 
            // merevlemez
            // 
            this.merevlemez.Controls.Add(this.mlv_disks);
            this.merevlemez.HorizontalScrollbarBarColor = true;
            this.merevlemez.HorizontalScrollbarHighlightOnWheel = false;
            this.merevlemez.HorizontalScrollbarSize = 10;
            this.merevlemez.Location = new System.Drawing.Point(4, 41);
            this.merevlemez.Name = "merevlemez";
            this.merevlemez.Size = new System.Drawing.Size(854, 537);
            this.merevlemez.TabIndex = 3;
            this.merevlemez.Text = "Merevlemez";
            this.merevlemez.VerticalScrollbarBarColor = true;
            this.merevlemez.VerticalScrollbarHighlightOnWheel = false;
            this.merevlemez.VerticalScrollbarSize = 10;
            // 
            // mlv_disks
            // 
            this.mlv_disks.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.mlv_disks.AllowColumnReorder = true;
            this.mlv_disks.AllowSorting = true;
            this.mlv_disks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.mlv_disks.Cursor = System.Windows.Forms.Cursors.Default;
            this.mlv_disks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlv_disks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlv_disks.FullRowSelect = true;
            this.mlv_disks.GridLines = true;
            this.mlv_disks.Location = new System.Drawing.Point(0, 0);
            this.mlv_disks.Name = "mlv_disks";
            this.mlv_disks.OwnerDraw = true;
            this.mlv_disks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mlv_disks.Size = new System.Drawing.Size(854, 537);
            this.mlv_disks.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mlv_disks.TabIndex = 5;
            this.mlv_disks.UseCompatibleStateImageBehavior = false;
            this.mlv_disks.UseSelectable = true;
            this.mlv_disks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tulajdonságok";
            this.columnHeader3.Width = 282;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Értékek";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 543;
            // 
            // hangkartya
            // 
            this.hangkartya.Controls.Add(this.mlv_sound);
            this.hangkartya.Location = new System.Drawing.Point(4, 41);
            this.hangkartya.Name = "hangkartya";
            this.hangkartya.Size = new System.Drawing.Size(854, 537);
            this.hangkartya.TabIndex = 4;
            this.hangkartya.Text = "Hangkártya";
            // 
            // mlv_sound
            // 
            this.mlv_sound.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.mlv_sound.AllowColumnReorder = true;
            this.mlv_sound.AllowSorting = true;
            this.mlv_sound.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.mlv_sound.Cursor = System.Windows.Forms.Cursors.Default;
            this.mlv_sound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlv_sound.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlv_sound.FullRowSelect = true;
            this.mlv_sound.GridLines = true;
            this.mlv_sound.Location = new System.Drawing.Point(0, 0);
            this.mlv_sound.Name = "mlv_sound";
            this.mlv_sound.OwnerDraw = true;
            this.mlv_sound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mlv_sound.Size = new System.Drawing.Size(854, 537);
            this.mlv_sound.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mlv_sound.TabIndex = 5;
            this.mlv_sound.UseCompatibleStateImageBehavior = false;
            this.mlv_sound.UseSelectable = true;
            this.mlv_sound.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tulajdonságok";
            this.columnHeader5.Width = 282;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Értékek";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 543;
            // 
            // videokartya
            // 
            this.videokartya.Controls.Add(this.mlv_graphic);
            this.videokartya.Location = new System.Drawing.Point(4, 41);
            this.videokartya.Name = "videokartya";
            this.videokartya.Size = new System.Drawing.Size(854, 537);
            this.videokartya.TabIndex = 5;
            this.videokartya.Text = "Videókártya";
            // 
            // mlv_graphic
            // 
            this.mlv_graphic.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.mlv_graphic.AllowColumnReorder = true;
            this.mlv_graphic.AllowSorting = true;
            this.mlv_graphic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.mlv_graphic.Cursor = System.Windows.Forms.Cursors.Default;
            this.mlv_graphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlv_graphic.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlv_graphic.FullRowSelect = true;
            this.mlv_graphic.GridLines = true;
            this.mlv_graphic.Location = new System.Drawing.Point(0, 0);
            this.mlv_graphic.Name = "mlv_graphic";
            this.mlv_graphic.OwnerDraw = true;
            this.mlv_graphic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mlv_graphic.Size = new System.Drawing.Size(854, 537);
            this.mlv_graphic.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mlv_graphic.TabIndex = 5;
            this.mlv_graphic.UseCompatibleStateImageBehavior = false;
            this.mlv_graphic.UseSelectable = true;
            this.mlv_graphic.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tulajdonságok";
            this.columnHeader7.Width = 282;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Értékek";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 543;
            // 
            // halokarty
            // 
            this.halokarty.Controls.Add(this.mlv_network);
            this.halokarty.Location = new System.Drawing.Point(4, 41);
            this.halokarty.Name = "halokarty";
            this.halokarty.Size = new System.Drawing.Size(854, 537);
            this.halokarty.TabIndex = 7;
            this.halokarty.Text = "Hálózti kártyák";
            // 
            // mlv_network
            // 
            this.mlv_network.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.mlv_network.AllowColumnReorder = true;
            this.mlv_network.AllowSorting = true;
            this.mlv_network.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.mlv_network.Cursor = System.Windows.Forms.Cursors.Default;
            this.mlv_network.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlv_network.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlv_network.FullRowSelect = true;
            this.mlv_network.GridLines = true;
            this.mlv_network.Location = new System.Drawing.Point(0, 0);
            this.mlv_network.Name = "mlv_network";
            this.mlv_network.OwnerDraw = true;
            this.mlv_network.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mlv_network.Size = new System.Drawing.Size(854, 537);
            this.mlv_network.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mlv_network.TabIndex = 5;
            this.mlv_network.UseCompatibleStateImageBehavior = false;
            this.mlv_network.UseSelectable = true;
            this.mlv_network.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tulajdonságok";
            this.columnHeader9.Width = 282;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Értékek";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 543;
            // 
            // illesztoprogramok
            // 
            this.illesztoprogramok.Controls.Add(this.metroListView5);
            this.illesztoprogramok.Location = new System.Drawing.Point(4, 41);
            this.illesztoprogramok.Name = "illesztoprogramok";
            this.illesztoprogramok.Size = new System.Drawing.Size(1285, 828);
            this.illesztoprogramok.TabIndex = 6;
            this.illesztoprogramok.Text = "Illesztőprogramok";
            // 
            // metroListView5
            // 
            this.metroListView5.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.metroListView5.AllowColumnReorder = true;
            this.metroListView5.AllowSorting = true;
            this.metroListView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.metroListView5.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroListView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroListView5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView5.FullRowSelect = true;
            this.metroListView5.GridLines = true;
            this.metroListView5.Location = new System.Drawing.Point(0, 0);
            this.metroListView5.Name = "metroListView5";
            this.metroListView5.OwnerDraw = true;
            this.metroListView5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroListView5.Size = new System.Drawing.Size(1285, 828);
            this.metroListView5.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.metroListView5.TabIndex = 5;
            this.metroListView5.UseCompatibleStateImageBehavior = false;
            this.metroListView5.UseSelectable = true;
            this.metroListView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tulajdonságok";
            this.columnHeader11.Width = 282;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Értékek";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader12.Width = 543;
            // 
            // kijelzok
            // 
            this.kijelzok.Controls.Add(this.metroListView6);
            this.kijelzok.Location = new System.Drawing.Point(4, 41);
            this.kijelzok.Name = "kijelzok";
            this.kijelzok.Size = new System.Drawing.Size(1285, 828);
            this.kijelzok.TabIndex = 8;
            this.kijelzok.Text = "Kijelzők";
            // 
            // metroListView6
            // 
            this.metroListView6.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.metroListView6.AllowColumnReorder = true;
            this.metroListView6.AllowSorting = true;
            this.metroListView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14});
            this.metroListView6.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroListView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroListView6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView6.FullRowSelect = true;
            this.metroListView6.GridLines = true;
            this.metroListView6.Location = new System.Drawing.Point(0, 0);
            this.metroListView6.Name = "metroListView6";
            this.metroListView6.OwnerDraw = true;
            this.metroListView6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroListView6.Size = new System.Drawing.Size(1285, 828);
            this.metroListView6.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.metroListView6.TabIndex = 5;
            this.metroListView6.UseCompatibleStateImageBehavior = false;
            this.metroListView6.UseSelectable = true;
            this.metroListView6.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Tulajdonságok";
            this.columnHeader13.Width = 282;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Értékek";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader14.Width = 543;
            // 
            // HW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControlHW);
            this.Name = "HW";
            this.Size = new System.Drawing.Size(862, 582);
            this.Load += new System.EventHandler(this.HW_Load);
            this.metroTabControlHW.ResumeLayout(false);
            this.memoria.ResumeLayout(false);
            this.alaplap.ResumeLayout(false);
            this.preocessor.ResumeLayout(false);
            this.merevlemez.ResumeLayout(false);
            this.hangkartya.ResumeLayout(false);
            this.videokartya.ResumeLayout(false);
            this.halokarty.ResumeLayout(false);
            this.illesztoprogramok.ResumeLayout(false);
            this.kijelzok.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControlHW;
        private MetroFramework.Controls.MetroTabPage alaplap;
        private MetroFramework.Controls.MetroTabPage merevlemez;
        private System.Windows.Forms.TabPage hangkartya;
        private System.Windows.Forms.TabPage videokartya;
        private System.Windows.Forms.TabPage halokarty;
        private System.Windows.Forms.TabPage illesztoprogramok;
        private System.Windows.Forms.TabPage kijelzok;
        private MetroFramework.Controls.MetroListView mlview_Mainboard;
        public System.Windows.Forms.ColumnHeader Properties;
        public System.Windows.Forms.ColumnHeader Values;
        private System.Windows.Forms.TabPage preocessor;
        private MetroFramework.Controls.MetroListView mlview_Processor;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage memoria;
        private MetroFramework.Controls.MetroListView mlview_memoria;
        public System.Windows.Forms.ColumnHeader columnHeader15;
        public System.Windows.Forms.ColumnHeader columnHeader16;
        private MetroFramework.Controls.MetroListView mlv_disks;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroListView mlv_sound;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroListView mlv_graphic;
        public System.Windows.Forms.ColumnHeader columnHeader7;
        public System.Windows.Forms.ColumnHeader columnHeader8;
        private MetroFramework.Controls.MetroListView mlv_network;
        public System.Windows.Forms.ColumnHeader columnHeader9;
        public System.Windows.Forms.ColumnHeader columnHeader10;
        private MetroFramework.Controls.MetroListView metroListView5;
        public System.Windows.Forms.ColumnHeader columnHeader11;
        public System.Windows.Forms.ColumnHeader columnHeader12;
        private MetroFramework.Controls.MetroListView metroListView6;
        public System.Windows.Forms.ColumnHeader columnHeader13;
        public System.Windows.Forms.ColumnHeader columnHeader14;
    }
}
