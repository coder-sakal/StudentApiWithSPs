using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApiWithSPs.CustomAttributes
{
    public class SPName:Attribute
    {
        public string Name { get; set; }
        public SPName(string name)
        {
            this.Name = name;
        }
    }
}