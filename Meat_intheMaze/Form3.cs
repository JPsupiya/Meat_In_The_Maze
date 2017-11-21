using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meat_intheMaze
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void inwall2_Click(object sender, EventArgs e)
        {

        }
        int status=1;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //เด้งดึ๋ง
            if (status == 1)
            {
                meatbox1.Image = Properties.Resources._23584570_1392330420893132_1201545388_n;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox1.Image = Properties.Resources._23635196_1392330424226465_1279969046_n___Copy;
                status = 1;
            }
            //กำแพง
            if (meatbox1.Bounds.IntersectsWith(wall1.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(wall2.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(wall3.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(wall4.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (meatbox1.Bounds.IntersectsWith(ak.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(Goal1.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox1.Top = 25;
                meatbox1.Left = 25;
                Form4 a = new Form4();
                a.Show();
                this.Hide();


            }

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: meatbox1.Top -= 10; break;
                case Keys.Down: meatbox1.Top += 10; break;
                case Keys.Right: meatbox1.Left += 10; break;
                case Keys.Left: meatbox1.Left -= 10; break;
                

            }
            
            
        }
        int n = 90;
        private void timer3_Tick(object sender, EventArgs e)
        {
            

            if (n > 0)
            {
                n--;
            }
            else
            {
                timer3.Stop();
                MessageBox.Show("Time Out!");
                n = 90;
                Game_state1 p = new Game_state1();
                p.Show();
                this.Hide();
            }

            stp.Text = n.ToString();
        }

       
    }
}
    

