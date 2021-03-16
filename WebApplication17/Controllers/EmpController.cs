using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            List<Emp> listemp = new List<Emp>()
            {
                new Emp{Empid=1,EmpName="Sreekanth",Designation="Trainee",EDoj=DateTime.Parse("14/01/2021 00:00:00")},
                new Emp{Empid=2,EmpName="Sreenath",Designation="HR",EDoj=DateTime.Parse("04/01/2016 00:00:00")},
                new Emp{Empid=3,EmpName="Sreedhar",Designation="Tester",EDoj=DateTime.Parse("12/02/2017 00:00:00")},
                new Emp{Empid=4,EmpName="Sreeshanth",Designation="FSO",EDoj=DateTime.Parse("12/05/2018 00:00:00")}
            };
            return View(listemp);
        }
    }
}