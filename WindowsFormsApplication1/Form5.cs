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
    public partial class Form5 : Form
    {

        manager m;

        NewPatient temp;

        Queue<History> st;

        Queue<History> q = new Queue<History>();

        bool f; 


        public Form5(ref manager man , string s)
        {
            InitializeComponent();

            m = man;

            int x = int.Parse(s);

            //

            temp = m.arr[x];

            //

            st = new Queue<History>(temp.MedicalCase);

            f = false; 
            //

            textBox1.Text = temp.PatientName;
            textBox2.Text = (temp.Age).ToString();
            textBox3.Text = temp.Address;
            textBox4.Text= (temp.id).ToString();
            textBox5.Text = temp.PhoneNumber;

            //
            textBox6.Text =st.Peek().date;
            textBox7.Text = st.Peek().Case;
           textBox8.Text = st.Peek().Prescribed_Medications;

           
          q.Enqueue(st.Dequeue());



        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1(ref m);
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form6 f = new Form6(ref m , temp.id );
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

          //  Queue<History> q = new Queue<History>(); 




            if (st.Count > 0 && !f)
            {


                textBox6.Text = st.Peek().date;
                textBox7.Text = st.Peek().Case;
                textBox8.Text = st.Peek().Prescribed_Medications;

                q.Enqueue(st.Dequeue());
            }



            else if (q.Count > 0)
            {

                f = true;

                textBox6.Text = q.Peek().date;
                textBox7.Text = q.Peek().Case;
                textBox8.Text = q.Peek().Prescribed_Medications;

                st.Enqueue(q.Dequeue());

                if (q.Count == 0)
                    f = false;



            }

            else

                f = false;
                


            


         

            





        }
    }
}
