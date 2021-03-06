﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();

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
                meatbox4.Image = Properties.Resources._23584570_1392330420893132_1201545388_n;
                status = 2;
            }
            else if (status == 2)
            {
                meatbox4.Image = Properties.Resources._23635196_1392330424226465_1279969046_n___Copy;
                status = 1;
            }
            //กำแพง
            if (meatbox4.Bounds.IntersectsWith(fen1.Bounds))
            {
                meatbox4.Top = 25;
                meatbox4.Left = 25;
            }
            else if (meatbox4.Bounds.IntersectsWith(fen2.Bounds))
            {
                meatbox4.Top = 25;
                meatbox4.Left = 25;
            }
            else if (meatbox4.Bounds.IntersectsWith(fen3.Bounds))
            {
                meatbox4.Top = 25;
                meatbox4.Left = 25;
            }
            else if (meatbox4.Bounds.IntersectsWith(fen4.Bounds))
            {
                meatbox4.Top = 25;
                meatbox4.Left = 25;
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
                meatbox4.Top = 25;
                meatbox4.Left = 25;
            }
            else if (meatbox4.Bounds.IntersectsWith(Goal5.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Next state !");
                n = 91;
                meatbox4.Top = 25;
                meatbox4.Left = 25;
                Form7 a = new Form7();
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
            Goal5.Text = n.ToString();
        }
    }
}
