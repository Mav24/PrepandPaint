using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace PrepandPaint.Models
{
    public class PrepAndPaintModel
    {
        //private string colour;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string JobNumber { get; set; }
        public string BodyOrDoors { get; set; }
        public string StartDate { get; set; }
        public string Prepper { get; set; }
        public string PaintDate { get; set; }
        public string Painter { get; set; }
        public string Booth { get; set; }
        public string Colour { get; set; }
        //public string Colour
        //{
        //    get { return colour; }
        //    set 
        //    { 
        //        if (colour == null)
        //        {
        //            colour = null;
        //        }
        //        colour = value;
        //    }
        //}
        public bool NewProcess { get; set; }
        public string Comments { get; set; }

        


    }
}
