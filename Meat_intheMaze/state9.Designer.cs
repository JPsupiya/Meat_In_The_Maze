namespace Meat_intheMaze
{
    partial class state9
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
            this.c1 = new System.Windows.Forms.Label();
            this.c2 = new System.Windows.Forms.Label();
            this.c3 = new System.Windows.Forms.Label();
            this.c4 = new System.Windows.Forms.Label();
            this.meatbox9 = new System.Windows.Forms.PictureBox();
            this.ik1 = new System.Windows.Forms.Panel();
            this.s3 = new System.Windows.Forms.Label();
            this.Goal10 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.meatbox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal10)).BeginInit();
            this.SuspendLayout();
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(-169, -3);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(1200, 20);
            this.c1.TabIndex = 5;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(-196, 1017);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(1200, 20);
            this.c2.TabIndex = 6;
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.Color.Transparent;
            this.c3.Location = new System.Drawing.Point(0, -3);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(22, 1040);
            this.c3.TabIndex = 7;
            // 
            // c4
            // 
            this.c4.BackColor = System.Drawing.Color.Transparent;
            this.c4.Location = new System.Drawing.Point(960, -3);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(22, 1040);
            this.c4.TabIndex = 8;
            // 
            // meatbox9
            // 
            this.meatbox9.BackColor = System.Drawing.Color.Transparent;
            this.meatbox9.Image = global::Meat_intheMaze.Properties.Resources._23584570_1392330420893132_1201545388_n;
            this.meatbox9.Location = new System.Drawing.Point(28, 20);
            this.meatbox9.Name = "meatbox9";
            this.meatbox9.Size = new System.Drawing.Size(80, 74);
            this.meatbox9.TabIndex = 9;
            this.meatbox9.TabStop = false;
            this.meatbox9.UseWaitCursor = true;
            // 
            // ik1
            // 
            this.ik1.BackColor = System.Drawing.Color.Gray;
            this.ik1.Location = new System.Drawing.Point(44, 134);
            this.ik1.Name = "ik1";
            this.ik1.Size = new System.Drawing.Size(728, 31);
            this.ik1.TabIndex = 11;
            // 
            // s3
            // 
            this.s3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.s3.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s3.Location = new System.Drawing.Point(790, 20);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(164, 38);
            this.s3.TabIndex = 12;
            this.s3.Text = "90";
            this.s3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Goal10
            // 
            this.Goal10.BackColor = System.Drawing.Color.Transparent;
            this.Goal10.Image = global::Meat_intheMaze.Properties.Resources._1357aee3faada96;
            this.Goal10.Location = new System.Drawing.Point(602, 521);
            this.Goal10.Name = "Goal10";
            this.Goal10.Size = new System.Drawing.Size(300, 300);
            this.Goal10.TabIndex = 13;
            this.Goal10.TabStop = false;
            this.Goal10.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 215;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 800;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 1035);
            this.Controls.Add(this.Goal10);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.ik1);
            this.Controls.Add(this.meatbox9);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form10";
            this.Text = "Meat_In_TheMaze State9";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form10_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.meatbox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goal10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label c1;
        private System.Windows.Forms.Label c2;
        private System.Windows.Forms.Label c3;
        private System.Windows.Forms.Label c4;
        private System.Windows.Forms.PictureBox meatbox9;
        private System.Windows.Forms.Panel ik1;
        private System.Windows.Forms.Label s3;
        private System.Windows.Forms.PictureBox Goal10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}