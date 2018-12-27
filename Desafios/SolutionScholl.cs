using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios

{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }
    class Student : Person
    {
        private int[] testScores;

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */

        public Student(string firstName, string lastName, int identification, int[] testScores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            id = identification;
            this.testScores = testScores;
        }

        public string Calculate()
        {
            int average = 0;
            string grades;
            for (int i = 0; i < testScores.Length; i++)
            {
                average = average + testScores[i];
            }

            average = average / testScores.Length;


            if (average >= 90 && average <= 100)
            {
                grades = "O";
            }
            else if (average >= 80 && average < 90)
            {
                grades = "E";
            }
            else if (average >= 70 && average < 80)
            {
                grades = "A";
            }
            else if (average >= 55 && average < 70)
            {
                grades = "P";
            }
            else if (average >= 40 && average < 55)
            {
                grades = "D";
            }
            else
            {
                grades = "T";
            }
            return grades;
        }


    }

    class SolutionScholl
    {/*
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();

            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }*/
    }
}
