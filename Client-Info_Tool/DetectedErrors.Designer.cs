
namespace Client_Info_Tool
{
    partial class DetectedErrors
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
            this.mtb = new MetroFramework.Controls.MetroTabControl();
            this.mtp_sys = new MetroFramework.Controls.MetroTabPage();
            this.mlv_system = new MetroFramework.Controls.MetroListView();
            this.c_forr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_datumido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_esemeny = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtp_app = new System.Windows.Forms.TabPage();
            this.mlv_app = new MetroFramework.Controls.MetroListView();
            this.c_forrasapp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_datumidoapp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_esemenyapp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_uzenetapp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtb.SuspendLayout();
            this.mtp_sys.SuspendLayout();
            this.mtp_app.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtb
            // 
            this.mtb.Controls.Add(this.mtp_sys);
            this.mtb.Controls.Add(this.mtp_app);
            this.mtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtb.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.mtb.Location = new System.Drawing.Point(0, 0);
            this.mtb.Name = "mtb";
            this.mtb.SelectedIndex = 0;
            this.mtb.Size = new System.Drawing.Size(1063, 768);
            this.mtb.TabIndex = 0;
            this.mtb.UseSelectable = true;
            // 
            // mtp_sys
            // 
            this.mtp_sys.Controls.Add(this.mlv_system);
            this.mtp_sys.HorizontalScrollbarBarColor = true;
            this.mtp_sys.HorizontalScrollbarHighlightOnWheel = false;
            this.mtp_sys.HorizontalScrollbarSize = 10;
            this.mtp_sys.Location = new System.Drawing.Point(4, 38);
            this.mtp_sys.Name = "mtp_sys";
            this.mtp_sys.Size = new System.Drawing.Size(1055, 726);
            this.mtp_sys.TabIndex = 0;
            this.mtp_sys.Text = "System";
            this.mtp_sys.VerticalScrollbarBarColor = true;
            this.mtp_sys.VerticalScrollbarHighlightOnWheel = false;
            this.mtp_sys.VerticalScrollbarSize = 10;
            // 
            // mlv_system
            // 
            this.mlv_system.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_forr,
            this.c_datumido,
            this.c_esemeny,
            this.c_message});
            this.mlv_system.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlv_system.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlv_system.FullRowSelect = true;
            this.mlv_system.Location = new System.Drawing.Point(0, 0);
            this.mlv_system.Name = "mlv_system";
            this.mlv_system.OwnerDraw = true;
            this.mlv_system.Size = new System.Drawing.Size(1055, 726);
            this.mlv_system.TabIndex = 2;
            this.mlv_system.UseCompatibleStateImageBehavior = false;
            this.mlv_system.UseSelectable = true;
            // 
            // c_forr
            // 
            this.c_forr.Text = "Forrás";
            // 
            // c_datumido
            // 
            this.c_datumido.Text = "Dátum és idő";
            // 
            // c_esemeny
            // 
            this.c_esemeny.Text = "Eseményazonosító";
            // 
            // c_message
            // 
            this.c_message.Text = "Üzenet";
            // 
            // mtp_app
            // 
            this.mtp_app.Controls.Add(this.mlv_app);
            this.mtp_app.Location = new System.Drawing.Point(4, 38);
            this.mtp_app.Name = "mtp_app";
            this.mtp_app.Size = new System.Drawing.Size(2349, 1665);
            this.mtp_app.TabIndex = 1;
            this.mtp_app.Text = "Alkalmazás";
            // 
            // mlv_app
            // 
            this.mlv_app.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_forrasapp,
            this.c_datumidoapp,
            this.c_esemenyapp,
            this.c_uzenetapp});
            this.mlv_app.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlv_app.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlv_app.FullRowSelect = true;
            this.mlv_app.Location = new System.Drawing.Point(0, 0);
            this.mlv_app.Name = "mlv_app";
            this.mlv_app.OwnerDraw = true;
            this.mlv_app.Size = new System.Drawing.Size(3524, 2498);
            this.mlv_app.TabIndex = 3;
            this.mlv_app.UseCompatibleStateImageBehavior = false;
            this.mlv_app.UseSelectable = true;
            // 
            // c_forrasapp
            // 
            this.c_forrasapp.Text = "Forrás";
            // 
            // c_datumidoapp
            // 
            this.c_datumidoapp.Text = "Dátum és idő";
            // 
            // c_esemenyapp
            // 
            this.c_esemenyapp.Text = "Eseményazonosító";
            // 
            // c_uzenetapp
            // 
            this.c_uzenetapp.Text = "Üzenet";
            // 
            // DetectedErrors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtb);
            this.Name = "DetectedErrors";
            this.Size = new System.Drawing.Size(1063, 768);
            this.Load += new System.EventHandler(this.DetectedErrors_Load);
            this.mtb.ResumeLayout(false);
            this.mtp_sys.ResumeLayout(false);
            this.mtp_app.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtb;
        private MetroFramework.Controls.MetroTabPage mtp_sys;
        private System.Windows.Forms.TabPage mtp_app;
        private MetroFramework.Controls.MetroListView mlv_system;
        private System.Windows.Forms.ColumnHeader c_forr;
        private System.Windows.Forms.ColumnHeader c_datumido;
        private System.Windows.Forms.ColumnHeader c_esemeny;
        private System.Windows.Forms.ColumnHeader c_message;
        private MetroFramework.Controls.MetroListView mlv_app;
        private System.Windows.Forms.ColumnHeader c_forrasapp;
        private System.Windows.Forms.ColumnHeader c_datumidoapp;
        private System.Windows.Forms.ColumnHeader c_esemenyapp;
        private System.Windows.Forms.ColumnHeader c_uzenetapp;
    }
}
