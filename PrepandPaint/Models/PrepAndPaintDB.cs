using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
                connection.Backup(destinationPath, "main");
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

        public static List<PrepAndPaintModel> SearchJobNumber(string jobNumber)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                List<PrepAndPaintModel> search = connection.Table<PrepAndPaintModel>().ToList();
                return search.Where(x => x.JobNumber.Contains(jobNumber)).OrderByDescending(d => d.StartDate).ToList();
            }
        }

        public static List<PrepAndPaintModel> SearchItem(string item)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                List<PrepAndPaintModel> searchItem = connection.Table<PrepAndPaintModel>().ToList();
                return searchItem.Where(x => x.BodyOrDoors.Equals(item, StringComparison.OrdinalIgnoreCase)).OrderByDescending(d => d.PaintDate).ToList();
            }
        }

        public static List<PrepAndPaintModel> SortByDate()
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                List<PrepAndPaintModel> prepAndPaintList = new List<PrepAndPaintModel>();
                prepAndPaintList = connection.Table<PrepAndPaintModel>().ToList();
                return prepAndPaintList.OrderBy(x => x.PaintDate).ToList();
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

        public static string AddItem(ItemsModel item)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Insert(item);
                return item.ItemName;
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

        public static List<JobColoursModel> GetJobColours()
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.CreateTable<JobColoursModel>();
                List<JobColoursModel> jobColours = new List<JobColoursModel>();
                jobColours = connection.Table<JobColoursModel>().ToList();
                return jobColours;
            }
        }

        public static string AddColour(JobColoursModel jobColours)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Insert(jobColours);
                return jobColours.Colour;
            }
        }

        public static void DeleteColour(JobColoursModel id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Delete(id);
            }
        }

        #region Admin Stuff
        public static List<AdminsModel> GetAdmins()
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.CreateTable<AdminsModel>();
                List<AdminsModel> admins = new List<AdminsModel>();
                admins = connection.Table<AdminsModel>().ToList();
                return admins;
            }
        }

        public static void AddAdmin(AdminsModel admin)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Insert(admin);
            }
        }

        public static void DeleteAdmin(AdminsModel id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.mainDatabaseFile))
            {
                connection.Delete(id);
            }
        } 
        #endregion
    }
}
