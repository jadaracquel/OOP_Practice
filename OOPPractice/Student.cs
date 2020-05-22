using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    //EXAMPLE OF ENCAPSULATION
    class Student
    {
        private string name;
        private string id;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public string GetID()
        {
            return id;
        }

        public void SetID(string id)
        {
            this.id = id;
        }

        public override String ToString()
        {
            return "Student Name: " + GetName() + "\nStudent ID: " + GetID();
        }
    }
}
