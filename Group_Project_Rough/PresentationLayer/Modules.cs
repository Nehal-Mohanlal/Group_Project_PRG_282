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
    public partial class Modules : Form
    {
        public Modules()
        {
            InitializeComponent();
        }

        private void Modules_Load(object sender, EventArgs e)
        {
            
        }
        ModuleCRUD Mc = new ModuleCRUD();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Mc.ViewModules();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mc.searchModule(textBox2.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mc.InsertModules(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mc.updateModule(textBox6.Text, textBox7.Text, textBox8.Text);
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Mc.DeleteModules(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
