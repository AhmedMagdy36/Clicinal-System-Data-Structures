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
    public partial class Form4 : Form
    {

        manager m; 

        public Form4(ref manager man)
        {
            InitializeComponent();
            m = man; 
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("please enter your ID ");
            else
            {

                if(m.arr.ContainsKey(int.Parse(textBox1.Text)))
                
                {
                    this.Hide();
                    Form5 f = new Form5(ref m , textBox1.Text);
                    f.ShowDialog();
                    this.Close();

                }


                else
                {
                    MessageBox.Show("Sorry wrong ID !! ");
                }
            
            
            
            
            
      
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1(ref m);
            f.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
