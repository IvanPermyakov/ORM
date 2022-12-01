using System;

namespace ORM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем приложение которое будут работать с классом Worker
            //new ListRepository() - хранилище
            //App<Worker> app = new App<Worker>(new ListRepository());

            //Создаем приложение которое будут работать с классом Worker, но через СУБД
            App<Worker> app = new App<Worker>(new MsRepo("Workers"));

            app.Create(new(20, 1500, "Ivanov Ivan"));
            app.Create(new(25, 1600, "Petrov Pert"));
            app.Create(new(24, 1550, "Sidorov Sidr"));

            app.Print();
            Console.WriteLine();

            app.PPrint(23);
            Console.WriteLine();
        }
    }
   
}
