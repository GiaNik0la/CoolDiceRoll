using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice
{
    public partial class Form_2 : Form
    {
        public Form_2(string IDK)
        {
            InitializeComponent();
            pictureBox1.ImageLocation = IDK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
