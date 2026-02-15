using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvKompositionAlgoritmerBibliotek
{
    public class Magazine : LibraryItem
    {
        private readonly int magazineId; //jag brukar inte skriva private men jag gör det här så du inte tror att jag tror att readonly är en typ av inkapsling
        public int issue;
        public string company;

        public Magazine(int ISBN, string title, string description, string author, int publishedYear, bool isAvailable, int issue, string company)
        {
            magazineId = ISBN;
            base.title = title;
            base.description = description;
            base.publishedYear = publishedYear;
            base.isAvailable = isAvailable;
            base.author = author;
            this.issue = issue;
            this.company = company;
        }
    }
}
