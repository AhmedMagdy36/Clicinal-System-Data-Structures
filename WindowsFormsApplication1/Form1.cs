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
    public partial class Form1 : Form
    {

        manager m; 




        public Form1()
        {
            InitializeComponent();
            m = new manager(); 
        }


        public Form1(ref manager  man)
        {
            InitializeComponent();
            m = man; 
        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();

            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4(ref m);
            f.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f1 = new Form7(ref m);
            this.Hide();
            f1.ShowDialog();
            this.Close();

        }
        
        


    }
}
