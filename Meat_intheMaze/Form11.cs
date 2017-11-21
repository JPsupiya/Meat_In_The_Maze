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
    public partial class Form11 : Form
    {
        public Form11()
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
                meatbox10.Image = Properties.Resources._23584570_1392330420893132_1201545388_n;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox10.Image = Properties.Resources._23635196_1392330424226465_1279969046_n___Copy;
                status = 1;
            }
            //กำแพง
            if (meatbox10.Bounds.IntersectsWith(d1.Bounds))
            {
                meatbox10.Top = 25;
                meatbox10.Left = 25;
            }
            else if (meatbox10.Bounds.IntersectsWith(d2.Bounds))
            {
                meatbox10.Top = 25;
                meatbox10.Left = 25;
            }
            else if (meatbox10.Bounds.IntersectsWith(d3.Bounds))
            {
                meatbox10.Top = 25;
                meatbox10.Left = 25;
            }
            else if (meatbox10.Bounds.IntersectsWith(d4.Bounds))
            {
                meatbox10.Top = 25;
                meatbox10.Left = 25;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (meatbox10.Bounds.IntersectsWith(jk1.Bounds))
            {
                meatbox10.Top = 25;
                meatbox10.Left = 25;
            }
            else if (meatbox10.Bounds.IntersectsWith(Goal11.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox10.Top = 25;
                meatbox10.Left = 25;
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
            s4.Text = n.ToString();
        }

        private void Form11_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: meatbox10.Top -= 10; break;
                case Keys.Down: meatbox10.Top += 10; break;
                case Keys.Right: meatbox10.Left += 10; break;
                case Keys.Left: meatbox10.Left -= 10; break;

            }
        }
    }
}
