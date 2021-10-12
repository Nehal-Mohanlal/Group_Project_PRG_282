using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Project_Rough.DataAccessLayer;

namespace Group_Project_Rough.PresentationLayer
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileHandler fh = new FileHandler();
            bool us=fh.addUser(textBox1.Text,textBox2.Text);
            if (us == true)
            {

                MessageBox.Show("User added successfully - Username:" + textBox1.Text + ", Password:" + textBox2.Text);
                Login l = new Login();
                l.Show();
                this.Hide();

            }
            else { MessageBox.Show("Unsuccesful"); }

        }
    }
}
