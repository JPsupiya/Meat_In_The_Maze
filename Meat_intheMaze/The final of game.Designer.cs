namespace Meat_intheMaze
{
    partial class The_final_of_game
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
            this.red = new System.Windows.Forms.Timer(this.components);
            this.pink = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.Box1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).BeginInit();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.Interval = 300;
            this.red.Tick += new System.EventHandler(this.red_Tick);
            // 
            // pink
            // 
            this.pink.Interval = 300;
            this.pink.Tick += new System.EventHandler(this.pink_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Meat_intheMaze.Properties.Resources.PNGPIX_COM_Heart_PNG_Transparent_Image_500x2941;
            this.pictureBox1.Location = new System.Drawing.Point(148, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 138);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // box2
            // 
            this.box2.Image = global::Meat_intheMaze.Properties.Resources.meatcuteM32;
            this.box2.Location = new System.Drawing.Point(309, 203);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(68, 55);
            this.box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.box2.TabIndex = 1;
            this.box2.TabStop = false;
            // 
            // Box1
            // 
            this.Box1.Image = global::Meat_intheMaze.Properties.Resources.meatcute3;
            this.Box1.Location = new System.Drawing.Point(182, 198);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(60, 60);
            this.Box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Box1.TabIndex = 0;
            this.Box1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Moccasin;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(26, 298);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(511, 180);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "\r\nข้าขอบใจเจ้ามากที่ช่วยแฟนของข้าออกมาได้ ...\r\nเจ้ามีความอดทนสูงมากๆ ถึงแม้บางครั" +
    "้งเจ้าจะหัวร้อนก้อตาม 5555 \r\nยังไงก้อขอบใจเจ้ามาก... ข้าไปล่ะ ขอให้เจ้าสมหวังกับ" +
    "ความหวังเหมือนข้านะ ฮร่าา**";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // The_final_of_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(582, 503);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.Box1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "The_final_of_game";
            this.Text = "The_final_of_game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Box1;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.Timer red;
        private System.Windows.Forms.Timer pink;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}