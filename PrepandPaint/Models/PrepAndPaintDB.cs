using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepandPaint.Models
{
    public class PrepAndPaintDB
    {
        static string fileName = "prepandpaint.db";
        public static string databasePath = System.IO.Path.Combine(fileName);
    }
}
