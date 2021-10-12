using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_Rough.PresentationLayer
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfor Si = new StudentInfor();
            Si.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modules m = new Modules();
            m.Show();
            this.Hide();
        }
    }
}
