using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    //Объявляем интерфейс для работы с БД для работы с классом Worker
    //Модель репозитория
    public interface IWorkerRepository
    {
        void Create(Worker item);
        Worker[] Read();
        void Update(int id, Worker newItem);
        void Delete(int Id);
    }
    //Объявляем параметризированный интерфейс для работы с БД для передачи туда любого объекта
    //Хранилище
    public interface IRepository<T>
    {
        void Create(T item);
        T[] Read();
        void Update(int id, T newItem);
        void Delete(int Id);
    }
    //Вызов интерфейса перадача туда класса Worker
    //IRepository<Worker>
}
