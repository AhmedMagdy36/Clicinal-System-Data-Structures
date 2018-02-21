using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        public manager m;



        public Form2()
        {
            InitializeComponent();
            m = new manager(); 
        }

        private void Information_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                MessageBox.Show("please fill all information ");

           
            else
            {

                m.Append(this.textBox1.Text, int.Parse(this.textBox2.Text), this.textBox3.Text, this.textBox4.Text, this.textBox5.Text, this.textBox6.Text, this.textBox7.Text);
                m.Saving_Data();
                string str = ("patient ID is : ");
                str += (m.ID-1).ToString();
                MessageBox.Show(str);
                this.Hide();
                Form1 f = new Form1(ref m);
                f.ShowDialog();
                this.Close();
            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1(ref m);
            f.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
