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
    public partial class StudentInfor : Form
    {
        public StudentInfor()
        {
            InitializeComponent();
        }


        private void StudentInfor_Load(object sender, EventArgs e)
        {
            
        }
        StudentInformationCRUD Si = new StudentInformationCRUD();
        private void button2_Click(object sender, EventArgs e)
        {
            Si.InsertStudent(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, int.Parse(textBox6.Text), textBox7.Text, textBox8.Text, pictureBox1.Image);
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Si.UpdateStudent(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, int.Parse(textBox6.Text), textBox7.Text, textBox8.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Si.DeleteStudent(int.Parse(textBox9.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Si.SearchStudent(int.Parse(textBox9.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Si.Read();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
