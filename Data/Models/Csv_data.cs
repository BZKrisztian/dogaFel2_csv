using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Data.Models
{
    public class Csv_data
    {
        public string Name { get; set; }
        public string Building { get; set; }
        public string Z_Code { get; set; }
        public string Position { get; set; }
        public string Transport { get; set; }

        public Csv_data()
        {
        }

        public Csv_data(string ScvRLines)
        {
            string[] lines = ScvRLines.Split(';');

            if (lines.Length == 5)
            {
                Name = lines[0];
                Building = lines[1];
                Z_Code = lines[2];
                Position = lines[3];
                Transport = lines[4];
            }
            else
            {
                throw new ArgumentException("Invalid Format");
            }

        }

        public override string ToString()
        {
            return $"{Name};{Building};{Z_Code};{Position};{Transport}";
        }
    }
}
