using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    //***EXAMPLE OF INHERITANCE & POLYMORPHISM***      KEYWORDS: virtual- for base class methods; override- for derived class methods
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating like any other animal...");
        }
        public virtual void Walk()
        {
            Console.WriteLine("Walking like any other animal...");
        }
        public virtual void Sleep()
        {
            Console.WriteLine("Sleeping like any other animal...");
        }

    }
    //A Lion 'IS-A' Animal that can eat, walk, sleep, and attack
    class Lion : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating like a lion...");
        }
        public override void Walk()
        {
            Console.WriteLine("Walking like a lion...");
        }
        public override void Sleep()
        {
            base.Sleep();
        }
        public void Attack()
        {
            Console.WriteLine("Attacking like a lion!!!");
        }
    }
    //A Giraffe 'IS-A' Animal that can eat, walk, sleep, and look around
    class Giraffe : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating like a giraffe...");
        }
        public override void Walk()
        {
            base.Walk();
        }
        public override void Sleep()
        {
            Console.WriteLine("Sleeping like a giraffe...");
        }
        public void LookAround()
        {
            Console.WriteLine("Looking around like a giraffe!!!");
        }
    }
    //A Duck 'IS-A' Animal that can eat, walk, sleep, and swim
    class Duck : Animal
    {
        public override void Eat()
        {
            base.Eat();
        }
        public override void Walk()
        {
            Console.WriteLine("Walking like a duck...");
        }
        public override void Sleep()
        {
            Console.WriteLine("Sleeping like a duck...");
        }
        public void Swim()
        {
            Console.WriteLine("Swimming like a duck!!!");
        }
    }
}

