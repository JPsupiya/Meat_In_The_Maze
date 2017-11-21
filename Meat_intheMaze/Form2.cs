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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Game_state1 form = new Game_state1();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
