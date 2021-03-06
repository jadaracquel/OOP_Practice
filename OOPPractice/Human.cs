﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    //***EXAMPLE OF ABSTRACTION & INHERITANCE***
    public abstract class Human
    {
        public string name;
        public int age;
        public Human()
        {
            Console.WriteLine("Enter your name: ");
            string humanName = Console.ReadLine();
            this.name = humanName;
            Console.WriteLine("Enter your age: ");
            int humanAge = int.Parse(Console.ReadLine());
            this.age = humanAge;
        }
        public Human(string humanName)
        {
            this.name = humanName;
        }

        public Human(string humanName, int humanAge)
        {
            this.name = humanName;
            this.age = humanAge;
        }

        public void Eat()
        {
            Console.WriteLine("Eating like a human...");
        }

        public virtual void Shave()
        {
            Console.WriteLine("Shaving like a human...");
        }

        public abstract void Work(string career);
        public abstract void Work();

        public virtual void Sleep()
        {
            Console.WriteLine("Sleeping like a human...");
        }
    }

    public class Female : Human
    {
        public int femaleAge;
        public Female(string nm) : base(nm) { }

        public Female(string nm, int age) : base(nm)
        {
            femaleAge = age;
        }
        public override void Shave()
        {
            Console.WriteLine("Shaving like a lady...");
        }
        public override void Work(string job)
        {
            Console.WriteLine("Lady working as a " + job);
        }
        public override void Work()
        {
            Console.WriteLine("Lady working hard!");
        }
        public override void Sleep()
        {
            base.Sleep();
        }

    }
    public class Male : Human
    {
        public Male(string nm, int maleAge) : base(nm, maleAge)
        {

        }
        public override void Shave()
        {
            base.Shave();
        }
        public override void Work(string job)
        {
            Console.WriteLine("Guy working as a " + job);
        }
        public override void Work()
        {
            Console.WriteLine("Guy working hard!");
        }
        public override void Sleep()
        {
            Console.WriteLine("Sleeping like a guy...");
        }

    }

}
