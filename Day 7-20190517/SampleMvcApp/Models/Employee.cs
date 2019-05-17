using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMvcApp.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public double EmpSalary { get; set; }

        //public override string ToString()
        //{
        //    return $"<h1>The CEO:{EmpName}</h1><div><h2>His Details:</h2><p>Place: {EmpAddress}</p><p>Salary:{EmpSalary}</p></div>";
        //}
    }
}