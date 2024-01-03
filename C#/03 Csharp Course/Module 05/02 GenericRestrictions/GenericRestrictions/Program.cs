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

           EmployeesWereHouse<Director> TypeDirectors = new EmployeesWereHouse<Director>(3);

            TypeDirectors.adicionar(new Director(4000));



        }
    }


    class EmployeesWereHouse<T> where T : IgetSalary
    {

        public EmployeesWereHouse(int z)
        {

            EmployeeData = new T[z];


        }

        public void adicionar(T obj)
        {
            EmployeeData[i] = obj;

            i++;

        }


        public T getEmployees(int i)
        {
            return EmployeeData[i];
        }


        private int i = 0;

        private T[] EmployeeData;

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


    class Student
    {

        public Student (double age)
        {
            this.age = age;
        }

        public double Getage()
        {
            return age;
        }

        private double age;
    }

interface IgetSalary
    {
        double getSalary();
    }

}
