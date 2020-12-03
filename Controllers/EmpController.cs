using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            List<Emp> obj = new List<Emp> {
            new Emp{EId=101,EName="Rahul",EDesig="developer",EDOJ=DateTime.Parse("12/12/12") },
             new Emp{EId=102,EName="Paresh",EDesig="developer",EDOJ=DateTime.Parse("17/04/12") },
              new Emp{EId=103,EName="Rasika",EDesig="manager",EDOJ=DateTime.Parse("16/12/12") },
               new Emp{EId=104,EName="Monali",EDesig="HR",EDOJ=DateTime.Parse("22/08/12") },
                new Emp{EId=105,EName="Shivangi",EDesig="developer",EDOJ=DateTime.Parse("19/10/12") }
        };
          
            return View(obj);
        }
    }
}