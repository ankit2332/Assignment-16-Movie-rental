using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16_Movie_rental
{
    class Movie
    {
        private string name;
        private int length = 0;
        private bool available;

        public Movie(string name, int length)
        {
            this.name = name;
            this.length = length;
            available = true;
        }

        public string getname()
        {
            return name;
        }

        public int getlength()
        {
            return length;
        }

        public bool isavailable()
        {
            return available;
        }

        public void borrowmovie()
        {
            if (available)
            {
                available = false;
            }
        }
        public void returnmovie()
        {
            if (available == false)
            {
                available = true;
            }
        }
    }
}
