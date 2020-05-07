using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepandPaint.Models
{
    public class JobColours
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Colour { get; set; }
    }
}
