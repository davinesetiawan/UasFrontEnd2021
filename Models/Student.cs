using System.Numerics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorUas.Models
{
    public class Student
    {
        public string studentID { get; set; }

        public string lastName { get; set; }

        public string firstName { get; set; }

        public DateTime enrollmentDate { get; set; } = DateTime.Now;
    }
}