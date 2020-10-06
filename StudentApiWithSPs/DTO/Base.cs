using StudentApiWithSPs.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApiWithSPs.DTO
{
    public class Base
    {
        [ParamterName("@Id")]
        public int Id { get; set; }
        [ParamterName("@UserId")]
        public int UserId { get; set; }
    }
}