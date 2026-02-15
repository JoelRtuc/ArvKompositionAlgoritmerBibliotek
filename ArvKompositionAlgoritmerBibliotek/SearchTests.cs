using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArvKompositionAlgoritmerBibliotek
{
    public class SearchTests
    {

        [Theory]
        [InlineData("Tolkien", true)]
        [InlineData("tolkien", false)]  // Case-insensitive?
        [InlineData("Rowling", false)]
        public void Book_Matches_ShouldFindByAuthor(string searchTerm, bool expected)
        {
            // Arrange
            var book = new Book(123, "Sagan om ringen", "Hobbits and stuff", "J.R.R. Tolkien", 1954, true);

            // Act
            var result = book.Matches(searchTerm);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Jerry", false)]
        [InlineData("Fred", false)]
        [InlineData("Patrick", true)]

        public void Member_Matches_ShouldFindByName(string searchTerm, bool expected)
        {
            // Arrange
            var member = new Member("ou123", "Patrick", "Patrick@email", DateTime.Now);

            // Act
            var result = member.Matches(searchTerm);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}
