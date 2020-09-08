using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitExerciseMVC.Models
{
    public class EmpModel
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public string EDesig { get; set; }
        public DateTime EDoj { get; set; }
    }
}