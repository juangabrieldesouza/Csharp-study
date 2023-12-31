using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRestrictions
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Director : IgetSalary
    {
        public Director(double salary)
        {
            this.salary = salary;
        }

        private double salary;

        public double getSalary()
        {
            return salary;
        }
    }

    class Secretary : IgetSalary
    {
        public Secretary(double salary)
        {
            this.salary = salary;
        }

        private double salary;

        public double getSalary()
        {
            return salary;
        }
    }

    class Eletrician : IgetSalary
    {
        public Eletrician(double salary)
        {
            this.salary = salary;
        }

        private double salary;

        public double getSalary()
        {
            return salary;
        }
    }

interface IgetSalary
    {
        double getSalary();
    }

}
