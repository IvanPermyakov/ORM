using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Worker
    {
        //Объявляем конструктор для того чтобы сразу передать туда значения при создании нового класса
        //Worker w = new Worker(12, 1500, "Ivanov Ivan");
        public Worker() { }

        public Worker(int age, int salary, string fullName)
        {
            Age = age;
            Salary = salary;
            FullName = fullName;
        }
        public int Id { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string FullName { get; set; }

        //Для более быстрого вывода на печать
        //Console.WriteLine(w)
        public override string ToString()
        => $"{Id}{FullName}{Age}{Salary}";


    }
}
