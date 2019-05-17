using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMvcApp.Models
{
    //From C# 5.0 we are able to set default values to the properties...
    public class MathOperation
    {
        public double FirstValue { get; set; } = 100;
        public double ResultValue { get; set; }
        public double SecondValue { get; set; } = 200;
        public string Operand { get; set; } = "+";//+, -, *...
    }
}