using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeMVC.Models
{
    public class Student
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMI { get; set; }
        public string Memo { get; set; }
    }
}