using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public int Runtime { get; set; }

        public int Year { get; set; }

        public Movie(string _title,string _category,int _runtime,int _year)
        {
            Title = _title;
            Category = _category;
            Runtime = _runtime;
            Year = _year;
        }
    }
}
