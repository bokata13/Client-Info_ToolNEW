namespace Client_Info_Tool
{
    partial class ClientInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_hd = new System.Windows.Forms.Button();
            this.bt_wintools = new System.Windows.Forms.Button();
            this.bt_failure = new System.Windows.Forms.Button();
            this.bt_hwinf = new System.Windows.Forms.Button();
            this.bt_installeswupd = new System.Windows.Forms.Button();
            this.bt_alapvetoinfo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startBuiltInApps1 = new Client_Info_Tool.StartBuiltInApps();
            this.detectedErrors1 = new Client_Info_Tool.DetectedErrors();
            this.hw1 = new Client_Info_Tool.HW();
            this.sWandUpdates1 = new Client_Info_Tool.SWandUpdates();
            this.basicInformation1 = new Client_Info_Tool.BasicInformation();
            this.contactHD1 = new Client_Info_Tool.ContactHD();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 969);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_hd);
            this.panel3.Controls.Add(this.bt_wintools);
            this.panel3.Controls.Add(this.bt_failure);
            this.panel3.Controls.Add(this.bt_hwinf);
            this.panel3.Controls.Add(this.bt_installeswupd);
            this.panel3.Controls.Add(this.bt_alapvetoinfo);
            this.panel3.Location = new System.Drawing.Point(0, 266);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 502);
            this.panel3.TabIndex = 6;
            // 
            // bt_hd
            // 
            this.bt_hd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(159)))), ((int)(((byte)(191)))));
            this.bt_hd.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_hd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_hd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_hd.ForeColor = System.Drawing.Color.White;
            this.bt_hd.Location = new System.Drawing.Point(0, 415);
            this.bt_hd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_hd.Name = "bt_hd";
            this.bt_hd.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bt_hd.Size = new System.Drawing.Size(300, 83);
            this.bt_hd.TabIndex = 5;
            this.bt_hd.Text = "Helpdesk kontaktálása";
            this.bt_hd.UseVisualStyleBackColor = false;
            this.bt_hd.Click += new System.EventHandler(this.bt_hd_Click);
            // 
            // bt_wintools
            // 
            this.bt_wintools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(159)))), ((int)(((byte)(191)))));
            this.bt_wintools.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_wintools.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_wintools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_wintools.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_wintools.ForeColor = System.Drawing.Color.White;
            this.bt_wintools.Location = new System.Drawing.Point(0, 332);
            this.bt_wintools.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_wintools.Name = "bt_wintools";
            this.bt_wintools.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bt_wintools.Size = new System.Drawing.Size(300, 83);
            this.bt_wintools.TabIndex = 4;
            this.bt_wintools.Text = "Toolok indítása (Windows)";
            this.bt_wintools.UseVisualStyleBackColor = false;
            this.bt_wintools.Click += new System.EventHandler(this.bt_wintools_Click);
            // 
            // bt_failure
            // 
            this.bt_failure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(159)))), ((int)(((byte)(191)))));
            this.bt_failure.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_failure.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_failure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_failure.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_failure.ForeColor = System.Drawing.Color.White;
            this.bt_failure.Location = new System.Drawing.Point(0, 249);
            this.bt_failure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_failure.Name = "bt_failure";
            this.bt_failure.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bt_failure.Size = new System.Drawing.Size(300, 83);
            this.bt_failure.TabIndex = 3;
            this.bt_failure.Text = "Észlelt hibák";
            this.bt_failure.UseVisualStyleBackColor = false;
            this.bt_failure.Click += new System.EventHandler(this.bt_failure_Click);
            // 
            // bt_hwinf
            // 
            this.bt_hwinf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(159)))), ((int)(((byte)(191)))));
            this.bt_hwinf.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_hwinf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_hwinf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hwinf.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_hwinf.ForeColor = System.Drawing.Color.White;
            this.bt_hwinf.Location = new System.Drawing.Point(0, 166);
            this.bt_hwinf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_hwinf.Name = "bt_hwinf";
            this.bt_hwinf.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bt_hwinf.Size = new System.Drawing.Size(300, 83);
            this.bt_hwinf.TabIndex = 2;
            this.bt_hwinf.Text = "Hardver információk";
            this.bt_hwinf.UseVisualStyleBackColor = false;
            this.bt_hwinf.Click += new System.EventHandler(this.bt_hwinf_Click);
            // 
            // bt_installeswupd
            // 
            this.bt_installeswupd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(159)))), ((int)(((byte)(191)))));
            this.bt_installeswupd.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_installeswupd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_installeswupd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_installeswupd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_installeswupd.ForeColor = System.Drawing.Color.White;
            this.bt_installeswupd.Location = new System.Drawing.Point(0, 83);
            this.bt_installeswupd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_installeswupd.Name = "bt_installeswupd";
            this.bt_installeswupd.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bt_installeswupd.Size = new System.Drawing.Size(300, 83);
            this.bt_installeswupd.TabIndex = 1;
            this.bt_installeswupd.Text = "Telepített szoftverek és updatek";
            this.bt_installeswupd.UseVisualStyleBackColor = false;
            this.bt_installeswupd.Click += new System.EventHandler(this.bt_installeswupd_Click);
            // 
            // bt_alapvetoinfo
            // 
            this.bt_alapvetoinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(159)))), ((int)(((byte)(191)))));
            this.bt_alapvetoinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_alapvetoinfo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_alapvetoinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alapvetoinfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_alapvetoinfo.ForeColor = System.Drawing.Color.White;
            this.bt_alapvetoinfo.Location = new System.Drawing.Point(0, 0);
            this.bt_alapvetoinfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_alapvetoinfo.Name = "bt_alapvetoinfo";
            this.bt_alapvetoinfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bt_alapvetoinfo.Size = new System.Drawing.Size(300, 83);
            this.bt_alapvetoinfo.TabIndex = 7;
            this.bt_alapvetoinfo.Text = "Alapvető információk";
            this.bt_alapvetoinfo.UseVisualStyleBackColor = false;
            this.bt_alapvetoinfo.Click += new System.EventHandler(this.bt_alapvetoinfo_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(298, 870);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1298, 99);
            this.panel4.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1272, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = " Bojtésoft - Phone: +3612345678  - Email: bojtesoft@gmail.com";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startBuiltInApps1
            // 
            this.startBuiltInApps1.BackColor = System.Drawing.SystemColors.Window;
            this.startBuiltInApps1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.startBuiltInApps1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBuiltInApps1.Location = new System.Drawing.Point(298, 0);
            this.startBuiltInApps1.Name = "startBuiltInApps1";
            this.startBuiltInApps1.Size = new System.Drawing.Size(1298, 870);
            this.startBuiltInApps1.TabIndex = 6;
            // 
            // detectedErrors1
            // 
            this.detectedErrors1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detectedErrors1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detectedErrors1.Location = new System.Drawing.Point(298, 0);
            this.detectedErrors1.Name = "detectedErrors1";
            this.detectedErrors1.Size = new System.Drawing.Size(1298, 870);
            this.detectedErrors1.TabIndex = 5;
            // 
            // hw1
            // 
            this.hw1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hw1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hw1.Location = new System.Drawing.Point(298, 0);
            this.hw1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.hw1.Name = "hw1";
            this.hw1.Size = new System.Drawing.Size(1298, 870);
            this.hw1.TabIndex = 4;
            // 
            // sWandUpdates1
            // 
            this.sWandUpdates1.BackColor = System.Drawing.SystemColors.Control;
            this.sWandUpdates1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sWandUpdates1.Cursor = System.Windows.Forms.Cursors.Default;
            this.sWandUpdates1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sWandUpdates1.Location = new System.Drawing.Point(298, 0);
            this.sWandUpdates1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.sWandUpdates1.Name = "sWandUpdates1";
            this.sWandUpdates1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sWandUpdates1.Size = new System.Drawing.Size(1298, 870);
            this.sWandUpdates1.TabIndex = 3;
            // 
            // basicInformation1
            // 
            this.basicInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicInformation1.Location = new System.Drawing.Point(298, 0);
            this.basicInformation1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.basicInformation1.Name = "basicInformation1";
            this.basicInformation1.Size = new System.Drawing.Size(1298, 870);
            this.basicInformation1.TabIndex = 2;
            // 
            // contactHD1
            // 
            this.contactHD1.AllowDrop = true;
            this.contactHD1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contactHD1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactHD1.ForeColor = System.Drawing.SystemColors.Control;
            this.contactHD1.Location = new System.Drawing.Point(298, 0);
            this.contactHD1.Name = "contactHD1";
            this.contactHD1.Size = new System.Drawing.Size(1298, 870);
            this.contactHD1.TabIndex = 7;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1596, 969);
            this.Controls.Add(this.contactHD1);
            this.Controls.Add(this.startBuiltInApps1);
            this.Controls.Add(this.detectedErrors1);
            this.Controls.Add(this.hw1);
            this.Controls.Add(this.sWandUpdates1);
            this.Controls.Add(this.basicInformation1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1618, 1025);
            this.MinimumSize = new System.Drawing.Size(1618, 1025);
            this.Name = "ClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client-Info Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientInfo_FormClosed);
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private BasicInformation basicInformation1;
        private SWandUpdates sWandUpdates1;
        private System.Windows.Forms.Button bt_alapvetoinfo;
        private System.Windows.Forms.Button bt_installeswupd;
        private System.Windows.Forms.Button bt_hd;
        private System.Windows.Forms.Button bt_wintools;
        private System.Windows.Forms.Button bt_failure;
        private System.Windows.Forms.Button bt_hwinf;
        private HW hw1;
        private DetectedErrors detectedErrors1;
        private StartBuiltInApps startBuiltInApps1;
        private ContactHD contactHD1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

