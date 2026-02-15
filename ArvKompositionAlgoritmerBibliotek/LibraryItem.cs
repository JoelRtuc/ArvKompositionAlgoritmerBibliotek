using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvKompositionAlgoritmerBibliotek
{
    public class LibraryItem : ISearchable//Jag valde inheritance för att bok, film bla.a är ett library item inte en dal av det
    {
        public string title;
        public string author;
        public string description;
        public int publishedYear;
        public bool isAvailable;

        public string GetInfo()
        {
            string newInfo;
            newInfo = ($"title: {title}, author: {author}, published in the year: {publishedYear}\n");
            if (isAvailable)
            {
                newInfo += ("Title is available\n");
            }
            else
            {
                newInfo += ("Title is not available\n");
            }
            newInfo += (description);
            return newInfo;
        }

        public bool Matches(string searchItem)
        {
            if (title.Contains(searchItem) || author.Contains(searchItem))
            {
                return true;
            }
            return false;
        }


    }
}
