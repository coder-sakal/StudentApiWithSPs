using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentApiWithSPs.CustomAttributes;
namespace StudentApiWithSPs.DTO
{
    [SPName("Student_SaveUpdate_1")]
    public class Student:Base
    {  
        [ParamterName("@Name")]
        public string Name { get; set; }
        [ParamterName("@Gender")]
        public int Gender { get; set; }
        [ParamterName("@IsHandicap")]
        public bool IsHandicap { get; set; }
        [ParamterName("@Standerd")]
        public int Standerd { get; set; }       

    }
}