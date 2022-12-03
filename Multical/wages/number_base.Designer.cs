namespace wages
{
    partial class number_base
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hepta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.err = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelvLight", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(78, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Base";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 98);
            this.panel1.TabIndex = 3;
            // 
            // bin
            // 
            this.bin.BackColor = System.Drawing.Color.Gold;
            this.bin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bin.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bin.Location = new System.Drawing.Point(332, 22);
            this.bin.MaxLength = 31;
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(453, 34);
            this.bin.TabIndex = 4;
            this.bin.Text = "0";
            this.bin.Click += new System.EventHandler(this.bin_Click);
            this.bin.TextChanged += new System.EventHandler(this.bin_TextChanged);
            this.bin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(143, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Binary :";
            // 
            // dec
            // 
            this.dec.BackColor = System.Drawing.Color.Gold;
            this.dec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dec.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec.Location = new System.Drawing.Point(331, 16);
            this.dec.MaxLength = 9;
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(453, 34);
            this.dec.TabIndex = 4;
            this.dec.Text = "0";
            this.dec.Click += new System.EventHandler(this.dec_Click);
            this.dec.TextChanged += new System.EventHandler(this.dec_TextChanged);
            this.dec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dec_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(142, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Decimal :";
            // 
            // oct
            // 
            this.oct.BackColor = System.Drawing.Color.Gold;
            this.oct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oct.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oct.Location = new System.Drawing.Point(332, 18);
            this.oct.Name = "oct";
            this.oct.Size = new System.Drawing.Size(453, 34);
            this.oct.TabIndex = 4;
            this.oct.Text = "0";
            this.oct.Click += new System.EventHandler(this.oct_Click);
            this.oct.TextChanged += new System.EventHandler(this.oct_TextChanged);
            this.oct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oct_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.label4.Location = new System.Drawing.Point(143, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Octal :";
            // 
            // hepta
            // 
            this.hepta.BackColor = System.Drawing.Color.Gold;
            this.hepta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hepta.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hepta.Location = new System.Drawing.Point(332, 22);
            this.hepta.Name = "hepta";
            this.hepta.Size = new System.Drawing.Size(453, 34);
            this.hepta.TabIndex = 4;
            this.hepta.Text = "0";
            this.hepta.Click += new System.EventHandler(this.hepta_Click);
            this.hepta.TextChanged += new System.EventHandler(this.hepta_TextChanged);
            this.hepta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hepta_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.label5.Location = new System.Drawing.Point(143, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hepta";
            // 
            // hex
            // 
            this.hex.BackColor = System.Drawing.Color.Gold;
            this.hex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hex.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hex.Location = new System.Drawing.Point(332, 30);
            this.hex.MaxLength = 7;
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(453, 34);
            this.hex.TabIndex = 4;
            this.hex.Text = "0";
            this.hex.Click += new System.EventHandler(this.hex_Click);
            this.hex.TextChanged += new System.EventHandler(this.hex_TextChanged);
            this.hex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hex_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.label6.Location = new System.Drawing.Point(143, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hexa-decimal :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 622);
            this.panel2.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.err);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 590);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(830, 32);
            this.panel9.TabIndex = 9;
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.Font = new System.Drawing.Font("HelvLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err.ForeColor = System.Drawing.Color.DarkRed;
            this.err.Location = new System.Drawing.Point(15, 6);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(43, 19);
            this.err.TabIndex = 3;
            this.err.Text = "Error";
            this.err.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.hex);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 367);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(830, 85);
            this.panel8.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.hepta);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 298);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(830, 69);
            this.panel7.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.oct);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 234);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(830, 64);
            this.panel6.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bin);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 158);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(830, 76);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dec);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(830, 66);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(830, 92);
            this.panel3.TabIndex = 0;
            // 
            // number_base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "number_base";
            this.Size = new System.Drawing.Size(830, 720);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox bin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hepta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label err;
    }
}
