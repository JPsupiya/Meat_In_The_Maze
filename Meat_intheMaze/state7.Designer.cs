namespace Meat_intheMaze
{
    partial class state7
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
            this.fe1 = new System.Windows.Forms.Label();
            this.fe2 = new System.Windows.Forms.Label();
            this.fe3 = new System.Windows.Forms.Label();
            this.fe4 = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.Label();
            this.gk1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Goal8 = new System.Windows.Forms.PictureBox();
            this.meatbox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Goal8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meatbox7)).BeginInit();
            this.SuspendLayout();
            // 
            // fe1
            // 
            this.fe1.Location = new System.Drawing.Point(-206, 0);
            this.fe1.Name = "fe1";
            this.fe1.Size = new System.Drawing.Size(1200, 20);
            this.fe1.TabIndex = 3;
            // 
            // fe2
            // 
            this.fe2.Location = new System.Drawing.Point(-132, 1020);
            this.fe2.Name = "fe2";
            this.fe2.Size = new System.Drawing.Size(1200, 20);
            this.fe2.TabIndex = 4;
            // 
            // fe3
            // 
            this.fe3.BackColor = System.Drawing.Color.Transparent;
            this.fe3.Location = new System.Drawing.Point(0, 0);
            this.fe3.Name = "fe3";
            this.fe3.Size = new System.Drawing.Size(20, 1000);
            this.fe3.TabIndex = 5;
            // 
            // fe4
            // 
            this.fe4.BackColor = System.Drawing.Color.Transparent;
            this.fe4.Location = new System.Drawing.Point(965, 0);
            this.fe4.Name = "fe4";
            this.fe4.Size = new System.Drawing.Size(20, 1000);
            this.fe4.TabIndex = 6;
            // 
            // s2
            // 
            this.s2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.s2.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s2.Location = new System.Drawing.Point(795, 23);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(164, 38);
            this.s2.TabIndex = 8;
            this.s2.Text = "90";
            this.s2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gk1
            // 
            this.gk1.BackColor = System.Drawing.Color.Gray;
            this.gk1.Location = new System.Drawing.Point(58, 141);
            this.gk1.Name = "gk1";
            this.gk1.Size = new System.Drawing.Size(728, 31);
            this.gk1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 225;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 900;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Goal8
            // 
            this.Goal8.BackColor = System.Drawing.Color.Transparent;
            this.Goal8.Image = global::Meat_intheMaze.Properties.Resources._1357aee3faada96;
            this.Goal8.Location = new System.Drawing.Point(650, 458);
            this.Goal8.Name = "Goal8";
            this.Goal8.Size = new System.Drawing.Size(300, 300);
            this.Goal8.TabIndex = 10;
            this.Goal8.TabStop = false;
            this.Goal8.UseWaitCursor = true;
            // 
            // meatbox7
            // 
            this.meatbox7.BackColor = System.Drawing.Color.Transparent;
            this.meatbox7.Image = global::Meat_intheMaze.Properties.Resources._23584570_1392330420893132_1201545388_n;
            this.meatbox7.Location = new System.Drawing.Point(26, 23);
            this.meatbox7.Name = "meatbox7";
            this.meatbox7.Size = new System.Drawing.Size(80, 74);
            this.meatbox7.TabIndex = 7;
            this.meatbox7.TabStop = false;
            this.meatbox7.UseWaitCursor = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 1035);
            this.Controls.Add(this.Goal8);
            this.Controls.Add(this.gk1);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.meatbox7);
            this.Controls.Add(this.fe4);
            this.Controls.Add(this.fe3);
            this.Controls.Add(this.fe2);
            this.Controls.Add(this.fe1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form8";
            this.Text = "Meat_In_TheMaze State7";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form8_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Goal8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meatbox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fe1;
        private System.Windows.Forms.Label fe2;
        private System.Windows.Forms.Label fe3;
        private System.Windows.Forms.Label fe4;
        private System.Windows.Forms.PictureBox meatbox7;
        private System.Windows.Forms.Label s2;
        private System.Windows.Forms.Panel gk1;
        private System.Windows.Forms.PictureBox Goal8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}