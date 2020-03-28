using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepandPaint.Models
{
    public class PrepAndPaintDB
    {
        public static List<PrepAndPaint> GetData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.databasePath))
            {
                
                connection.CreateTable<PrepAndPaint>();
                List<PrepAndPaint> prepAndPaintList = new List<PrepAndPaint>();
                prepAndPaintList = connection.Table<PrepAndPaint>().ToList();
                return prepAndPaintList.OrderBy(x => x.JobNumber).ToList();
            }
        }

        public static void AddJob(PrepAndPaint newJob)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.databasePath))
            {
                connection.Insert(newJob);
            }
        }

        public static void EditJob(PrepAndPaint editJob)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.databasePath))
            {
                connection.Update(editJob);
            }
        }

        public static void Delete(PrepAndPaint Id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.databasePath))
            {
                connection.Delete(Id);
            }
        }

        public static List<PrepAndPaint> Search(string jobNumber)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.databasePath))
            {
                List<PrepAndPaint> search = connection.Table<PrepAndPaint>().ToList();
                return search.Where(x => x.JobNumber.Contains(jobNumber)).ToList();
            }
        }
    }
}
