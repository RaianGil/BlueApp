using System;
using System.IO;
using SQLite;
using BlueApp.Models;
using System.Linq;
using BlueApp.Data;

namespace BlueApp.Controllers
{
    public class SQLiteConn
    {
        SQLiteConnection db;
        static SQLiteConn instance;
        public SQLiteConn()
        {
            db = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "BlueApp.db"));
            db.CreateTable<CarModel>();
            insertWhenEmpty();
        }
        public static SQLiteConn getInstance()
        {
            if (instance == null)
                instance = new SQLiteConn();
            return instance;
        }
        private void insertWhenEmpty()
        {
            var cars = db.Table<CarModel>();
            if (!cars.Any())
            {
                db.InsertAll(DummyData.carsList);
            }
        }
        public CarModel findCarByCode(string code)
        {
            var car = db.Table<CarModel>().FirstOrDefault(x => x.CarCode == code);
            return car;
        }
    }
}
