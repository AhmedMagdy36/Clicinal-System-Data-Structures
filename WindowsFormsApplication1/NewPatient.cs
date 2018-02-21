using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
namespace WindowsFormsApplication1
{
 public   class NewPatient
    {

     public NewPatient()
     { 
         MedicalCase = new Stack<History>() ; 
     
     }
     

        public string PatientName;

        public string Address;
        
        public string PhoneNumber;

        public int id;

        public int Age;

        public Stack<History> MedicalCase ; 



        public void save_data(StreamWriter sw)
        {

            string str = "Patient_ID=";
            str += this.id;
            sw.WriteLine(str);

            str = "Patient_name=";
            str += this.PatientName;
            sw.WriteLine(str);

            str = "Patient_address=";
            str += this.Address;
            sw.WriteLine(str);

            str = "patient_age=";
            str += this.Age.ToString();
            sw.WriteLine(str);

            str = "patient_phone=";
            str += this.PhoneNumber;
            sw.WriteLine(str);

            str = "count=";
            str += this.MedicalCase.Count.ToString();
            sw.WriteLine(str);


            Stack<History> s = new Stack<History>(this.MedicalCase); 




            while (s.Count > 0)
            {
                str = "date=";
                str += s.Peek().date;
                sw.WriteLine(str);


                str = "case=";
                str += s.Peek().Case;
                sw.WriteLine(str);


                str = "medical=";
                str += s.Peek().Prescribed_Medications;
                sw.WriteLine(str);



                s.Pop();
                
            
            
           
            }


        }

        public void load_data(StreamReader sr )
        {
            string[] arr2;
            


            arr2 = sr.ReadLine().Split('=');
            this.id = int.Parse(arr2[1]);


            arr2 = sr.ReadLine().Split('=');
            this.PatientName=arr2[1] ;

            arr2 = sr.ReadLine().Split('=');
            this.Address = arr2[1];

            arr2 = sr.ReadLine().Split('=');
            this.Age = int.Parse(arr2[1]);

            arr2 = sr.ReadLine().Split('=');
            this.PhoneNumber = arr2[1];

            int count;

            arr2 = sr.ReadLine().Split('=');
            count = int.Parse(arr2[1]); 
            
            while (count> 0)
            {
                History h = new History();

                arr2 = sr.ReadLine().Split('=');
                h.date = arr2[1];


                arr2 = sr.ReadLine().Split('=');
                h.Case = arr2[1];



                arr2 = sr.ReadLine().Split('=');
                h.Prescribed_Medications = arr2[1];





                this.MedicalCase.Push(h);

                count--; 


            }


        }
     

    }
}
