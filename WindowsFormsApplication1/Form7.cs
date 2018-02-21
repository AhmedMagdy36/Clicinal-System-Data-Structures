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
    public partial class Form7 : Form
    {
        manager m;


        public Form7(ref  manager man)
        {
            InitializeComponent();
            m = man; 
        }

        private void submit_Click(object sender, EventArgs e)
        {
            
                if(m.arr.ContainsKey(int.Parse(textBox1.Text)))
                {
                    m.arr.Remove(int.Parse(textBox1.Text)) ; 
                    MessageBox.Show("The patient has been deleted") ; 
                    m.num_patients-- ; 
                    m.Saving_Data();
               
                
                }
                    
                else
                {
                    MessageBox.Show("sorry wrong iD") ; 
                
                }


               

            }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1(ref m);
            f.ShowDialog();
            this.Close();
        
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }






        
    }
}


