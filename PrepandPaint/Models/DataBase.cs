using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepandPaint.Models
{
    public class DataBase
    {
        static string mainDbFile = "prepandpaint.db";
        static string supervisorFile = "supervisornotes.db";
        
        public static string databasePath = System.IO.Path.Combine(mainDbFile);
        
        public static string databaseSupervisorNotes = System.IO.Path.Combine(supervisorFile);
    }
}
