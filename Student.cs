using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV3
{
    public abstract class Student
    {
        private string name;
        private int age;
        private string gender;
        private string id;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public abstract void PrintInfo();
    }
}
