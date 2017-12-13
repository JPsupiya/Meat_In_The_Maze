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
    public partial class state5 : Form
    {
        public state5()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            box.Start();
            down55.Start();
            pinkpink.Start();

        }
        int status = 1;
        int n = 90;

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //เด้งดึ๋ง
            if (status == 1)
            {
                meatbox4.Image = Properties.Resources.meatcute3;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox4.Image = Properties.Resources.meatcute4;
                status = 1;
            }
            //กำแพง
            if (meatbox4.Bounds.IntersectsWith(fen1.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(fen2.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(fen3.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(fen4.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }

            else if (meatbox4.Bounds.IntersectsWith(t5.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;//LR
            }
            else if (meatbox4.Bounds.IntersectsWith(t6.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t7.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t8.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t9.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
             else if (meatbox4.Bounds.IntersectsWith(t10.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t11.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t12.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t13.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t14.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t15.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t16.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t17.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t1.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t2.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t3.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t4.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(t19.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: meatbox4.Top -= 10; break;
                case Keys.Down: meatbox4.Top += 10; break;
                case Keys.Right: meatbox4.Left += 10; break;
                case Keys.Left: meatbox4.Left -= 10; break;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (meatbox4.Bounds.IntersectsWith(ek1.Bounds))
            {
                meatbox4.Top = 580;
                meatbox4.Left = 660;
            }
            else if (meatbox4.Bounds.IntersectsWith(Goal5.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox4.Top = 580;
                meatbox4.Left = 660;
                state6 a = new state6();
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
                timer2.Stop();
                MessageBox.Show("Time Out!");
                n = 90;
                state4 b = new state4();
                b.Show();
                this.Hide();
            }
            stptimr.Text = n.ToString();
        }

         int r = 10;
        int o = 3;
        int b = 30;
        int i = 10;
        int x = 25;
       
        private void box_Tick(object sender, EventArgs e)
        {
           
                t2.Left += r;
                if (t2.Bounds.IntersectsWith(t1.Bounds))
                {
                    r = -r;


                }
                else if (t2.Bounds.IntersectsWith(t4.Bounds))
                {
                    r = -r;

                }

            t8.Left += o;
            if (t8.Bounds.IntersectsWith(t7.Bounds))
            {
                o = -o;


            }
            else if (t8.Bounds.IntersectsWith(t6.Bounds))
            {
                o = -o;

            }

            t9.Left +=b;
            if (t9.Bounds.IntersectsWith(fen3.Bounds))
            {
                b = -b;


            }
            else if (t9.Bounds.IntersectsWith(t10.Bounds))
            {
                b = -b;

            }
            t11.Left += i;
            if (t11.Bounds.IntersectsWith(fen3.Bounds))
            {
                i = -i;


            }
            else if (t11.Bounds.IntersectsWith(fen4.Bounds))
            {
                i = -i;

            }
            t12.Left += x;
            if (t12.Bounds.IntersectsWith(fen4.Bounds))
            {
                x = -x;


            }
            else if (t12.Bounds.IntersectsWith(fen3.Bounds))
            {
                x = -x;

            }


        }
        int m = 5;
        int s = 5;
        private void down55_Tick(object sender, EventArgs e)
        {
            t16.Top += m;
            t17.Top += m;
           
            if (t16.Bounds.IntersectsWith(fen1.Bounds) || t17.Bounds.IntersectsWith(fen1.Bounds) )
            {
                m = -m;


            }
            else if (t16.Bounds.IntersectsWith(fen2.Bounds) || t17.Bounds.IntersectsWith(fen2.Bounds) )
            {
                m = -m;


            }


            t16.Top += s;
            t17.Top += s;

            if (t16.Bounds.IntersectsWith(fen1.Bounds) || t17.Bounds.IntersectsWith(fen1.Bounds))
            {
                s = -s;


            }
            else if (t16.Bounds.IntersectsWith(fen2.Bounds) || t17.Bounds.IntersectsWith(fen2.Bounds))
            {
                s = -s;


            }
        }

        private void pinkpink_Tick(object sender, EventArgs e)
        {

            if (status == 1)
            {
                Goal5.Image = Properties.Resources.cage2;
                status = 2;
            }
            else if (status == 2)
            {
                Goal5.Image = Properties.Resources.cage;
                status = 1;
            }
        }
    }
}
