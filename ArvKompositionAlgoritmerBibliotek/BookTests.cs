using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArvKompositionAlgoritmerBibliotek
{
    public class BookTests
    {
        [Fact]
        public void Constructor_ShouldSetPropertiesCorrectly()
        {
            // Arrange & Act
            Book book = new Book(978-91-0-012345-6, "Testbok", "TestBeskrivning" , "Testförfattare", 2024, true);

            // Assert
            Assert.Equal(978-91-0-012345-6, book.ISBN);
            Assert.Equal("Testbok", book.title);
            Assert.True(book.isAvailable);
        }

        [Fact]
        public void IsAvailable_ShouldBeTrueForNewBook()// Testa att nya böcker är tillgängliga
        {
            //Arrange and Act
            Book book = new Book(978 - 91 - 0 - 012345 - 6, "Testbok", "TestBeskrivning", "Testförfattare", 2024, true);
            Book book2 = new Book(978 - 91 - 0 - 012345 - 6, "Testbok", "TestBeskrivning", "Testförfattare", 2024, true);
            Book book3 = new Book(978 - 91 - 0 - 012345 - 6, "Testbok", "TestBeskrivning", "Testförfattare", 2024, true);

            //testade !book.isAvailable för att det måste vara fel först, Assert
            Assert.True(book.isAvailable);
            Assert.True(book2.isAvailable);
            Assert.True(book3.isAvailable);

        }

        [Fact]
        public void GetInfo_ShouldReturnFormattedString()
        {
            //Arrange and Act
            Book book = new Book(978 - 91 - 0 - 012345 - 6, "Testbok", "TestBeskrivning", "Testförfattare", 2024, true);

            //Assert
            Assert.Contains("Testbok", book.GetInfo());
            Assert.Contains("TestBeskrivning", book.GetInfo());
            Assert.Contains("Testförfattare", book.GetInfo());
        }

    }
}
