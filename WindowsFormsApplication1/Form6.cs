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
    public partial class Form6 : Form
    {

        manager m;
     public   int p;
    
        public Form6(ref manager man , int x)
        {
            InitializeComponent();
            m = man;

            p = x; 

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form5 f = new Form5(ref m ,p.ToString() );
            f.ShowDialog();
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("please fill all information");
            else
            {

                History s = new History(textBox1.Text,textBox2.Text , textBox3.Text); 
            
                //
                
                m.arr[p].MedicalCase.Push(s);

                //


                m.Saving_Data();


                this.Hide();
                Form5 f = new Form5(ref m, p.ToString());
                f.ShowDialog();
                this.Close();
            
            
            
            
            
            }



        }
    }
}
