using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication17.Models
{
    public class Emp
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public DateTime? EDoj { get; set; }
    }
}