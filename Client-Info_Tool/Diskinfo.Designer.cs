
namespace Client_Info_Tool
{
    partial class Diskinfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diskinfo));
            this.mlv_diskinfo = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // mlv_diskinfo
            // 
            this.mlv_diskinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.mlv_diskinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlv_diskinfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlv_diskinfo.FullRowSelect = true;
            this.mlv_diskinfo.Location = new System.Drawing.Point(0, 0);
            this.mlv_diskinfo.Name = "mlv_diskinfo";
            this.mlv_diskinfo.OwnerDraw = true;
            this.mlv_diskinfo.Size = new System.Drawing.Size(907, 605);
            this.mlv_diskinfo.TabIndex = 0;
            this.mlv_diskinfo.UseCompatibleStateImageBehavior = false;
            this.mlv_diskinfo.UseSelectable = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tulajdonságok";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Értékek";
            // 
            // Diskinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 605);
            this.Controls.Add(this.mlv_diskinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Diskinfo";
            this.Text = "Lemez-információk";
            this.Load += new System.EventHandler(this.Diskinfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView mlv_diskinfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}