using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApiWithSPs.CustomAttributes
{
    public class ParamterName:Attribute
    {
        public string Name { get; set; }      

        // Parameterised Constructor 
        public ParamterName(string name)
        {
            Name = name;
          
        }
    }
}