namespace Meat_intheMaze
{
    partial class Form7
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
            this.f1 = new System.Windows.Forms.Label();
            this.f2 = new System.Windows.Forms.Label();
            this.f3 = new System.Windows.Forms.Label();
            this.f4 = new System.Windows.Forms.Label();
            this.meatbox6 = new System.Windows.Forms.PictureBox();
            this.fk1 = new System.Windows.Forms.Panel();
            this.Goal6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.s = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.meatbox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal6)).BeginInit();
            this.SuspendLayout();
            // 
            // f1
            // 
            this.f1.Location = new System.Drawing.Point(-56, -4);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(1200, 20);
            this.f1.TabIndex = 3;
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(-170, 1019);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(1200, 20);
            this.f2.TabIndex = 4;
            // 
            // f3
            // 
            this.f3.BackColor = System.Drawing.Color.Transparent;
            this.f3.Location = new System.Drawing.Point(-3, -4);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(20, 1000);
            this.f3.TabIndex = 5;
            // 
            // f4
            // 
            this.f4.BackColor = System.Drawing.Color.Transparent;
            this.f4.Location = new System.Drawing.Point(964, -4);
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size(20, 1000);
            this.f4.TabIndex = 6;
            // 
            // meatbox6
            // 
            this.meatbox6.BackColor = System.Drawing.Color.Transparent;
            this.meatbox6.Image = global::Meat_intheMaze.Properties.Resources._23584570_1392330420893132_1201545388_n;
            this.meatbox6.Location = new System.Drawing.Point(23, 29);
            this.meatbox6.Name = "meatbox6";
            this.meatbox6.Size = new System.Drawing.Size(80, 74);
            this.meatbox6.TabIndex = 7;
            this.meatbox6.TabStop = false;
            this.meatbox6.UseWaitCursor = true;
            // 
            // fk1
            // 
            this.fk1.BackColor = System.Drawing.Color.Gray;
            this.fk1.Location = new System.Drawing.Point(67, 156);
            this.fk1.Name = "fk1";
            this.fk1.Size = new System.Drawing.Size(728, 31);
            this.fk1.TabIndex = 8;
            // 
            // Goal6
            // 
            this.Goal6.BackColor = System.Drawing.Color.Transparent;
            this.Goal6.Image = global::Meat_intheMaze.Properties.Resources._1357aee3faada96;
            this.Goal6.Location = new System.Drawing.Point(658, 490);
            this.Goal6.Name = "Goal6";
            this.Goal6.Size = new System.Drawing.Size(300, 300);
            this.Goal6.TabIndex = 9;
            this.Goal6.TabStop = false;
            this.Goal6.UseWaitCursor = true;
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
            // s
            // 
            this.s.BackColor = System.Drawing.Color.WhiteSmoke;
            this.s.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(794, 16);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(164, 38);
            this.s.TabIndex = 10;
            this.s.Text = "90";
            this.s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 1035);
            this.Controls.Add(this.s);
            this.Controls.Add(this.Goal6);
            this.Controls.Add(this.fk1);
            this.Controls.Add(this.meatbox6);
            this.Controls.Add(this.f4);
            this.Controls.Add(this.f3);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.f1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form7_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.meatbox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label f1;
        private System.Windows.Forms.Label f2;
        private System.Windows.Forms.Label f3;
        private System.Windows.Forms.Label f4;
        private System.Windows.Forms.PictureBox meatbox6;
        private System.Windows.Forms.Panel fk1;
        private System.Windows.Forms.PictureBox Goal6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label s;
    }
}