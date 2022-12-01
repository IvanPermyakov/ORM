using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    //Класс для возвращения массива определенных данных 
    //Те Age и FullName без id и salary
    public class NewWorker
    {
        public NewWorker() { }

        public NewWorker(int age, string fullName)
        {
            Age = age;
            FullName = fullName;
        }
        public int Age { get; set; }
        public string FullName { get; set; }

        public override string ToString()
        => $"{FullName}{Age}";


    }
}
