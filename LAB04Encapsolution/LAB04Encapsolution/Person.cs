using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4Encapsulation
{
    public class Person
    {
        private string Name;
        private int Age;
        private int BithYear;
        private double GPA;

        public Person(string name, int bY , double gpa)
        {
            this.Name = name;
            this.BithYear = bY;
            this.Age = 2566 - bY;
            GPA = gpa;
        }
        public int getAge()
        {
            return this.Age;
        }
        public string getName()
        {
            return this.Name;
        }
        public double getGPA()
        {
            return GPA;
        }
    }
}