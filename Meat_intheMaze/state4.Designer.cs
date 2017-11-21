namespace Meat_intheMaze
{
    partial class state4
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
            this.fence1 = new System.Windows.Forms.Label();
            this.fence2 = new System.Windows.Forms.Label();
            this.fence3 = new System.Windows.Forms.Label();
            this.fence4 = new System.Windows.Forms.Label();
            this.meatbox3 = new System.Windows.Forms.PictureBox();
            this.str11 = new System.Windows.Forms.Label();
            this.Goal4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.dk1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.meatbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal4)).BeginInit();
            this.SuspendLayout();
            // 
            // fence1
            // 
            this.fence1.Location = new System.Drawing.Point(-81, 0);
            this.fence1.Name = "fence1";
            this.fence1.Size = new System.Drawing.Size(1200, 20);
            this.fence1.TabIndex = 3;
            // 
            // fence2
            // 
            this.fence2.Location = new System.Drawing.Point(-98, 1019);
            this.fence2.Name = "fence2";
            this.fence2.Size = new System.Drawing.Size(1200, 20);
            this.fence2.TabIndex = 4;
            // 
            // fence3
            // 
            this.fence3.BackColor = System.Drawing.Color.Transparent;
            this.fence3.Location = new System.Drawing.Point(-2, 0);
            this.fence3.Name = "fence3";
            this.fence3.Size = new System.Drawing.Size(23, 1039);
            this.fence3.TabIndex = 5;
            // 
            // fence4
            // 
            this.fence4.BackColor = System.Drawing.Color.Transparent;
            this.fence4.Location = new System.Drawing.Point(959, 0);
            this.fence4.Name = "fence4";
            this.fence4.Size = new System.Drawing.Size(23, 1039);
            this.fence4.TabIndex = 6;
            // 
            // meatbox3
            // 
            this.meatbox3.BackColor = System.Drawing.Color.Transparent;
            this.meatbox3.Image = global::Meat_intheMaze.Properties.Resources._23584570_1392330420893132_1201545388_n;
            this.meatbox3.Location = new System.Drawing.Point(27, 23);
            this.meatbox3.Name = "meatbox3";
            this.meatbox3.Size = new System.Drawing.Size(80, 74);
            this.meatbox3.TabIndex = 7;
            this.meatbox3.TabStop = false;
            this.meatbox3.UseWaitCursor = true;
            // 
            // str11
            // 
            this.str11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.str11.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.str11.Location = new System.Drawing.Point(789, 23);
            this.str11.Name = "str11";
            this.str11.Size = new System.Drawing.Size(164, 38);
            this.str11.TabIndex = 8;
            this.str11.Text = "90";
            this.str11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Goal4
            // 
            this.Goal4.BackColor = System.Drawing.Color.Transparent;
            this.Goal4.Image = global::Meat_intheMaze.Properties.Resources._1357aee3faada96;
            this.Goal4.Location = new System.Drawing.Point(613, 519);
            this.Goal4.Name = "Goal4";
            this.Goal4.Size = new System.Drawing.Size(300, 300);
            this.Goal4.TabIndex = 9;
            this.Goal4.TabStop = false;
            this.Goal4.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 240;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // dk1
            // 
            this.dk1.BackColor = System.Drawing.Color.Gray;
            this.dk1.Location = new System.Drawing.Point(27, 131);
            this.dk1.Name = "dk1";
            this.dk1.Size = new System.Drawing.Size(728, 31);
            this.dk1.TabIndex = 10;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 1037);
            this.Controls.Add(this.dk1);
            this.Controls.Add(this.Goal4);
            this.Controls.Add(this.str11);
            this.Controls.Add(this.meatbox3);
            this.Controls.Add(this.fence4);
            this.Controls.Add(this.fence3);
            this.Controls.Add(this.fence2);
            this.Controls.Add(this.fence1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form5";
            this.Text = "Meat_In_TheMaze State4";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form5_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.meatbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fence1;
        private System.Windows.Forms.Label fence2;
        private System.Windows.Forms.Label fence3;
        private System.Windows.Forms.Label fence4;
        private System.Windows.Forms.PictureBox meatbox3;
        private System.Windows.Forms.Label str11;
        private System.Windows.Forms.PictureBox Goal4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel dk1;
    }
}