using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInformation.Models
{
    public class MyInfo : IMyInfo
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public string ContactNumber { get; set; }
        public int SumOfTwoNumber { get; set; }

        public int GetSum(int a, int b)
        {
            return a + b;
        }
    }
}