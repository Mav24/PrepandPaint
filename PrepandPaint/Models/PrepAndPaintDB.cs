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
        #region for new database
        public static List<PrepAndPaintModel> GetNewData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.CreateTable<PrepAndPaintModel>();
                List<PrepAndPaintModel> prepAndPaintList = new List<PrepAndPaintModel>();
                prepAndPaintList = connection.Table<PrepAndPaintModel>().ToList();
                return prepAndPaintList.OrderBy(x => x.JobNumber).ToList();
            }
        }

        public static void AddnewJob(PrepAndPaintModel newJob)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Insert(newJob);
            }
        }

        public static void EditnewJob(PrepAndPaintModel editJob)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Update(editJob);
            }
        } 
        #endregion


        public static void Delete(PrepAndPaintModel Id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Delete(Id);
            }
        }

        public static List<PrepAndPaintModel> Search(string jobNumber)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                List<PrepAndPaintModel> search = connection.Table<PrepAndPaintModel>().ToList();
                return search.Where(x => x.JobNumber.Contains(jobNumber)).ToList();
            }
        }
    }
}
