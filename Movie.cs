using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListMovies
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public double Imdb { get; set; }

        public Movie(int id, string name, int year, double imdb)
        {
            Id = id;
            Name = name;
            Year = year;
            Imdb = imdb;
        }

        public Movie()
        {
       
        }
        public override string ToString()
        {
            return this.Id + " " + this.Name + " (" + this.Year + ") - Rating: " + this.Imdb; 
        }
    }
}
