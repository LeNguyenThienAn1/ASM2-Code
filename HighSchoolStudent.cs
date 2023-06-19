using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV3
{
    internal class HighSchoolStudent:Student
    {
        public string HighSchoolName { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Tên trường trung học: " + HighSchoolName);
        }
    }
}
