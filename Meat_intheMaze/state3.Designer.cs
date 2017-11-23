namespace Meat_intheMaze
{
    partial class state3
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
            this.w1 = new System.Windows.Forms.Label();
            this.w2 = new System.Windows.Forms.Label();
            this.w3 = new System.Windows.Forms.Label();
            this.w4 = new System.Windows.Forms.Label();
            this.stpt = new System.Windows.Forms.Label();
            this.ck1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Goal2 = new System.Windows.Forms.PictureBox();
            this.meatbox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meatbox2)).BeginInit();
            this.SuspendLayout();
            // 
            // w1
            // 
            this.w1.Location = new System.Drawing.Point(-15, -17);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(1200, 15);
            this.w1.TabIndex = 3;
            // 
            // w2
            // 
            this.w2.Location = new System.Drawing.Point(-185, 1036);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(1200, 13);
            this.w2.TabIndex = 4;
            // 
            // w3
            // 
            this.w3.BackColor = System.Drawing.Color.Transparent;
            this.w3.Location = new System.Drawing.Point(-15, -2);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(11, 1100);
            this.w3.TabIndex = 5;
            // 
            // w4
            // 
            this.w4.BackColor = System.Drawing.Color.Transparent;
            this.w4.Location = new System.Drawing.Point(985, -2);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(30, 1051);
            this.w4.TabIndex = 6;
            // 
            // stpt
            // 
            this.stpt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stpt.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stpt.Location = new System.Drawing.Point(785, 21);
            this.stpt.Name = "stpt";
            this.stpt.Size = new System.Drawing.Size(164, 38);
            this.stpt.TabIndex = 8;
            this.stpt.Text = "90";
            this.stpt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ck1
            // 
            this.ck1.BackColor = System.Drawing.Color.Gray;
            this.ck1.Location = new System.Drawing.Point(57, 147);
            this.ck1.Name = "ck1";
            this.ck1.Size = new System.Drawing.Size(728, 31);
            this.ck1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 245;
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Meat_intheMaze.Properties.Resources._10;
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(977, 1035);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Goal2
            // 
            this.Goal2.BackColor = System.Drawing.Color.Transparent;
            this.Goal2.Image = global::Meat_intheMaze.Properties.Resources._1357aee3faada96;
            this.Goal2.Location = new System.Drawing.Point(649, 652);
            this.Goal2.Name = "Goal2";
            this.Goal2.Size = new System.Drawing.Size(300, 300);
            this.Goal2.TabIndex = 9;
            this.Goal2.TabStop = false;
            this.Goal2.UseWaitCursor = true;
            // 
            // meatbox2
            // 
            this.meatbox2.BackColor = System.Drawing.Color.Transparent;
            this.meatbox2.Image = global::Meat_intheMaze.Properties.Resources.meatcute3;
            this.meatbox2.Location = new System.Drawing.Point(27, 67);
            this.meatbox2.Name = "meatbox2";
            this.meatbox2.Size = new System.Drawing.Size(48, 38);
            this.meatbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.meatbox2.TabIndex = 7;
            this.meatbox2.TabStop = false;
            this.meatbox2.UseWaitCursor = true;
            this.meatbox2.Click += new System.EventHandler(this.meatbox_Click);
            // 
            // state3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 1037);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.Goal2);
            this.Controls.Add(this.meatbox2);
            this.Controls.Add(this.stpt);
            this.Controls.Add(this.ck1);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "state3";
            this.Text = "Meat_In_TheMaze State3";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meatbox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label w1;
        private System.Windows.Forms.Label w2;
        private System.Windows.Forms.Label w3;
        private System.Windows.Forms.Label w4;
        private System.Windows.Forms.PictureBox meatbox2;
        private System.Windows.Forms.Label stpt;
        private System.Windows.Forms.PictureBox Goal2;
        private System.Windows.Forms.Panel ck1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}