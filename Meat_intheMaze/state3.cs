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
    public partial class state3 : Form
    {
        public state3()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            piramid.Start();
            sfing.Start();



        }
        int status = 1;
        int n = 90;

        private void meatbox_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            //เด้งดึ๋ง
            if (status == 1)
            {
                meatbox2.Image = Properties.Resources.meatcute3;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox2.Image = Properties.Resources.meatcute4;
                status = 1;
            }
            //กำแพง
            if (meatbox2.Bounds.IntersectsWith(w1.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            else if (meatbox2.Bounds.IntersectsWith(w2.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            else if (meatbox2.Bounds.IntersectsWith(w3.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            else if (meatbox2.Bounds.IntersectsWith(w4.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            else if (meatbox2.Bounds.IntersectsWith(dk4.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                
                MessageBox.Show("โดนฟาโรห์ตัวปลอมฆ่าได้ไงเนี่ย ช่างโง่เสียนี่กระไร ลาก่อย");
                meatbox2.Top = 25;
                meatbox2.Left = 25;
                timer1.Start();
                timer2.Start();
               
            }
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (meatbox2.Bounds.IntersectsWith(dk1.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            else if (meatbox2.Bounds.IntersectsWith(dk2.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk5.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk6.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk7.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk10.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk11.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk12.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk30.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk14.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk17.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk16.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                dk16.Image = Properties.Resources.snake;
                
                MessageBox.Show("เคราะซ้ำกรรมซัด เจ้าโดนงูกัดตาย TT");
                
                meatbox2.Top = 25;
                meatbox2.Left = 25;
                timer1.Start();
                timer2.Start();
                timer3.Start();
            }
            /*if (meatbox2.Bounds.IntersectsWith(dk15.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                piramid.Stop();

               

                MessageBox.Show("ดีใจด้วย สมบัติของเจ้าคือ เจ้าได้มีชีวิตรอด55555");

               
                timer1.Start();
                timer2.Start();
                timer3.Start();
            }*/

            if (meatbox2.Bounds.IntersectsWith(dk18.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("ข้าไม่ได้ถามรหัสวิชา ข้าถามเป็นรหัสแอสกี้ oop มันถูกแล้ว!!!");
                meatbox2.Top = 25;
                meatbox2.Left = 25;
                timer1.Start();
                timer2.Start();
                timer3.Start();
            }
            if (meatbox2.Bounds.IntersectsWith(dk19.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk20.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk21.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk22.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk23.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
            if (meatbox2.Bounds.IntersectsWith(dk24.Bounds))
            {
                meatbox2.Top = 25;
                meatbox2.Left = 25;
            }
           

            else if (meatbox2.Bounds.IntersectsWith(Goal2.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox2.Top = 25;
                meatbox2.Left = 25;
                state4 a = new state4();
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
                MessageBox.Show("Time Out!");
                n = 90;
                state2 p = new  state2();
                p.Show();
                this.Hide();
            }
            stpt.Text = n.ToString();
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: meatbox2.Top -= 10; break;
                case Keys.Down: meatbox2.Top += 10; break;
                case Keys.Right: meatbox2.Left += 10; break;
                case Keys.Left: meatbox2.Left -= 10; break;

            }
        }
        int p = 10;
        private void piramid_Tick(object sender, EventArgs e)
        {
            if (meatbox2.Bounds.IntersectsWith(dk3.Bounds))
            {
                dk3.Left += p;
                if (dk3.Bounds.IntersectsWith(panel1.Bounds))
                {
                    p = -p;
                }
                else if (dk3.Bounds.IntersectsWith(panel2.Bounds))
                {
                    p = -p;
                }
            }
        }

        private void sfing_Tick(object sender, EventArgs e)
        {
            if (meatbox2.Bounds.IntersectsWith(dk13.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                sfing.Stop();


                MessageBox.Show("วิชาOOPรหัส 6F6F70ใช่ไหม ถ้าใช่ทะลุกำแพง S ไปนะ ถ้าไม่ใช่ให้วิ่งทะลุผ่านแพง R");
                dk13.Hide();
                /*if (meatbox2.Bounds.IntersectsWith(dk18.Bounds))
                {
                    MessageBox.Show("ข้าไม่ได้ถามรหัสวิชา ข้าถามเป็นรหัสแอสกี้ มันถูกแล้ว!!!");
                };*/

                    timer1.Start();
                    timer2.Start();
                
              //  sfing.Start();
            }
           
        }
    }
}
