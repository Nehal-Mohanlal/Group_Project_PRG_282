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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group_Project_Rough.DataAccessLayer.FileHandler fh = new DataAccessLayer.FileHandler();
           bool userCh= fh.ValidateUser(textBox1.Text, textBox2.Text);
            if (userCh == true)
            {

                MessageBox.Show("Welcome " + textBox1.Text);
                Menu m = new Menu();
                m.Show();
                this.Hide();

            }
            else {
                MessageBox.Show("Incorrect Details, Please Retry");
                textBox1.Clear();
                textBox2.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }
    }
}
