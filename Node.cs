using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListMovies
{


    public class T
    {
        public Movie data;
        public T next;
        public T previous;

        public T (Movie data)
        {
            this.data = data;
        }

        public T(Movie data, T next, T previous)
        {
            this.data = data;
            this.next = next;
            this.previous = previous;
        }
    }
}
