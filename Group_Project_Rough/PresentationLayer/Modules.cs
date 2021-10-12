using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Project_Rough.BussinessLogicLayer;

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
        ModuleOp Mc = new ModuleOp();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Mc.Viewmod();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mc.searchMod(textBox2.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mc.InsertMod(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mc.updateModule(textBox6.Text, textBox7.Text, textBox8.Text);
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Mc.DeleteMod(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
