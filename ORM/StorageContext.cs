using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    //Подключение к БД
    public class StorageContext : DbContext
    {
        //Название БД
        string dbName;
        public StorageContext(string dbName)
        {
            this.dbName = dbName;
        }
        //Создание таблицы
        public DbSet<Worker> Workers_t { get; set; }
        //Настройки подключения к БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database={0};Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(String.Format(connectionString, dbName));
        }
    }
}
