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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            timer1.Start();
            timer2.Start();
            timer3.Start();

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
                Game_state1 b = new Game_state1();
                b.Show();
                this.Hide();
                
            }
            str11.Text = n.ToString();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {

            if (meatbox3.Bounds.IntersectsWith(dk1.Bounds))
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
                Form6 a = new Form6();
                a.Show();
                this.Hide();
                



            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            //เด้งดึ๋ง
            if (status == 1)
            {
                meatbox3.Image = Properties.Resources._23584570_1392330420893132_1201545388_n;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox3.Image = Properties.Resources._23635196_1392330424226465_1279969046_n___Copy;
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
        }
    }
}
