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
    public partial class state7 : Form
    {
        public state7()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();

        }
        int status = 1;
        int n = 90;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (meatbox7.Bounds.IntersectsWith(gk1.Bounds))
            {
                meatbox7.Top = 25;
                meatbox7.Left = 25;
            }
            else if (meatbox7.Bounds.IntersectsWith(Goal8.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox7.Top = 25;
                meatbox7.Left = 25;
                state8 a = new state8();
                a.Show();
                this.Hide();


            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //เด้งดึ๋ง
            if (status == 1)
            {
                meatbox7.Image = Properties.Resources.meatcute2;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox7.Image = Properties.Resources.meatcute3;
                status = 1;
            }
            //กำแพง
            if (meatbox7.Bounds.IntersectsWith(fe1.Bounds))
            {
                meatbox7.Top = 25;
                meatbox7.Left = 25;
            }
            else if (meatbox7.Bounds.IntersectsWith(fe2.Bounds))
            {
                meatbox7.Top = 25;
                meatbox7.Left = 25;
            }
            else if (meatbox7.Bounds.IntersectsWith(fe3.Bounds))
            {
                meatbox7.Top = 25;
                meatbox7.Left = 25;
            }
            else if (meatbox7.Bounds.IntersectsWith(fe4.Bounds))
            {
                meatbox7.Top = 25;
                meatbox7.Left = 25;
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
                state7 b = new state7();
                b.Show();
                this.Hide();
            }
            s2.Text = n.ToString();
        }

        private void Form8_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: meatbox7.Top -= 10; break;
                case Keys.Down: meatbox7.Top += 10; break;
                case Keys.Right: meatbox7.Left += 10; break;
                case Keys.Left: meatbox7.Left -= 10; break;

            }

        }
    }
}
