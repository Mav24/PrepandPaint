﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepandPaint.Models
{
    public class DataBase
    {

        static string supervisorFile = "supervisornotes.db";
        static string prepPaintDBFile = "mainlog.db";
                
        public static string databaseSupervisorNotes = System.IO.Path.Combine(supervisorFile);

        public static string mainDatabaseFile = System.IO.Path.Combine(prepPaintDBFile);
    }
}
