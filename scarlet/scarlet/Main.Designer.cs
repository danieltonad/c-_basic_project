namespace scarlet
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.settingIcon = new System.Windows.Forms.PictureBox();
            this.link = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Panel();
            this.settingIconOff = new System.Windows.Forms.PictureBox();
            this.auto_scan_browse_links = new System.Windows.Forms.CheckBox();
            this.save_scanned_links = new System.Windows.Forms.CheckBox();
            this.auto_complete_links = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.link_err = new System.Windows.Forms.Label();
            this.settings_cover = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scan__ = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingIconOff)).BeginInit();
            this.settings_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 21);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(19)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "s c a r l e t";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(892, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(34)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(914, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // settingIcon
            // 
            this.settingIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingIcon.Image = ((System.Drawing.Image)(resources.GetObject("settingIcon.Image")));
            this.settingIcon.Location = new System.Drawing.Point(905, 416);
            this.settingIcon.Name = "settingIcon";
            this.settingIcon.Size = new System.Drawing.Size(31, 31);
            this.settingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingIcon.TabIndex = 1;
            this.settingIcon.TabStop = false;
            this.settingIcon.Click += new System.EventHandler(this.settingIcon_Click);
            // 
            // link
            // 
            this.link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(95)))), ((int)(((byte)(93)))));
            this.link.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.link.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.link.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.link.Location = new System.Drawing.Point(14, 14);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(429, 20);
            this.link.TabIndex = 2;
            this.link.KeyUp += new System.Windows.Forms.KeyEventHandler(this.link_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(19)))));
            this.label1.Location = new System.Drawing.Point(303, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detect Phising Link";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(95)))), ((int)(((byte)(93)))));
            this.panel2.Controls.Add(this.link);
            this.panel2.Location = new System.Drawing.Point(304, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 52);
            this.panel2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(753, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 52);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.scan_link);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.settings.Controls.Add(this.settingIconOff);
            this.settings.Controls.Add(this.auto_scan_browse_links);
            this.settings.Controls.Add(this.save_scanned_links);
            this.settings.Controls.Add(this.auto_complete_links);
            this.settings.Controls.Add(this.panel4);
            this.settings.Controls.Add(this.label6);
            this.settings.Dock = System.Windows.Forms.DockStyle.Left;
            this.settings.Location = new System.Drawing.Point(0, 21);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(36, 426);
            this.settings.TabIndex = 6;
            // 
            // settingIconOff
            // 
            this.settingIconOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingIconOff.Image = ((System.Drawing.Image)(resources.GetObject("settingIconOff.Image")));
            this.settingIconOff.Location = new System.Drawing.Point(3, 392);
            this.settingIconOff.Name = "settingIconOff";
            this.settingIconOff.Size = new System.Drawing.Size(31, 31);
            this.settingIconOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingIconOff.TabIndex = 8;
            this.settingIconOff.TabStop = false;
            this.settingIconOff.Click += new System.EventHandler(this.settingIconOff_Click);
            // 
            // auto_scan_browse_links
            // 
            this.auto_scan_browse_links.AutoSize = true;
            this.auto_scan_browse_links.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.auto_scan_browse_links.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(137)))), ((int)(((byte)(141)))));
            this.auto_scan_browse_links.Location = new System.Drawing.Point(31, 157);
            this.auto_scan_browse_links.Name = "auto_scan_browse_links";
            this.auto_scan_browse_links.Size = new System.Drawing.Size(293, 25);
            this.auto_scan_browse_links.TabIndex = 7;
            this.auto_scan_browse_links.Text = "Auto scan visited links on browsers";
            this.auto_scan_browse_links.UseVisualStyleBackColor = true;
            // 
            // save_scanned_links
            // 
            this.save_scanned_links.AutoSize = true;
            this.save_scanned_links.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.save_scanned_links.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(137)))), ((int)(((byte)(141)))));
            this.save_scanned_links.Location = new System.Drawing.Point(31, 119);
            this.save_scanned_links.Name = "save_scanned_links";
            this.save_scanned_links.Size = new System.Drawing.Size(174, 25);
            this.save_scanned_links.TabIndex = 6;
            this.save_scanned_links.Text = "Save scanned links";
            this.save_scanned_links.UseVisualStyleBackColor = true;
            // 
            // auto_complete_links
            // 
            this.auto_complete_links.AutoSize = true;
            this.auto_complete_links.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.auto_complete_links.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(137)))), ((int)(((byte)(141)))));
            this.auto_complete_links.Location = new System.Drawing.Point(31, 81);
            this.auto_complete_links.Name = "auto_complete_links";
            this.auto_complete_links.Size = new System.Drawing.Size(183, 25);
            this.auto_complete_links.TabIndex = 5;
            this.auto_complete_links.Text = "Auto complete links";
            this.auto_complete_links.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.panel4.Location = new System.Drawing.Point(16, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 2);
            this.panel4.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label6.Location = new System.Drawing.Point(12, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Settings";
            // 
            // link_err
            // 
            this.link_err.AutoSize = true;
            this.link_err.BackColor = System.Drawing.Color.Transparent;
            this.link_err.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(34)))));
            this.link_err.Location = new System.Drawing.Point(500, 184);
            this.link_err.Name = "link_err";
            this.link_err.Size = new System.Drawing.Size(124, 19);
            this.link_err.TabIndex = 8;
            this.link_err.Text = "I n v a l i d  L i n k";
            this.link_err.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_err.Visible = false;
            // 
            // settings_cover
            // 
            this.settings_cover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.settings_cover.Controls.Add(this.pictureBox1);
            this.settings_cover.Dock = System.Windows.Forms.DockStyle.Left;
            this.settings_cover.Location = new System.Drawing.Point(36, 21);
            this.settings_cover.Name = "settings_cover";
            this.settings_cover.Size = new System.Drawing.Size(43, 426);
            this.settings_cover.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // scan__
            // 
            this.scan__.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scan__.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.scan__.Location = new System.Drawing.Point(318, 224);
            this.scan__.Name = "scan__";
            this.scan__.Size = new System.Drawing.Size(488, 155);
            this.scan__.TabIndex = 10;
            this.scan__.Text = "label3";
            this.scan__.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(936, 447);
            this.Controls.Add(this.scan__);
            this.Controls.Add(this.settings_cover);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.settingIcon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.link_err);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingIconOff)).EndInit();
            this.settings_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox settingIcon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel settings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label link_err;
        private System.Windows.Forms.CheckBox auto_scan_browse_links;
        private System.Windows.Forms.CheckBox save_scanned_links;
        private System.Windows.Forms.CheckBox auto_complete_links;
        private System.Windows.Forms.Panel settings_cover;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox settingIconOff;
        private System.Windows.Forms.Label scan__;
    }
}