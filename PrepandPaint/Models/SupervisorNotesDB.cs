using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepandPaint.Models
{
    public class SupervisorNotesDB
    {
        public static List<SupervisorNotes> GetInfo()
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.databaseSupervisorNotes))
            {
                connection.CreateTable<SupervisorNotes>();
                List<SupervisorNotes> supervisorNotes = new List<SupervisorNotes>();
                supervisorNotes = connection.Table<SupervisorNotes>().ToList();
                return supervisorNotes.OrderBy(x => x.Date).ToList();
                
            }
        }
        public static void Save(SupervisorNotes notes)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.databaseSupervisorNotes))
            {
                connection.Insert(notes);
            }
        }

        public static void Update(SupervisorNotes Id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.databaseSupervisorNotes))
            {
                connection.Update(Id);
            }
        }

        public static void Delete(SupervisorNotes Id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataBase.databaseSupervisorNotes))
            {
                connection.Delete(Id);
            }
        }
    }
}
