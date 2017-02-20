using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using BuckFizz.ServiceModel;
using System.Collections.Specialized;
using System.Collections;


namespace BuckFizz.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(webTable request)
        {
        
            return new TableResponse { Result = getTableData(request.repeatCount) };
        }


        private string[] getTableData(int countRep)
        {
            string[] webTablestr = new string[countRep];
         
            for (var i = 1; i < countRep + 1; i++)
            {
                webTablestr[i - 1] = checkWebstring(i);
            }
            return webTablestr;
           
            
        }
        private string checkWebstring(int ind)
        {
     
            string retSTR = "";
          
           

            if (ind % 5 == 0)
            {
                retSTR += "Buck";
            }
            if (ind % 3 == 0)
            {
                retSTR += "Fizz";
            }
     

            if (retSTR == "")
            {
                retSTR += ind;
            }
            return retSTR;
        }

     

    }

 
}



