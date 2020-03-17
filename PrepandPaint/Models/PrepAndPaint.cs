using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace PrepandPaint.Models
{
    public class PrepAndPaint
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string JobNumber { get; set; }
        public DateTime StartDate { get; set; }
        public string Prepper { get; set; }
        public DateTime PaintDate { get; set; }
        public string Painter { get; set; }
        public string BodyOrDoors { get; set; }
        public string Booth { get; set; }
        public string Comments { get; set; }
    }
}
