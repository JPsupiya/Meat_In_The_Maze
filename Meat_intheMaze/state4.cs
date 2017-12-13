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
    public partial class state4 : Form
    {
        public state4()
        {
            InitializeComponent();

            timer1.Start();
            timer2.Start();
            timer3.Start();
            fire.Start();
            box.Start();


        }

        int status = 1;
        int n = 90;
        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: meatbox3.Top -= 10; break;
                case Keys.Down: meatbox3.Top += 10; break;
                case Keys.Right: meatbox3.Left += 10; break;
                case Keys.Left: meatbox3.Left -= 10; break;

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
                state3 b = new state3();
                b.Show();
                this.Hide();

            }
            str11.Text = n.ToString();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {

            if (meatbox3.Bounds.IntersectsWith(w5.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(Goal4.Bounds))
            {
                timer3.Stop();
                timer2.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox3.Top = 25;
                meatbox3.Left = 25;
                state5 a = new state5();
                a.Show();
                this.Hide();




            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            //เด้งดึ๋ง
            if (status == 1)
            {
                meatbox3.Image = Properties.Resources.meatcute3;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox3.Image = Properties.Resources.meatcute4;
                status = 1;
            }
            //กำแพง
            if (meatbox3.Bounds.IntersectsWith(fence1.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(fence2.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(fence3.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(fence4.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(w1.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(w2.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(w3.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(w4.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(w5.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(w6.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(w7.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(ek19.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(ek20.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(q2.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(protect1.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(protect2.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(protect3.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(protect4.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
            else if (meatbox3.Bounds.IntersectsWith(tim.Bounds))
            {
                meatbox3.Top = 25;
                meatbox3.Left = 25;
            }
        }

        private void ek3_Click(object sender, EventArgs e)
        {

        }
        int c = 20;
        int d = 20;

        private void fire_Tick(object sender, EventArgs e)
        {
            ek19.Left += c;
            ek20.Left -= d;

            if (ek19.Bounds.IntersectsWith(fence3.Bounds))
            {
                c = -c;
            }
            else if (ek19.Bounds.IntersectsWith(fence4.Bounds))
            {
                c = -c;
            }

            if (ek20.Bounds.IntersectsWith(fence3.Bounds))
            {
                d = -d;
            }
            else if (ek20.Bounds.IntersectsWith(fence4.Bounds))
            {
                d = -d;
            }


        }


        int f = 20;
        private void m795_Tick(object sender, EventArgs e)
        {
            q2.Left += f;
            if (q2.Bounds.IntersectsWith(fence3.Bounds))
            {
                f = -f;
                q2.Image = Properties.Resources.tr;

            }
            else if (q2.Bounds.IntersectsWith(fence5.Bounds))
            {
                f = -f;
                q2.Image = Properties.Resources.tl;

            }
        }
        int z = 5;
        int u = 5;
        private void box_Tick(object sender, EventArgs e)
        {
            w2.Top += z;
            w4.Top += z;
            w6.Top += z;

            if (w2.Bounds.IntersectsWith(fence1.Bounds)|| w4.Bounds.IntersectsWith(fence1.Bounds) || w6.Bounds.IntersectsWith(fence1.Bounds) )
            {
                z = -z;


            }
            else if (w2.Bounds.IntersectsWith(fence6.Bounds) || w4.Bounds.IntersectsWith(fence6.Bounds) || w6.Bounds.IntersectsWith(fence6.Bounds))
            {
                z = -z;


            }
            
            w3.Top -= u;
            w5.Top -= u;
            w7.Top -= u;

            if ( w3.Bounds.IntersectsWith(fence1.Bounds) || w5.Bounds.IntersectsWith(fence1.Bounds)|| w7.Bounds.IntersectsWith(fence1.Bounds))
            {
                u = -u;


            }
            else if ( w3.Bounds.IntersectsWith(fence6.Bounds) || w5.Bounds.IntersectsWith(fence6.Bounds) || w7.Bounds.IntersectsWith(fence6.Bounds))
            {
                u = -u;


            }
        }
    }
}
    


