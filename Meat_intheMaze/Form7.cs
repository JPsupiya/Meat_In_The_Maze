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
    public partial class Form7 : Form
    {
        public Form7()
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
                meatbox6.Image = Properties.Resources._23584570_1392330420893132_1201545388_n;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox6.Image = Properties.Resources._23635196_1392330424226465_1279969046_n___Copy;
                status = 1;
            }
            //กำแพง
            if (meatbox6.Bounds.IntersectsWith(f1.Bounds))
            {
                meatbox6.Top = 25;
                meatbox6.Left = 25;
            }
            else if (meatbox6.Bounds.IntersectsWith(f2.Bounds))
            {
                meatbox6.Top = 25;
                meatbox6.Left = 25;
            }
            else if (meatbox6.Bounds.IntersectsWith(f3.Bounds))
            {
                meatbox6.Top = 25;
                meatbox6.Left = 25;
            }
            else if (meatbox6.Bounds.IntersectsWith(f4.Bounds))
            {
                meatbox6.Top = 25;
                meatbox6.Left = 25;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (meatbox6.Bounds.IntersectsWith(fk1.Bounds))
            {
                meatbox6.Top = 25;
                meatbox6.Left = 25;
            }
            else if (meatbox6.Bounds.IntersectsWith(Goal6.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox6.Top = 25;
                meatbox6.Left = 25;
                Form8 a = new Form8();
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
                Game_state1 b = new Game_state1();
                b.Show();
                this.Hide();
            }
            s.Text = n.ToString();
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: meatbox6.Top -= 10; break;
                case Keys.Down: meatbox6.Top += 10; break;
                case Keys.Right: meatbox6.Left += 10; break;
                case Keys.Left: meatbox6.Left -= 10; break;

            }

        }
    }
}
