using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    //Класс для взаимодействия с СУБД вместо ListRepository
    public class MsRepo : IRepository<Worker>
    {
        StorageContext db;
        public MsRepo(string dbName)
        {
            db = new StorageContext(dbName);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }
        public void Create(Worker item)
        {
            db.Workers_t.Add(item);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            Worker t = db.Workers_t.First(e => e.Id == id);
            db.Entry(t).State = EntityState.Deleted;
            db.SaveChanges();
        }
        public Worker[] Read()
        {
            return db.Workers_t.ToArray();
        }

        public NewWorker[] ReadNameAndAge(int minAge)
        {
            return db.Workers_t.Where(e => e.Age > minAge).ToArray().Select(e => new NewWorker(e.Age, e.FullName)).ToArray();
        }
        public void Update(int id, Worker newItem)
        {
            Worker t = db.Workers_t.First(e => e.Id == id);
            t.Age = newItem.Age;
            t.Salary = newItem.Salary;
            t.FullName = newItem.FullName;
            db.Entry(t).State = EntityState.Modified;
            db.SaveChanges();
        }


    }
}
