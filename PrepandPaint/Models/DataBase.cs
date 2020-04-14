using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PrepandPaint.Models
{
    public class DataBase
    {
        static string prepPaintDBFile = "mainlog.db";

        public static string mainDatabaseFile = System.IO.Path.Combine(prepPaintDBFile);

    }
}
