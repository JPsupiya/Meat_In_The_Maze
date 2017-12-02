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
    public partial class state2 : Form
    {
        public state2()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void inwall2_Click(object sender, EventArgs e)
        {

        }
        int status = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //เด้งดึ๋ง
            if (status == 1)
            {
                meatbox1.Image = Properties.Resources.meatcute3;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox1.Image = Properties.Resources.meatcute4;
                status = 1;
            }
            //กำแพง
            if (meatbox1.Bounds.IntersectsWith(wall1.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(wall2.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(wall3.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(wall4.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
             

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (meatbox1.Bounds.IntersectsWith(bk1.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            
            else if (meatbox1.Bounds.IntersectsWith(bk2.Bounds))
            {
                timer2.Stop();
                bk2.Image = Properties.Resources.ghost55555;
                MessageBox.Show("เ_ย ผีหลอก!! หนีแปป");
                meatbox1.Top = 25;
                meatbox1.Left = 25;
                timer2.Start();
            }
            else if (meatbox1.Bounds.IntersectsWith(bk4.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(bk5.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(bk6.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(bk7.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(bk10.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(bk11.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(bk12.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(bk15.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(bk15.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(bk16.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(bk17.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(bk19.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(bk20.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }
            else if (meatbox1.Bounds.IntersectsWith(bk9.Bounds))
            {
                timer2.Stop();
                bk9.Image = Properties.Resources.wire1;
                MessageBox.Show("คุณโดนหนาม ชึ้ก!!!! ตายแปป");
                meatbox1.Top = 25;
                meatbox1.Left = 25;
                timer2.Start();
            }
            else if (meatbox1.Bounds.IntersectsWith(mmg.Bounds))
            {
                meatbox1.Top = 25;
                meatbox1.Left = 25;
            }

            else if (meatbox1.Bounds.IntersectsWith(Goal1.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox1.Top = 25;
                meatbox1.Left = 25;
                state3 a = new state3();
                a.Show();
                this.Hide();


            }

        }

        
        int n = 90;
        private void timer3_Tick(object sender, EventArgs e)
        {
            

            
        }

        private void state2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: meatbox1.Top -= 10; break;
                case Keys.Down: meatbox1.Top += 10; break;
                case Keys.Right: meatbox1.Left += 10; break;
                case Keys.Left: meatbox1.Left -= 10; break;


            }
        }
        int a = 8;
        private void ghost_Tick(object sender, EventArgs e)
        {
            mmg.Left += a;
            if (mmg.Bounds.IntersectsWith(bk21.Bounds))
            {
                a = -a;
            }else if (mmg.Bounds.IntersectsWith(bk17.Bounds))
            {
                a = -a;
            }

       
        }

        private void timer3_Tick_1(object sender, EventArgs e)
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
                Game_state1 p = new Game_state1();
                p.Show();
                this.Hide();
            }



            stp.Text = n.ToString();
        }
    }
}
    

