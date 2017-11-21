namespace Meat_intheMaze
{
    partial class Form12
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
            this.e1 = new System.Windows.Forms.Label();
            this.e2 = new System.Windows.Forms.Label();
            this.e3 = new System.Windows.Forms.Label();
            this.e4 = new System.Windows.Forms.Label();
            this.meatbox11 = new System.Windows.Forms.PictureBox();
            this.kk1 = new System.Windows.Forms.Panel();
            this.s5 = new System.Windows.Forms.Label();
            this.Goal12 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.meatbox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal12)).BeginInit();
            this.SuspendLayout();
            // 
            // e1
            // 
            this.e1.Location = new System.Drawing.Point(-60, -1);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(1200, 20);
            this.e1.TabIndex = 7;
            // 
            // e2
            // 
            this.e2.Location = new System.Drawing.Point(-178, 1019);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(1200, 20);
            this.e2.TabIndex = 8;
            // 
            // e3
            // 
            this.e3.BackColor = System.Drawing.Color.Transparent;
            this.e3.Location = new System.Drawing.Point(-4, -1);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(22, 1040);
            this.e3.TabIndex = 9;
            // 
            // e4
            // 
            this.e4.BackColor = System.Drawing.Color.Transparent;
            this.e4.Location = new System.Drawing.Point(960, -1);
            this.e4.Name = "e4";
            this.e4.Size = new System.Drawing.Size(22, 1040);
            this.e4.TabIndex = 10;
            // 
            // meatbox11
            // 
            this.meatbox11.BackColor = System.Drawing.Color.Transparent;
            this.meatbox11.Image = global::Meat_intheMaze.Properties.Resources._23584570_1392330420893132_1201545388_n;
            this.meatbox11.Location = new System.Drawing.Point(24, 22);
            this.meatbox11.Name = "meatbox11";
            this.meatbox11.Size = new System.Drawing.Size(80, 74);
            this.meatbox11.TabIndex = 11;
            this.meatbox11.TabStop = false;
            this.meatbox11.UseWaitCursor = true;
            // 
            // kk1
            // 
            this.kk1.BackColor = System.Drawing.Color.Gray;
            this.kk1.Location = new System.Drawing.Point(75, 164);
            this.kk1.Name = "kk1";
            this.kk1.Size = new System.Drawing.Size(728, 31);
            this.kk1.TabIndex = 13;
            // 
            // s5
            // 
            this.s5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.s5.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s5.Location = new System.Drawing.Point(790, 22);
            this.s5.Name = "s5";
            this.s5.Size = new System.Drawing.Size(164, 38);
            this.s5.TabIndex = 14;
            this.s5.Text = "90";
            this.s5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Goal12
            // 
            this.Goal12.BackColor = System.Drawing.Color.Transparent;
            this.Goal12.Image = global::Meat_intheMaze.Properties.Resources._1357aee3faada96;
            this.Goal12.Location = new System.Drawing.Point(602, 642);
            this.Goal12.Name = "Goal12";
            this.Goal12.Size = new System.Drawing.Size(300, 300);
            this.Goal12.TabIndex = 15;
            this.Goal12.TabStop = false;
            this.Goal12.UseWaitCursor = true;
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
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 1035);
            this.Controls.Add(this.Goal12);
            this.Controls.Add(this.s5);
            this.Controls.Add(this.kk1);
            this.Controls.Add(this.meatbox11);
            this.Controls.Add(this.e4);
            this.Controls.Add(this.e3);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.e1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form12";
            this.Text = "Form12";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form12_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.meatbox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.Label e2;
        private System.Windows.Forms.Label e3;
        private System.Windows.Forms.Label e4;
        private System.Windows.Forms.PictureBox meatbox11;
        private System.Windows.Forms.Panel kk1;
        private System.Windows.Forms.Label s5;
        private System.Windows.Forms.PictureBox Goal12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}