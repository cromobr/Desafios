﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    class Person2
    {
        public int age;
        public Person2(int initialAge)
        {
            if (initialAge < 0)
            {
                this.age = 0;
                Console.WriteLine("Age is not valid, setting age to 0. ");
            } else
            {
                this.age = initialAge;
            }
        }
        public void amIOld()
        {
            if (this.age < 13)
                Console.WriteLine("You are young.");
            else if (this.age >= 13 & this.age < 18)
                Console.WriteLine("You are a teenager.");
            else
                Console.WriteLine("You are old.");

        }


        public void yearPasses()
        {
            this.age = this.age + 1;
        }
        /*
        static void Main(String[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }*/
    }
}
