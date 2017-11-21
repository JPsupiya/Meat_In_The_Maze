namespace Meat_intheMaze
{
    partial class Form3
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
            this.wall1 = new System.Windows.Forms.Label();
            this.wall2 = new System.Windows.Forms.Label();
            this.wall3 = new System.Windows.Forms.Label();
            this.wall4 = new System.Windows.Forms.Label();
            this.stp = new System.Windows.Forms.Label();
            this.meatbox1 = new System.Windows.Forms.PictureBox();
            this.ak = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Goal1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.meatbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal1)).BeginInit();
            this.SuspendLayout();
            // 
            // wall1
            // 
            this.wall1.Location = new System.Drawing.Point(-84, 0);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(1200, 20);
            this.wall1.TabIndex = 3;
            this.wall1.Click += new System.EventHandler(this.inwall2_Click);
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.Transparent;
            this.wall2.Location = new System.Drawing.Point(-105, 1027);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(1200, 20);
            this.wall2.TabIndex = 4;
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.Transparent;
            this.wall3.Location = new System.Drawing.Point(-6, 0);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(27, 1047);
            this.wall3.TabIndex = 5;
            // 
            // wall4
            // 
            this.wall4.BackColor = System.Drawing.Color.Transparent;
            this.wall4.Location = new System.Drawing.Point(962, 0);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(20, 1047);
            this.wall4.TabIndex = 6;
            // 
            // stp
            // 
            this.stp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stp.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stp.Location = new System.Drawing.Point(792, 9);
            this.stp.Name = "stp";
            this.stp.Size = new System.Drawing.Size(164, 38);
            this.stp.TabIndex = 7;
            this.stp.Text = "90";
            this.stp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meatbox1
            // 
            this.meatbox1.BackColor = System.Drawing.Color.Transparent;
            this.meatbox1.Image = global::Meat_intheMaze.Properties.Resources._23584570_1392330420893132_1201545388_n;
            this.meatbox1.Location = new System.Drawing.Point(27, 61);
            this.meatbox1.Name = "meatbox1";
            this.meatbox1.Size = new System.Drawing.Size(80, 74);
            this.meatbox1.TabIndex = 8;
            this.meatbox1.TabStop = false;
            this.meatbox1.UseWaitCursor = true;
            // 
            // ak
            // 
            this.ak.BackColor = System.Drawing.Color.Gray;
            this.ak.Location = new System.Drawing.Point(27, 141);
            this.ak.Name = "ak";
            this.ak.Size = new System.Drawing.Size(728, 31);
            this.ak.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Goal1
            // 
            this.Goal1.BackColor = System.Drawing.Color.Transparent;
            this.Goal1.Image = global::Meat_intheMaze.Properties.Resources._1357aee3faada96;
            this.Goal1.Location = new System.Drawing.Point(605, 700);
            this.Goal1.Name = "Goal1";
            this.Goal1.Size = new System.Drawing.Size(300, 300);
            this.Goal1.TabIndex = 10;
            this.Goal1.TabStop = false;
            this.Goal1.UseWaitCursor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(982, 1045);
            this.Controls.Add(this.Goal1);
            this.Controls.Add(this.ak);
            this.Controls.Add(this.meatbox1);
            this.Controls.Add(this.stp);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.wall1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.meatbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label wall1;
        private System.Windows.Forms.Label wall2;
        private System.Windows.Forms.Label wall3;
        private System.Windows.Forms.Label wall4;
        private System.Windows.Forms.Label stp;
        private System.Windows.Forms.PictureBox meatbox1;
        private System.Windows.Forms.Panel ak;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox Goal1;
    }
}