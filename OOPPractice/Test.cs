using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Test
    {
        static void Main(string[] args)
        {
            //***TEST STUDENT CLASS***
            Student James = new Student();
            Student Wilson = new Student();

            James.SetName("Armani James");
            Wilson.SetName("Keith Wilson");

            Wilson.SetID("36851");
            James.SetID("5274");

            Console.WriteLine("Student Name: {0}", James.GetName());
            Console.WriteLine("Student ID: {0}\n", James.GetID());

            Console.WriteLine(Wilson.ToString() + "\n");
        }
    }
}
