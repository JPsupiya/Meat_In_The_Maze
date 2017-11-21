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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }
        int status = 1;
        int n = 90;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //เด้งดึ๋ง
            if (status == 1)
            {
                meatbox8.Image = Properties.Resources._23584570_1392330420893132_1201545388_n;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox8.Image = Properties.Resources._23635196_1392330424226465_1279969046_n___Copy;
                status = 1;
            }
            //กำแพง
            if (meatbox8.Bounds.IntersectsWith(b1.Bounds))
            {
                meatbox8.Top = 25;
                meatbox8.Left = 25;
            }
            else if (meatbox8.Bounds.IntersectsWith(b2.Bounds))
            {
                meatbox8.Top = 25;
                meatbox8.Left = 25;
            }
            else if (meatbox8.Bounds.IntersectsWith(b3.Bounds))
            {
                meatbox8.Top = 25;
                meatbox8.Left = 25;
            }
            else if (meatbox8.Bounds.IntersectsWith(b4.Bounds))
            {
                meatbox8.Top = 25;
                meatbox8.Left = 25;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (meatbox8.Bounds.IntersectsWith(hk1.Bounds))
            {
                meatbox8.Top = 25;
                meatbox8.Left = 25;
            }
            else if (meatbox8.Bounds.IntersectsWith(Goal9.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox8.Top = 25;
                meatbox8.Left = 25;
                Form10 a = new Form10();
                a.Show();
                this.Hide();


            }
        }

        private void Form9_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: meatbox8.Top -= 10; break;
                case Keys.Down: meatbox8.Top += 10; break;
                case Keys.Right: meatbox8.Left += 10; break;
                case Keys.Left: meatbox8.Left -= 10; break;

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
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Time Out!");
                n = 90;
                Form9 b = new Form9();
                b.Show();
                this.Hide();
            }
            s2.Text = n.ToString();
        }
    }
}
