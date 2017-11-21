namespace Meat_intheMaze
{
    partial class Form6
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
            this.fen1 = new System.Windows.Forms.Label();
            this.fen2 = new System.Windows.Forms.Label();
            this.fen3 = new System.Windows.Forms.Label();
            this.fen4 = new System.Windows.Forms.Label();
            this.meatbox4 = new System.Windows.Forms.PictureBox();
            this.ek1 = new System.Windows.Forms.Panel();
            this.Goal5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.stptimr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.meatbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal5)).BeginInit();
            this.SuspendLayout();
            // 
            // fen1
            // 
            this.fen1.Location = new System.Drawing.Point(-116, -2);
            this.fen1.Name = "fen1";
            this.fen1.Size = new System.Drawing.Size(1200, 20);
            this.fen1.TabIndex = 4;
            // 
            // fen2
            // 
            this.fen2.Location = new System.Drawing.Point(-149, 1017);
            this.fen2.Name = "fen2";
            this.fen2.Size = new System.Drawing.Size(1200, 20);
            this.fen2.TabIndex = 5;
            // 
            // fen3
            // 
            this.fen3.BackColor = System.Drawing.Color.Transparent;
            this.fen3.Location = new System.Drawing.Point(-5, -22);
            this.fen3.Name = "fen3";
            this.fen3.Size = new System.Drawing.Size(23, 1039);
            this.fen3.TabIndex = 6;
            // 
            // fen4
            // 
            this.fen4.BackColor = System.Drawing.Color.Transparent;
            this.fen4.Location = new System.Drawing.Point(960, -2);
            this.fen4.Name = "fen4";
            this.fen4.Size = new System.Drawing.Size(23, 1039);
            this.fen4.TabIndex = 7;
            // 
            // meatbox4
            // 
            this.meatbox4.BackColor = System.Drawing.Color.Transparent;
            this.meatbox4.Image = global::Meat_intheMaze.Properties.Resources._23584570_1392330420893132_1201545388_n;
            this.meatbox4.Location = new System.Drawing.Point(24, 21);
            this.meatbox4.Name = "meatbox4";
            this.meatbox4.Size = new System.Drawing.Size(80, 74);
            this.meatbox4.TabIndex = 8;
            this.meatbox4.TabStop = false;
            this.meatbox4.UseWaitCursor = true;
            // 
            // ek1
            // 
            this.ek1.BackColor = System.Drawing.Color.Gray;
            this.ek1.Location = new System.Drawing.Point(41, 162);
            this.ek1.Name = "ek1";
            this.ek1.Size = new System.Drawing.Size(728, 31);
            this.ek1.TabIndex = 9;
            // 
            // Goal5
            // 
            this.Goal5.BackColor = System.Drawing.Color.Transparent;
            this.Goal5.Image = global::Meat_intheMaze.Properties.Resources._1357aee3faada96;
            this.Goal5.Location = new System.Drawing.Point(633, 661);
            this.Goal5.Name = "Goal5";
            this.Goal5.Size = new System.Drawing.Size(300, 300);
            this.Goal5.TabIndex = 10;
            this.Goal5.TabStop = false;
            this.Goal5.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // stptimr
            // 
            this.stptimr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stptimr.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stptimr.Location = new System.Drawing.Point(790, 21);
            this.stptimr.Name = "stptimr";
            this.stptimr.Size = new System.Drawing.Size(164, 38);
            this.stptimr.TabIndex = 11;
            this.stptimr.Text = "90";
            this.stptimr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 1035);
            this.Controls.Add(this.stptimr);
            this.Controls.Add(this.Goal5);
            this.Controls.Add(this.ek1);
            this.Controls.Add(this.meatbox4);
            this.Controls.Add(this.fen4);
            this.Controls.Add(this.fen3);
            this.Controls.Add(this.fen2);
            this.Controls.Add(this.fen1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form6_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.meatbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fen1;
        private System.Windows.Forms.Label fen2;
        private System.Windows.Forms.Label fen3;
        private System.Windows.Forms.Label fen4;
        private System.Windows.Forms.PictureBox meatbox4;
        private System.Windows.Forms.Panel ek1;
        private System.Windows.Forms.PictureBox Goal5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label stptimr;
    }
}