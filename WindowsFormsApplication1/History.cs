using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
  public  class History
    {

      public History()
      {
          
      }


      public History(string s1, string s2, string s3) 
      {
          date = s1; 
          Case = s2 ;
          Prescribed_Medications = s3; 
      
      }

        public string date;

        public string Case;

        public string Prescribed_Medications;

    }
}
