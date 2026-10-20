using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool warning = true;
            for (int i = 0; i < Class1.User.Length; i++)
            {
                if (textBox1.Text == Class1.User[i]) { textBox1.Text = Class1.usert; break; warning = false; }
            }
            if (warning == true)
            {
                MessageBox.Show("Username already in use");
            }

        }
    }
}
