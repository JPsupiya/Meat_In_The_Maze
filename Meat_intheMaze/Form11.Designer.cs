namespace Meat_intheMaze
{
    partial class Form11
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
            this.d1 = new System.Windows.Forms.Label();
            this.d2 = new System.Windows.Forms.Label();
            this.d3 = new System.Windows.Forms.Label();
            this.d4 = new System.Windows.Forms.Label();
            this.meatbox10 = new System.Windows.Forms.PictureBox();
            this.jk1 = new System.Windows.Forms.Panel();
            this.s4 = new System.Windows.Forms.Label();
            this.Goal11 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.meatbox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal11)).BeginInit();
            this.SuspendLayout();
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(-104, 0);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(1200, 20);
            this.d1.TabIndex = 6;
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(-208, 1019);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(1200, 20);
            this.d2.TabIndex = 7;
            // 
            // d3
            // 
            this.d3.BackColor = System.Drawing.Color.Transparent;
            this.d3.Location = new System.Drawing.Point(-2, 0);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(22, 1040);
            this.d3.TabIndex = 8;
            // 
            // d4
            // 
            this.d4.BackColor = System.Drawing.Color.Transparent;
            this.d4.Location = new System.Drawing.Point(960, 0);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(22, 1040);
            this.d4.TabIndex = 9;
            // 
            // meatbox10
            // 
            this.meatbox10.BackColor = System.Drawing.Color.Transparent;
            this.meatbox10.Image = global::Meat_intheMaze.Properties.Resources._23584570_1392330420893132_1201545388_n;
            this.meatbox10.Location = new System.Drawing.Point(26, 23);
            this.meatbox10.Name = "meatbox10";
            this.meatbox10.Size = new System.Drawing.Size(80, 74);
            this.meatbox10.TabIndex = 10;
            this.meatbox10.TabStop = false;
            this.meatbox10.UseWaitCursor = true;
            // 
            // jk1
            // 
            this.jk1.BackColor = System.Drawing.Color.Gray;
            this.jk1.Location = new System.Drawing.Point(26, 148);
            this.jk1.Name = "jk1";
            this.jk1.Size = new System.Drawing.Size(728, 31);
            this.jk1.TabIndex = 12;
            // 
            // s4
            // 
            this.s4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.s4.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s4.Location = new System.Drawing.Point(790, 23);
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(164, 38);
            this.s4.TabIndex = 13;
            this.s4.Text = "90";
            this.s4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Goal11
            // 
            this.Goal11.BackColor = System.Drawing.Color.Transparent;
            this.Goal11.Image = global::Meat_intheMaze.Properties.Resources._1357aee3faada96;
            this.Goal11.Location = new System.Drawing.Point(604, 629);
            this.Goal11.Name = "Goal11";
            this.Goal11.Size = new System.Drawing.Size(300, 300);
            this.Goal11.TabIndex = 14;
            this.Goal11.TabStop = false;
            this.Goal11.UseWaitCursor = true;
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
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 1035);
            this.Controls.Add(this.Goal11);
            this.Controls.Add(this.s4);
            this.Controls.Add(this.jk1);
            this.Controls.Add(this.meatbox10);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form11";
            this.Text = "Form11";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form11_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.meatbox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label d1;
        private System.Windows.Forms.Label d2;
        private System.Windows.Forms.Label d3;
        private System.Windows.Forms.Label d4;
        private System.Windows.Forms.PictureBox meatbox10;
        private System.Windows.Forms.Panel jk1;
        private System.Windows.Forms.Label s4;
        private System.Windows.Forms.PictureBox Goal11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}