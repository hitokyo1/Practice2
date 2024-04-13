using System;
using System.Collections.Generic;
using System.Text;

namespace Praktica2._3._1
{
    class Worker
    {
        public string Name = " ";
        public string Surname = " ";
        public int Rate;
        public int Days;

        public int GetSalary()
        {
            return this.Rate * this.Days;
        }
    }
}