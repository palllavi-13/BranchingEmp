using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Emp
    {

        public int EId { get; set; }
        public string EName { get; set; }
        public string EDesig { get; set; }
        public DateTime EDOJ { get; set; }
    }
}