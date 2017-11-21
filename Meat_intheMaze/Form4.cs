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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();



        }
        int status = 1;
        int n = 90;

        private void meatbox_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            //เด้งดึ๋ง
            if (status == 1)
            {
                meatbox2.Image = Properties.Resources._23584570_1392330420893132_1201545388_n;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox2.Image = Properties.Resources._23635196_1392330424226465_1279969046_n___Copy;
                status = 1;
            }
            //กำแพง
            if (meatbox2.Bounds.IntersectsWith(w1.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            else if (meatbox2.Bounds.IntersectsWith(w2.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            else if (meatbox2.Bounds.IntersectsWith(w3.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            else if (meatbox2.Bounds.IntersectsWith(w4.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (meatbox2.Bounds.IntersectsWith(ck1.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            else if (meatbox2.Bounds.IntersectsWith(Goal2.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox2.Top = 25;
                meatbox2.Left = 25;
                Form5 a = new Form5();
                a.Show();
                this.Hide();

            }


        }

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
            stpt.Text = n.ToString();
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: meatbox2.Top -= 10; break;
                case Keys.Down: meatbox2.Top += 10; break;
                case Keys.Right: meatbox2.Left += 10; break;
                case Keys.Left: meatbox2.Left -= 10; break;

            }
        }
    }
}
