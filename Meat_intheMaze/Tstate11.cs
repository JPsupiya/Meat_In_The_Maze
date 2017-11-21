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
    public partial class Tstate11 : Form
    {
        public Tstate11()
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
                meatbox11.Image = Properties.Resources._23584570_1392330420893132_1201545388_n;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox11.Image = Properties.Resources._23635196_1392330424226465_1279969046_n___Copy;
                status = 1;
            }
            //กำแพง
            if (meatbox11.Bounds.IntersectsWith(e1.Bounds))
            {
                meatbox11.Top = 25;
                meatbox11.Left = 25;
            }
            else if (meatbox11.Bounds.IntersectsWith(e2.Bounds))
            {
                meatbox11.Top = 25;
                meatbox11.Left = 25;
            }
            else if (meatbox11.Bounds.IntersectsWith(e3.Bounds))
            {
                meatbox11.Top = 25;
                meatbox11.Left = 25;
            }
            else if (meatbox11.Bounds.IntersectsWith(e4.Bounds))
            {
                meatbox11.Top = 25;
                meatbox11.Left = 25;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (meatbox11.Bounds.IntersectsWith(kk1.Bounds))
            {
                meatbox11.Top = 25;
                meatbox11.Left = 25;
            }
            else if (meatbox11.Bounds.IntersectsWith(Goal12.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox11.Top = 25;
                meatbox11.Left = 25;
                Tstate11 a = new Tstate11();
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
                Tstate11 b = new Tstate11();
                b.Show();
                this.Hide();
            }
            s5.Text = n.ToString();
        }

        private void Form12_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: meatbox11.Top -= 10; break;
                case Keys.Down: meatbox11.Top += 10; break;
                case Keys.Right: meatbox11.Left += 10; break;
                case Keys.Left: meatbox11.Left -= 10; break;

            }
        }
    }
}
