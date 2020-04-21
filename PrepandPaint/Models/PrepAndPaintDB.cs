using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepandPaint.Models
{
    public class PrepAndPaintDB
    {
        #region Main window methods
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
        public static void BackUpDataBase(string destinationPath)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                string databasename;
                connection.Backup(destinationPath, databasename = "main");
            }
        }

        public static void RestoreDataBase(string fileName)
        {
            File.Copy(Path.Combine(fileName), Path.Combine(DataBase.mainDatabaseFile), true);
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
                return search.Where(x => x.JobNumber.Contains(jobNumber)).OrderBy(d => d.StartDate).ToList();
            }
        }

        #region SuperVisor Methods
        public static List<SupervisorNotesModel> GetSuperVisorInfo()
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.CreateTable<SupervisorNotesModel>();
                List<SupervisorNotesModel> supervisorNotes = new List<SupervisorNotesModel>();
                supervisorNotes = connection.Table<SupervisorNotesModel>().ToList();
                return supervisorNotes.OrderBy(x => x.Date).ToList();

            }
        }
        public static void SaveSuperVisorNotes(SupervisorNotesModel notes)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Insert(notes);
            }
        }

        public static void UpdateSuperVisorNote(SupervisorNotesModel Id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Update(Id);
            }
        }

        public static void DeleteSuperVisorNote(SupervisorNotesModel Id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Delete(Id);
            }
        }
        #endregion

        #region Items Methods

        public static List<ItemsModel> GetItemsList()
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.CreateTable<ItemsModel>();
                List<ItemsModel> items = new List<ItemsModel>();
                items = connection.Table<ItemsModel>().ToList();
                return items;
            }
        }

        public static void AddItem(ItemsModel item)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Insert(item);
            }
        }

        public static void UpdateItem(ItemsModel item)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Update(item);
            }
        }

        public static void DeleteItem(ItemsModel Id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Delete(Id);
            }
        }

        #endregion
    }
}
