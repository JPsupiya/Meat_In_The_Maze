namespace Meat_intheMaze
{
    partial class Form9
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
            this.b1 = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.Label();
            this.b3 = new System.Windows.Forms.Label();
            this.b4 = new System.Windows.Forms.Label();
            this.meatbox8 = new System.Windows.Forms.PictureBox();
            this.s2 = new System.Windows.Forms.Label();
            this.hk1 = new System.Windows.Forms.Panel();
            this.Goal9 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.meatbox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal9)).BeginInit();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(-118, -1);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(1200, 20);
            this.b1.TabIndex = 4;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(-136, 1017);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(1200, 20);
            this.b2.TabIndex = 5;
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Transparent;
            this.b3.Location = new System.Drawing.Point(1, -1);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(20, 1000);
            this.b3.TabIndex = 6;
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.Transparent;
            this.b4.Location = new System.Drawing.Point(962, -1);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(20, 1000);
            this.b4.TabIndex = 7;
            // 
            // meatbox8
            // 
            this.meatbox8.BackColor = System.Drawing.Color.Transparent;
            this.meatbox8.Image = global::Meat_intheMaze.Properties.Resources._23584570_1392330420893132_1201545388_n;
            this.meatbox8.Location = new System.Drawing.Point(27, 22);
            this.meatbox8.Name = "meatbox8";
            this.meatbox8.Size = new System.Drawing.Size(80, 74);
            this.meatbox8.TabIndex = 8;
            this.meatbox8.TabStop = false;
            this.meatbox8.UseWaitCursor = true;
            // 
            // s2
            // 
            this.s2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.s2.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s2.Location = new System.Drawing.Point(792, 22);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(164, 38);
            this.s2.TabIndex = 9;
            this.s2.Text = "90";
            this.s2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hk1
            // 
            this.hk1.BackColor = System.Drawing.Color.Gray;
            this.hk1.Location = new System.Drawing.Point(45, 152);
            this.hk1.Name = "hk1";
            this.hk1.Size = new System.Drawing.Size(728, 31);
            this.hk1.TabIndex = 10;
            // 
            // Goal9
            // 
            this.Goal9.BackColor = System.Drawing.Color.Transparent;
            this.Goal9.Image = global::Meat_intheMaze.Properties.Resources._1357aee3faada96;
            this.Goal9.Location = new System.Drawing.Point(638, 682);
            this.Goal9.Name = "Goal9";
            this.Goal9.Size = new System.Drawing.Size(300, 300);
            this.Goal9.TabIndex = 11;
            this.Goal9.TabStop = false;
            this.Goal9.UseWaitCursor = true;
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
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 1035);
            this.Controls.Add(this.Goal9);
            this.Controls.Add(this.hk1);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.meatbox8);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form9";
            this.Text = "Form9";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form9_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.meatbox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label b1;
        private System.Windows.Forms.Label b2;
        private System.Windows.Forms.Label b3;
        private System.Windows.Forms.Label b4;
        private System.Windows.Forms.PictureBox meatbox8;
        private System.Windows.Forms.Label s2;
        private System.Windows.Forms.Panel hk1;
        private System.Windows.Forms.PictureBox Goal9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}