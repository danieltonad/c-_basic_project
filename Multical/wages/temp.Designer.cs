namespace wages
{
    partial class temp
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rank = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fah = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cel = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.err = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelvLight", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(78, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperature";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 65);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 623);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.rea);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.rank);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.kel);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.fah);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(174, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(656, 623);
            this.panel4.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.label6.Location = new System.Drawing.Point(22, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Réaumur :";
            // 
            // rea
            // 
            this.rea.BackColor = System.Drawing.Color.Gold;
            this.rea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rea.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rea.Location = new System.Drawing.Point(197, 403);
            this.rea.MaxLength = 9;
            this.rea.Name = "rea";
            this.rea.Size = new System.Drawing.Size(365, 34);
            this.rea.TabIndex = 8;
            this.rea.Text = "0";
            this.rea.TextChanged += new System.EventHandler(this.rea_TextChanged);
            this.rea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rea_KeyPress);
            this.rea.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rea_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.label5.Location = new System.Drawing.Point(22, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rankine :";
            // 
            // rank
            // 
            this.rank.BackColor = System.Drawing.Color.Gold;
            this.rank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rank.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank.Location = new System.Drawing.Point(197, 343);
            this.rank.MaxLength = 9;
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(365, 34);
            this.rank.TabIndex = 8;
            this.rank.Text = "0";
            this.rank.TextChanged += new System.EventHandler(this.rank_TextChanged);
            this.rank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rank_KeyPress);
            this.rank.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rank_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.label4.Location = new System.Drawing.Point(22, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kelvin :";
            // 
            // kel
            // 
            this.kel.BackColor = System.Drawing.Color.Gold;
            this.kel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kel.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kel.Location = new System.Drawing.Point(197, 278);
            this.kel.MaxLength = 9;
            this.kel.Name = "kel";
            this.kel.Size = new System.Drawing.Size(365, 34);
            this.kel.TabIndex = 8;
            this.kel.Text = "0";
            this.kel.TextChanged += new System.EventHandler(this.kel_TextChanged);
            this.kel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kel_KeyPress);
            this.kel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kel_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(22, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fahrenheit :";
            // 
            // fah
            // 
            this.fah.BackColor = System.Drawing.Color.Gold;
            this.fah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fah.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fah.Location = new System.Drawing.Point(197, 206);
            this.fah.MaxLength = 9;
            this.fah.Name = "fah";
            this.fah.Size = new System.Drawing.Size(365, 34);
            this.fah.TabIndex = 8;
            this.fah.Text = "0";
            this.fah.TextChanged += new System.EventHandler(this.fah_TextChanged);
            this.fah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fah_KeyPress);
            this.fah.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fah_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Celcius :";
            // 
            // cel
            // 
            this.cel.BackColor = System.Drawing.Color.Gold;
            this.cel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cel.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cel.Location = new System.Drawing.Point(197, 137);
            this.cel.MaxLength = 9;
            this.cel.Name = "cel";
            this.cel.Size = new System.Drawing.Size(365, 34);
            this.cel.TabIndex = 6;
            this.cel.Text = "0";
            this.cel.TextChanged += new System.EventHandler(this.cel_TextChanged);
            this.cel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cel_KeyPress);
            this.cel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cel_KeyUp);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.err);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 688);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(830, 32);
            this.panel9.TabIndex = 10;
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
            // temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "temp";
            this.Size = new System.Drawing.Size(830, 720);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fah;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label err;
    }
}
