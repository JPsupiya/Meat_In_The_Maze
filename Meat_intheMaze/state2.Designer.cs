namespace Meat_intheMaze
{
    partial class state2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.ghost = new System.Windows.Forms.Timer(this.components);
            this.bk2 = new System.Windows.Forms.PictureBox();
            this.bk9 = new System.Windows.Forms.PictureBox();
            this.bk11 = new System.Windows.Forms.Panel();
            this.bk14 = new System.Windows.Forms.Panel();
            this.bk13 = new System.Windows.Forms.Panel();
            this.bk20 = new System.Windows.Forms.Panel();
            this.bk19 = new System.Windows.Forms.Panel();
            this.bk18 = new System.Windows.Forms.Panel();
            this.bk17 = new System.Windows.Forms.Panel();
            this.bk21 = new System.Windows.Forms.PictureBox();
            this.bk16 = new System.Windows.Forms.Panel();
            this.bk15 = new System.Windows.Forms.Panel();
            this.bk10 = new System.Windows.Forms.Panel();
            this.bk12 = new System.Windows.Forms.Panel();
            this.bk7 = new System.Windows.Forms.Panel();
            this.bk6 = new System.Windows.Forms.Panel();
            this.bk5 = new System.Windows.Forms.Panel();
            this.bk4 = new System.Windows.Forms.Panel();
            this.Goal1 = new System.Windows.Forms.PictureBox();
            this.bk1 = new System.Windows.Forms.Panel();
            this.meatbox1 = new System.Windows.Forms.PictureBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.bk3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mmg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bk9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bk21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meatbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmg)).BeginInit();
            this.SuspendLayout();
            // 
            // wall1
            // 
            this.wall1.Location = new System.Drawing.Point(-84, -32);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(1200, 32);
            this.wall1.TabIndex = 3;
            this.wall1.Click += new System.EventHandler(this.inwall2_Click);
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.Transparent;
            this.wall2.Location = new System.Drawing.Point(-113, 851);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(1200, 17);
            this.wall2.TabIndex = 4;
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.Transparent;
            this.wall3.Location = new System.Drawing.Point(-21, 0);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(22, 1047);
            this.wall3.TabIndex = 5;
            // 
            // wall4
            // 
            this.wall4.BackColor = System.Drawing.Color.Transparent;
            this.wall4.Location = new System.Drawing.Point(988, 0);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(23, 1047);
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
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // ghost
            // 
            this.ghost.Enabled = true;
            this.ghost.Tick += new System.EventHandler(this.ghost_Tick);
            // 
            // bk2
            // 
            this.bk2.Location = new System.Drawing.Point(393, 141);
            this.bk2.Name = "bk2";
            this.bk2.Size = new System.Drawing.Size(107, 99);
            this.bk2.TabIndex = 27;
            this.bk2.TabStop = false;
            // 
            // bk9
            // 
            this.bk9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bk9.Image = global::Meat_intheMaze.Properties.Resources.mustroom1;
            this.bk9.Location = new System.Drawing.Point(22, 355);
            this.bk9.Name = "bk9";
            this.bk9.Size = new System.Drawing.Size(124, 149);
            this.bk9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bk9.TabIndex = 26;
            this.bk9.TabStop = false;
            // 
            // bk11
            // 
            this.bk11.BackColor = System.Drawing.Color.Transparent;
            this.bk11.BackgroundImage = global::Meat_intheMaze.Properties.Resources.hand;
            this.bk11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bk11.Location = new System.Drawing.Point(386, 408);
            this.bk11.Name = "bk11";
            this.bk11.Size = new System.Drawing.Size(147, 71);
            this.bk11.TabIndex = 23;
            // 
            // bk14
            // 
            this.bk14.BackColor = System.Drawing.Color.Transparent;
            this.bk14.BackgroundImage = global::Meat_intheMaze.Properties.Resources.point;
            this.bk14.Location = new System.Drawing.Point(706, 495);
            this.bk14.Name = "bk14";
            this.bk14.Size = new System.Drawing.Size(88, 72);
            this.bk14.TabIndex = 24;
            // 
            // bk13
            // 
            this.bk13.BackColor = System.Drawing.Color.Transparent;
            this.bk13.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk13.Location = new System.Drawing.Point(513, 499);
            this.bk13.Name = "bk13";
            this.bk13.Size = new System.Drawing.Size(275, 55);
            this.bk13.TabIndex = 22;
            // 
            // bk20
            // 
            this.bk20.BackColor = System.Drawing.Color.Transparent;
            this.bk20.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk20.Location = new System.Drawing.Point(610, 714);
            this.bk20.Name = "bk20";
            this.bk20.Size = new System.Drawing.Size(275, 55);
            this.bk20.TabIndex = 17;
            // 
            // bk19
            // 
            this.bk19.BackColor = System.Drawing.Color.Transparent;
            this.bk19.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk19.Location = new System.Drawing.Point(236, 714);
            this.bk19.Name = "bk19";
            this.bk19.Size = new System.Drawing.Size(275, 55);
            this.bk19.TabIndex = 16;
            // 
            // bk18
            // 
            this.bk18.BackColor = System.Drawing.Color.Transparent;
            this.bk18.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk18.Location = new System.Drawing.Point(12, 714);
            this.bk18.Name = "bk18";
            this.bk18.Size = new System.Drawing.Size(218, 50);
            this.bk18.TabIndex = 17;
            // 
            // bk17
            // 
            this.bk17.BackColor = System.Drawing.Color.Transparent;
            this.bk17.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk17.Location = new System.Drawing.Point(153, 627);
            this.bk17.Name = "bk17";
            this.bk17.Size = new System.Drawing.Size(50, 91);
            this.bk17.TabIndex = 18;
            // 
            // bk21
            // 
            this.bk21.BackColor = System.Drawing.Color.Transparent;
            this.bk21.Image = global::Meat_intheMaze.Properties.Resources.mustroom3;
            this.bk21.Location = new System.Drawing.Point(880, 627);
            this.bk21.Name = "bk21";
            this.bk21.Size = new System.Drawing.Size(101, 81);
            this.bk21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bk21.TabIndex = 19;
            this.bk21.TabStop = false;
            this.bk21.UseWaitCursor = true;
            // 
            // bk16
            // 
            this.bk16.BackColor = System.Drawing.Color.Transparent;
            this.bk16.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk16.Location = new System.Drawing.Point(706, 573);
            this.bk16.Name = "bk16";
            this.bk16.Size = new System.Drawing.Size(275, 50);
            this.bk16.TabIndex = 18;
            // 
            // bk15
            // 
            this.bk15.BackColor = System.Drawing.Color.Transparent;
            this.bk15.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk15.Location = new System.Drawing.Point(12, 573);
            this.bk15.Name = "bk15";
            this.bk15.Size = new System.Drawing.Size(499, 50);
            this.bk15.TabIndex = 17;
            // 
            // bk10
            // 
            this.bk10.BackColor = System.Drawing.Color.Transparent;
            this.bk10.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk10.Location = new System.Drawing.Point(144, 416);
            this.bk10.Name = "bk10";
            this.bk10.Size = new System.Drawing.Size(255, 60);
            this.bk10.TabIndex = 16;
            // 
            // bk12
            // 
            this.bk12.BackColor = System.Drawing.Color.Transparent;
            this.bk12.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk12.Location = new System.Drawing.Point(706, 415);
            this.bk12.Name = "bk12";
            this.bk12.Size = new System.Drawing.Size(275, 61);
            this.bk12.TabIndex = 15;
            // 
            // bk7
            // 
            this.bk7.BackColor = System.Drawing.Color.Transparent;
            this.bk7.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk7.Location = new System.Drawing.Point(706, 242);
            this.bk7.Name = "bk7";
            this.bk7.Size = new System.Drawing.Size(275, 49);
            this.bk7.TabIndex = 14;
            // 
            // bk6
            // 
            this.bk6.BackColor = System.Drawing.Color.Transparent;
            this.bk6.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk6.Location = new System.Drawing.Point(279, 265);
            this.bk6.Name = "bk6";
            this.bk6.Size = new System.Drawing.Size(275, 53);
            this.bk6.TabIndex = 10;
            // 
            // bk5
            // 
            this.bk5.BackColor = System.Drawing.Color.Transparent;
            this.bk5.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk5.Location = new System.Drawing.Point(-2, 265);
            this.bk5.Name = "bk5";
            this.bk5.Size = new System.Drawing.Size(275, 37);
            this.bk5.TabIndex = 10;
            // 
            // bk4
            // 
            this.bk4.BackColor = System.Drawing.Color.Transparent;
            this.bk4.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk4.Location = new System.Drawing.Point(610, 141);
            this.bk4.Name = "bk4";
            this.bk4.Size = new System.Drawing.Size(381, 37);
            this.bk4.TabIndex = 13;
            // 
            // Goal1
            // 
            this.Goal1.BackColor = System.Drawing.Color.Transparent;
            this.Goal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Goal1.Image = global::Meat_intheMaze.Properties.Resources.mustroom3;
            this.Goal1.Location = new System.Drawing.Point(12, 641);
            this.Goal1.Name = "Goal1";
            this.Goal1.Size = new System.Drawing.Size(83, 77);
            this.Goal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Goal1.TabIndex = 10;
            this.Goal1.TabStop = false;
            this.Goal1.UseWaitCursor = true;
            // 
            // bk1
            // 
            this.bk1.BackColor = System.Drawing.Color.Transparent;
            this.bk1.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk1.Location = new System.Drawing.Point(-2, 141);
            this.bk1.Name = "bk1";
            this.bk1.Size = new System.Drawing.Size(382, 37);
            this.bk1.TabIndex = 9;
            // 
            // meatbox1
            // 
            this.meatbox1.BackColor = System.Drawing.Color.Transparent;
            this.meatbox1.Image = global::Meat_intheMaze.Properties.Resources.meatcute33;
            this.meatbox1.Location = new System.Drawing.Point(27, 61);
            this.meatbox1.Name = "meatbox1";
            this.meatbox1.Size = new System.Drawing.Size(60, 60);
            this.meatbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.meatbox1.TabIndex = 8;
            this.meatbox1.TabStop = false;
            this.meatbox1.UseWaitCursor = true;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Transparent;
            this.panel18.BackgroundImage = global::Meat_intheMaze.Properties.Resources.key1;
            this.panel18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel18.Location = new System.Drawing.Point(513, 184);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(63, 56);
            this.panel18.TabIndex = 25;
            // 
            // bk3
            // 
            this.bk3.BackColor = System.Drawing.Color.Transparent;
            this.bk3.BackgroundImage = global::Meat_intheMaze.Properties.Resources.fence;
            this.bk3.Location = new System.Drawing.Point(513, 141);
            this.bk3.Name = "bk3";
            this.bk3.Size = new System.Drawing.Size(100, 37);
            this.bk3.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Meat_intheMaze.Properties.Resources.sleep;
            this.pictureBox3.Location = new System.Drawing.Point(26, 770);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Meat_intheMaze.Properties.Resources.sleep;
            this.pictureBox2.Location = new System.Drawing.Point(98, 771);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // mmg
            // 
            this.mmg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mmg.Image = global::Meat_intheMaze.Properties.Resources.ghost555551;
            this.mmg.Location = new System.Drawing.Point(437, 641);
            this.mmg.Name = "mmg";
            this.mmg.Size = new System.Drawing.Size(63, 68);
            this.mmg.TabIndex = 28;
            this.mmg.TabStop = false;
            // 
            // state2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(982, 1045);
            this.Controls.Add(this.bk2);
            this.Controls.Add(this.bk9);
            this.Controls.Add(this.bk11);
            this.Controls.Add(this.bk14);
            this.Controls.Add(this.bk13);
            this.Controls.Add(this.bk20);
            this.Controls.Add(this.bk19);
            this.Controls.Add(this.bk18);
            this.Controls.Add(this.bk17);
            this.Controls.Add(this.bk21);
            this.Controls.Add(this.bk16);
            this.Controls.Add(this.bk15);
            this.Controls.Add(this.bk10);
            this.Controls.Add(this.bk12);
            this.Controls.Add(this.bk7);
            this.Controls.Add(this.bk6);
            this.Controls.Add(this.bk5);
            this.Controls.Add(this.bk4);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.Goal1);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.bk1);
            this.Controls.Add(this.meatbox1);
            this.Controls.Add(this.stp);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.bk3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mmg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "state2";
            this.Text = "Meat_In_TheMaze State2";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.state2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bk9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bk21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meatbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wall1;
        private System.Windows.Forms.Label wall2;
        private System.Windows.Forms.Label wall3;
        private System.Windows.Forms.Label wall4;
        private System.Windows.Forms.Label stp;
        private System.Windows.Forms.PictureBox meatbox1;
        private System.Windows.Forms.Panel bk1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox Goal1;
        private System.Windows.Forms.Panel bk3;
        private System.Windows.Forms.Panel bk4;
        private System.Windows.Forms.Panel bk5;
        private System.Windows.Forms.Panel bk6;
        private System.Windows.Forms.Panel bk7;
        private System.Windows.Forms.Panel bk12;
        private System.Windows.Forms.Panel bk10;
        private System.Windows.Forms.Panel bk15;
        private System.Windows.Forms.Panel bk16;
        private System.Windows.Forms.PictureBox bk21;
        private System.Windows.Forms.Panel bk18;
        private System.Windows.Forms.Panel bk19;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel bk20;
        private System.Windows.Forms.Panel bk13;
        private System.Windows.Forms.Panel bk11;
        private System.Windows.Forms.Panel bk14;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel bk17;
        private System.Windows.Forms.PictureBox bk9;
        private System.Windows.Forms.PictureBox bk2;
        private System.Windows.Forms.PictureBox mmg;
        private System.Windows.Forms.Timer ghost;
    }
}