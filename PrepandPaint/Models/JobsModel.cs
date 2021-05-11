using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace PrepandPaint.Models
{
    public class JobsModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string JobNumber { get; set; }
        public string Model { get; set; }
        public string Customer { get; set; }
        public bool Completed { get; set; }
    }
}
