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
    public partial class Game_state1 : Form
    {
        public Game_state1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            

        }
        int status = 1;
        int n = 90;

        protected void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Up: meatbox.Top -= 10;break;
                case Keys.Down: meatbox.Top += 10; break;
                case Keys.Right: meatbox.Left += 10; break;
                case Keys.Left: meatbox.Left -= 10; break;

            }

        }

        protected void timer1_Tick(object sender, EventArgs e)
        {
            //เด้งดึ๋ง
            if(status == 1)
            {
                meatbox.Image = Properties.Resources.meatcute2;
                status = 2;
            }else if(status == 2)
            {
                meatbox.Image = Properties.Resources.meatcute3;
                status = 1;
            }
            //กำแพง
            if (meatbox.Bounds.IntersectsWith(inwall.Bounds))
            {
                meatbox.Top = 25;
                meatbox.Left = 25;
            }else if (meatbox.Bounds.IntersectsWith(inwall2.Bounds))
            {
                meatbox.Top = 25;
                meatbox.Left = 25;
            }
            else if (meatbox.Bounds.IntersectsWith(inwall3.Bounds))
            {
                meatbox.Top = 25;
                meatbox.Left = 25;
            }
            else if (meatbox.Bounds.IntersectsWith(inwall4.Bounds))
            {
                meatbox.Top = 25;
                meatbox.Left = 25;
            }
        }

        protected void timer2_Tick(object sender, EventArgs e)
        {


            if (meatbox.Bounds.IntersectsWith(ak1.Bounds))
            {
                meatbox.Top = 25;
                meatbox.Left = 25;
            }
            else if (meatbox.Bounds.IntersectsWith(Goal.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox.Top = 25;
                meatbox.Left = 25;
                state2 a = new state2();
                a.Show();
                this.Hide();


            }

        }
        //จับเวลา

        protected void timer3_Tick(object sender, EventArgs e)
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
            stptimr.Text = n.ToString();
        }

        private void Game_state1_Load(object sender, EventArgs e)
        {

        }
    }
}
