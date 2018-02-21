using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsApplication1
{
    public class manager
    {


       // public NewPatient[] arr;

        public Dictionary<int, NewPatient> arr;

        public int ID;

        public int num_patients; 

        FileStream f; 



        public manager()
        {
           // arr = new NewPatient[1000];

            arr = new Dictionary<int, NewPatient>();

            ID = 1000;

           f = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr2 = new StreamReader(f);

            if (f.Length != 0)
            {
                string[] arr2;


                arr2 = sr2.ReadLine().Split('=');
                this.ID = int.Parse(arr2[1]);


                arr2 = sr2.ReadLine().Split('=');
                this.num_patients = int.Parse(arr2[1]);



                for (int i = 0; i < num_patients; i++ )
                {
                    NewPatient p = new NewPatient();
                    p.load_data(sr2);

                    arr[p.id] = p;

                   

                }


            



                    f.Close();
                   sr2.Close();
                }


            f.Close();
            sr2.Close();

            }

        




        public void Append(string _name, int _age, string _address, string _phone, string _date, string _case, string _medical)
        {

            NewPatient p = new NewPatient();

            p.PatientName = _name;
            p.Age = _age;
            p.Address = _address;
            p.PhoneNumber = _phone;
            p.id = ID;


            History h = new History(_date, _case, _medical);
            

            p.MedicalCase.Push(h);

         
            arr[ID] = p;
            ID++;
            num_patients++; 

        }




        public void Saving_Data()
        {
            f = new FileStream("data.txt", FileMode.Open,FileAccess.Write);
            StreamWriter sw = new StreamWriter(f);


            string str = "id=";
            str += this.ID.ToString();
            sw.WriteLine(str);

             str = "num_of_patients=";
            str += this.num_patients.ToString();
            sw.WriteLine(str);


          //  List<int> list = new List<int>(arr.Keys);

            foreach (int k in arr.Keys)
            {
                arr[k].save_data(sw); 
            }

            sw.Close();
            f.Close();


        }





































        //       int [] mylist = new int[1000000];  

        ////   void display( NewPatient login_patient)
        ////{
        ////    //cout<<"Patient Name is : "<<login_patient.PatientName<<endl;
        ////    //cout<<"Patient Address is : "<<login_patient.Address<<endl;
        ////    //cout<<"Patient Phone is : "<<login_patient.PhoneNumber<<endl;
        ////    //cout<<"Patient ID is : "<<login_patient.id<<endl;
        ////    //cout<<"Patient Age is : "<<login_patient.Age<<endl;

        ////}

        //void add_new_MedicalCase(string d , string c , string m)
        //{
        //    history h;


        //    login_patient.MedicalCase.push(h);
        //}


        //void load_data(map<long long, NewPatient> & mymap)
        //{

        //    ifstream Data ; 
        //    Data.open("mydata.txt") ; 



        //     //itr = mymap.begin() ; 


        //        int size , msize , age; 
      //        long long id    ; 
        //        string name , address,phone,date,casee,medical , endll ;

        //        Data>>size; 


        //        /*while(patient.MedicalCase.size())
        //            patient.MedicalCase.pop() ; */



        //        while(size)
        //        {
        //            NewPatient patient ; 
        //            History h ; 
        //            Data>>id>>name>>address>>age>>phone>>msize ;

        //            patient.id = id ; 
        //            patient.PatientName = name ;
        //            patient.Address = address ; 
        //            patient.Age = age ; 
        //            patient.PhoneNumber = phone ; 

        //            while(msize)
        //            {
        //                Data>>date>>casee>>medical ; 

        //                h.Date = date ; 
        //                h.Case = casee ; 
        //                h.Prescribed_Medications = medical ; 

        //                patient.MedicalCase.push(h) ; 

        //                msize-- ; 
        //            }


        //            mymap[id] = patient ; 



        //            size-- ; 

        //        }





        //    }







        //NewPatient  Append ()
        //{
        //    NewPatient patient ;
        //    cin.ignore();
        //    cout<<"Enter Patient Name : ";
        //    getline(cin,patient.PatientName);

        //    cout<<"Enter Patient Age : ";
        //    cin>>patient.Age;

        //    cin.ignore();
        //    cout<<"Enter Patient Address : ";
        //    getline(cin,patient.Address);

        //    cout<<"Enter Patient PhoneNum : ";
        //    getline(cin,patient.PhoneNumber);




        //    History h;

        //    cout<<"Enter Medical Case  : "<<endl;
        //    cout<<"Date : ";
        //    //cin.ignore();
        //    getline(cin , h.Date );

        //    cout<<"Medical Case : ";
        //    getline(cin , h.Case);

        //    cout<<"Prescribed Medications : ";
        //    getline( cin , h.Prescribed_Medications ) ;

        //    patient.MedicalCase.push(h);


        //    cout<<"This Patient ID Is : " << ID << '.' << endl ;
        //    patient.id = ID;


        //    return patient;



        //}

        //void Search_By_Name(string name , map<long long ,NewPatient> & mylist)
        //{

        //    map<long long , NewPatient>::iterator itr ; 

        //    itr = mylist.begin() ; 


        //    while (itr != mylist.end())
        //    {
        //        if(itr->second.PatientName == name)
        //        {
        //            display(itr->second) ; 
        //            break ; 
        //        }

        //    itr++ ; 
        //    }

        //    if(itr == mylist.end())
        //        cout<<"No patient Matches !! "<<endl ; 

        //}

        //void Search_By_ID(long long id , map<long long ,NewPatient> & mylist)
        //{

        //    map<long long , NewPatient>::iterator itr ; 

        //    itr = mylist.begin() ; 


        //    while (itr != mylist.end())
        //    {
        //        if(itr->second.id == id)
        //        {
        //            display(itr->second) ; 
        //            break ; 
        //        }

        //    itr++ ; 
        //    }

        //    if(itr == mylist.end())
        //        cout<<"No patient Matches !! "<<endl ; 

        //}

        //void deletee(long long x , map<long long , NewPatient> & mymap)
        //{
        //    map<long long , NewPatient>::iterator itr ; 
        //    itr = mymap.find(x) ; 

        //    if(itr == mymap.end())
        //        return ; 
        //    else
        //    {
        //        mymap.erase(x) ; 
        //    }




        //}


        //void save (map<long long , NewPatient> mymap)
        //{
        //    ofstream data ; 
        //    data.open("mydata.txt") ; 

        //    map<long long , NewPatient>::iterator itr ; 

        //    itr = mymap.begin() ; 

        //    while (itr != mymap.end())
        //    {
        //        data<<mymap.size()<<endl;
        //        data<<itr->first<<endl<<itr->second.PatientName<<endl<<itr->second.Address<<endl<<itr->second.Age<<endl<<itr->second.PhoneNumber<<endl ;
        //        data<<itr->second.MedicalCase.size() ; 

        //        while (itr ->second.MedicalCase.size())
        //        {
        //            data<<itr->second.MedicalCase.top().Date<<endl ; 
        //            data<<itr->second.MedicalCase.top().Case<<endl ;
        //            data<<itr->second.MedicalCase.top().Prescribed_Medications<<endl ;	

        //            itr ->second.MedicalCase.pop() ; 

        //        }




        //    itr++ ;
        //    }






        //}




























    }
}
