using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Test
    {
        public static void FeedAnimals(Animal[] theZoo)
        {
            //Polymorphism-- this FeedAnimal() method will feed any type of animal
            for (int i = 0; i < theZoo.Length; i++)
            {
                theZoo[i].Eat();
            }
        }
        public static void WalkAnimals(Animal[] theZoo)
        {
            //Polymorphism-- this WalkAnimal() method will walk any type of animal
            for (int i = 0; i < theZoo.Length; i++)
            {
                theZoo[i].Walk();
            }
        }
        public static void Employees(Human[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].Work();
            }
        }
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

            //***TEST ANIMAL CLASS***
            //Lion Leon = new Animal();     //This DOES NOT work b/c every animal is NOT a lion!
            Animal Leo = new Lion();
            Animal Dezz = new Duck();   //This works b/c every lion is an animal!
            Animal Gia = new Giraffe();
            Duck Daffy = new Duck();
            Lion Lava = new Lion();
            Giraffe Gina = new Giraffe();
            Duck Dula = new Duck();
            //The line below works b/c the Lion, Giraffe, and Duck classes all inherit the Animal class 
            Animal[] animals = new Animal[] { Leo, Dezz, Lava, Gia, Dula, Gina, Daffy };

            FeedAnimals(animals);
            Console.WriteLine();

            WalkAnimals(animals);
            Console.WriteLine();

            Gina.Sleep();
            Dezz.Sleep();
            Lava.Sleep();
        }
    }
}
