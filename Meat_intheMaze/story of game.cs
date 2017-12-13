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
    public partial class story_of_game : Form
    {
        public story_of_game()
        {
            InitializeComponent();
            I.Start();
            pink.Start();

        }
        int status = 1;

        private void I_Tick(object sender, EventArgs e)
        {
            if (status == 1)
            {
                Im.Image = Properties.Resources.meatcute3;
                status = 2;
            }
            else if (status == 2)
            {
                Im.Image = Properties.Resources.meatcute4;
                status = 1;
            }

            if (status == 1)
            {
                pin.Image = Properties.Resources.cage2;
                status = 2;
            }
            else if (status == 2)
            {
                pin.Image = Properties.Resources.cage;
                status = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Game_state1 a = new Game_state1();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game_state1 a = new Game_state1();
            a.Show();
            this.Hide();
        }
    }
}
