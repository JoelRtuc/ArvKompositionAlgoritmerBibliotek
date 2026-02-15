using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvKompositionAlgoritmerBibliotek
{
    public class Movie : LibraryItem
    {
        private readonly int movieId; //jag brukar inte skriva private men jag gör det här så du inte tror att jag tror att readonly är en typ av inkapsling
        public int duration; //längd i minuter
        public enum MovieType {DVD, BlueRay, VHS, Film};
        public MovieType type;

        public Movie(int ISBN, string title, string description, string author, int publishedYear, bool isAvailable, int duration, MovieType type)
        {
            movieId = ISBN;
            base.title = title;
            base.description = description;
            base.publishedYear = publishedYear;
            base.isAvailable = isAvailable;
            base.author = author;
            this.duration = duration;
            this.type = type;

        }
    }
}
