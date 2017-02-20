using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;


namespace BuckFizz.ServiceModel
{
    [Route("/webTable/{repeatCount}")]
 
    public class webTable : IReturn<TableResponse>
    {
      public int repeatCount { get; set; }
 
        
    }
 

    public class TableResponse
    {
        public string[] Result { get; set; }
    }
}