using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjectStorage<string> F1 = new ObjectStorage<string>(4);
            ObjectStorage<Employees> F2 = new ObjectStorage<Employees>(5);

            F2.insertObject(new Employees(2000));
            F2.insertObject(new Employees(2700));
            F2.insertObject(new Employees(3500));
            F2.insertObject(new Employees(4700));
            F2.insertObject(new Employees(6000));

           F1.insertObject("Juan");
            F1.insertObject("Antonio");
            F1.insertObject("Joao");
            F1.insertObject("Gabriel");

            string NomeFuncionario = F1.GetElements(2);
            Console.WriteLine(NomeFuncionario);

            Employees SalaryEmp1 = (Employees)F2.GetElements(2);

            Console.WriteLine(SalaryEmp1.getSalary());
        }
    }

    class ObjectStorage<T>
    {
        public ObjectStorage(int z)
        {
            ReadingElements = new T[z];
        }

        public void insertObject(T obj)
        {

            ReadingElements[meter] = obj;

            meter++;

        }
        public T GetElements(int i)
        {
            return ReadingElements[i];

        }

        private T[] ReadingElements;

        private int meter = 0;
    }

    class Employees
    {
        public Employees(double salary) 
        {
            this.salary = salary;
        }

        public double getSalary()
        {
            return salary;
        }

        private double salary;
    }
}
