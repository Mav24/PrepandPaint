using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace PrepandPaint.Models
{
    public class ItemsModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string ItemName { get; set; }
    }
}
