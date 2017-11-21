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
    public partial class Form10 : Form
    {
        public Form10()
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
                meatbox9.Image = Properties.Resources._23584570_1392330420893132_1201545388_n;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox9.Image = Properties.Resources._23635196_1392330424226465_1279969046_n___Copy;
                status = 1;
            }
            //กำแพง
            if (meatbox9.Bounds.IntersectsWith(c1.Bounds))
            {
                meatbox9.Top = 25;
                meatbox9.Left = 25;
            }
            else if (meatbox9.Bounds.IntersectsWith(c2.Bounds))
            {
                meatbox9.Top = 25;
                meatbox9.Left = 25;
            }
            else if (meatbox9.Bounds.IntersectsWith(c3.Bounds))
            {
                meatbox9.Top = 25;
                meatbox9.Left = 25;
            }
            else if (meatbox9.Bounds.IntersectsWith(c4.Bounds))
            {
                meatbox9.Top = 25;
                meatbox9.Left = 25;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (meatbox9.Bounds.IntersectsWith(ik1.Bounds))
            {
                meatbox9.Top = 25;
                meatbox9.Left = 25;
            }
            else if (meatbox9.Bounds.IntersectsWith(Goal10.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox9.Top = 25;
                meatbox9.Left = 25;
                Form11 a = new Form11();
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
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Time Out!");
                n = 90;
                Form10 b = new Form10();
                b.Show();
                this.Hide();
            }
            s3.Text = n.ToString();
        }

        private void Form10_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: meatbox9.Top -= 10; break;
                case Keys.Down: meatbox9.Top += 10; break;
                case Keys.Right: meatbox9.Left += 10; break;
                case Keys.Left: meatbox9.Left -= 10; break;

            }

        }
    }
}
