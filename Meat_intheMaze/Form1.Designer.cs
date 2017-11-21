namespace Meat_intheMaze
{
    partial class Game_state1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inwall = new System.Windows.Forms.Label();
            this.inwall2 = new System.Windows.Forms.Label();
            this.inwall3 = new System.Windows.Forms.Label();
            this.inwall4 = new System.Windows.Forms.Label();
            this.ak1 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.stptimr = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Goal = new System.Windows.Forms.PictureBox();
            this.meatbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Goal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meatbox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inwall
            // 
            this.inwall.BackColor = System.Drawing.Color.Transparent;
            this.inwall.Location = new System.Drawing.Point(-2, -2);
            this.inwall.Name = "inwall";
            this.inwall.Size = new System.Drawing.Size(20, 1000);
            this.inwall.TabIndex = 1;
            // 
            // inwall2
            // 
            this.inwall2.Location = new System.Drawing.Point(0, 0);
            this.inwall2.Name = "inwall2";
            this.inwall2.Size = new System.Drawing.Size(1200, 20);
            this.inwall2.TabIndex = 2;
            // 
            // inwall3
            // 
            this.inwall3.BackColor = System.Drawing.Color.Transparent;
            this.inwall3.Location = new System.Drawing.Point(0, 1033);
            this.inwall3.Name = "inwall3";
            this.inwall3.Size = new System.Drawing.Size(1200, 20);
            this.inwall3.TabIndex = 3;
            // 
            // inwall4
            // 
            this.inwall4.BackColor = System.Drawing.Color.Transparent;
            this.inwall4.Location = new System.Drawing.Point(975, 0);
            this.inwall4.Name = "inwall4";
            this.inwall4.Size = new System.Drawing.Size(20, 1000);
            this.inwall4.TabIndex = 4;
            // 
            // ak1
            // 
            this.ak1.BackColor = System.Drawing.Color.Gray;
            this.ak1.Location = new System.Drawing.Point(12, 128);
            this.ak1.Name = "ak1";
            this.ak1.Size = new System.Drawing.Size(728, 31);
            this.ak1.TabIndex = 5;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // stptimr
            // 
            this.stptimr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stptimr.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stptimr.Location = new System.Drawing.Point(805, 9);
            this.stptimr.Name = "stptimr";
            this.stptimr.Size = new System.Drawing.Size(164, 38);
            this.stptimr.TabIndex = 6;
            this.stptimr.Text = "90";
            this.stptimr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Goal
            // 
            this.Goal.BackColor = System.Drawing.Color.Transparent;
            this.Goal.Image = global::Meat_intheMaze.Properties.Resources._1357aee3faada96;
            this.Goal.Location = new System.Drawing.Point(614, 469);
            this.Goal.Name = "Goal";
            this.Goal.Size = new System.Drawing.Size(300, 300);
            this.Goal.TabIndex = 7;
            this.Goal.TabStop = false;
            this.Goal.UseWaitCursor = true;
            // 
            // meatbox
            // 
            this.meatbox.BackColor = System.Drawing.Color.Transparent;
            this.meatbox.Image = global::Meat_intheMaze.Properties.Resources._23584570_1392330420893132_1201545388_n;
            this.meatbox.Location = new System.Drawing.Point(44, 34);
            this.meatbox.Name = "meatbox";
            this.meatbox.Size = new System.Drawing.Size(80, 74);
            this.meatbox.TabIndex = 0;
            this.meatbox.TabStop = false;
            this.meatbox.UseWaitCursor = true;
            // 
            // Game_state1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 1037);
            this.Controls.Add(this.Goal);
            this.Controls.Add(this.stptimr);
            this.Controls.Add(this.ak1);
            this.Controls.Add(this.inwall4);
            this.Controls.Add(this.inwall3);
            this.Controls.Add(this.inwall2);
            this.Controls.Add(this.inwall);
            this.Controls.Add(this.meatbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Game_state1";
            this.Text = "Meat_In_TheMaze";
            this.Load += new System.EventHandler(this.Game_state1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Goal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meatbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox meatbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label inwall;
        private System.Windows.Forms.Label inwall2;
        private System.Windows.Forms.Label inwall3;
        private System.Windows.Forms.Label inwall4;
        private System.Windows.Forms.Panel ak1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label stptimr;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox Goal;
    }
}

