namespace Practise
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.time = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nav = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bin = new System.Windows.Forms.TextBox();
            this.ans = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.Base = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCircleProgressbar1 = new ns1.BunifuCircleProgressbar();
            this.nav.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Interval = 10000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 58);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hide and Show password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 484);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 58);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Area Of a Circle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // nav
            // 
            this.nav.BackColor = System.Drawing.Color.White;
            this.nav.Controls.Add(this.dateTimePicker1);
            this.nav.Controls.Add(this.button1);
            this.nav.Controls.Add(this.button4);
            this.nav.Controls.Add(this.button2);
            this.nav.Controls.Add(this.button3);
            this.nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav.Location = new System.Drawing.Point(0, 0);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(299, 569);
            this.nav.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(33, 534);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(471, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // bin
            // 
            this.bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bin.Location = new System.Drawing.Point(522, 118);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(171, 38);
            this.bin.TabIndex = 5;
            // 
            // ans
            // 
            this.ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.Location = new System.Drawing.Point(522, 168);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(171, 38);
            this.ans.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(522, 248);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 64);
            this.button6.TabIndex = 6;
            this.button6.Text = "convert";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Base
            // 
            this.Base.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base.Location = new System.Drawing.Point(772, 238);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(36, 38);
            this.Base.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(38, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 56);
            this.button7.TabIndex = 8;
            this.button7.Text = "Add name";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(38, 261);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 56);
            this.button8.TabIndex = 8;
            this.button8.Text = "view name";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(177, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 488);
            this.panel2.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(33, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 58);
            this.button5.TabIndex = 3;
            this.button5.Text = "hide";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCircleProgressbar1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.Base);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.ans);
            this.panel1.Controls.Add(this.bin);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(299, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 569);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 5;
            this.bunifuCircleProgressbar1.LineThickness = 3;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(557, 324);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(201, 201);
            this.bunifuCircleProgressbar1.TabIndex = 9;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.nav.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Timer time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel nav;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox bin;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox Base;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCircleProgressbar bunifuCircleProgressbar1;
    }
}

