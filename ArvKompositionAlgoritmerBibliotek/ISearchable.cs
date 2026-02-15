using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvKompositionAlgoritmerBibliotek
{
    public interface ISearchable
    {
        bool Matches(string searchTerm);
    }
}
