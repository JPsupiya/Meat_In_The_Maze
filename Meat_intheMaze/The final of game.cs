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
    public partial class The_final_of_game : Form
    {
        public The_final_of_game()
        {
            InitializeComponent();

           red.Start();
           pink.Start();
        }


        int status = 1;


        private void red_Tick(object sender, EventArgs e)
        {
            if (status == 1)
            {
                Box1.Image = Properties.Resources.meatcute3;
                status = 2;
            }
            else if (status == 2)
            {
               Box1.Image = Properties.Resources.meatcute4;
                status = 1;
            }
        }
        int status1 = 1;
        private void pink_Tick(object sender, EventArgs e)
        {
            if (status1 == 1)
            {
                box2.Image = Properties.Resources.meatcuteM4;
                status1 = 2;
            }
            else if (status1 == 2)
            {
                box2.Image = Properties.Resources.meatcute4;
                status1 = 1;
            }
        }
    }
}
