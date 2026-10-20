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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool deny = false;

            for (int i = 0; i < Class1.User.Length; i++)
            {
                if (Class1.User[i] == textBox1.Text) { deny = true; }

            } 
            if (deny == true) { MessageBox.Show("Username is already in use."); }
            else
            {
                Class1.User[Class1.conta] = textBox1.Text;
                Class1.Password[Class1.conta] = textBox2.Text;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
