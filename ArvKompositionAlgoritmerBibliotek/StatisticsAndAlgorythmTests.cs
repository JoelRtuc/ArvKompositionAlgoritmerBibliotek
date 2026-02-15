using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArvKompositionAlgoritmerBibliotek
{
    public class StatisticsAndAlgorythmTests
    {
        [Fact]
        public void AllBooks_ShouldReturnCorrectCount()
        {
            //Arrange and Act
            ClassManager classManager = new ClassManager();
            LibraryItem[] libraryItems = {
            new Book(978 - 91 - 0 - 012345 - 6, "Testbok", "TestBeskrivning", "Testförfattare", 2024, true),
            new Book(978 - 91 - 0 - 012345 - 6, "Testbok", "TestBeskrivning", "Testförfattare", 2024, true),
            new Book(978 - 91 - 0 - 012345 - 6, "Testbok", "TestBeskrivning", "Testförfattare", 2024, true)
            };


            Assert.Empty(classManager.allLoans);
            Assert.Equal(3, classManager.AllBooks(libraryItems));
        }

        [Fact]
        public void GetBorrowedBooksCount_ShouldReturnCorrectCount()
        {
            //Arrange and Act
            ClassManager classManager = new ClassManager();
            Book book1 = new Book(978 - 91 - 0 - 012345 - 6, "Testbok", "TestBeskrivning", "Testförfattare", 2024, true);
            Book book2 = new Book(978 - 91 - 0 - 012345 - 6, "Testbok", "TestBeskrivning", "Testförfattare", 2024, true);
            Book book3 = new Book(978 - 91 - 0 - 012345 - 6, "Testbok", "TestBeskrivning", "Testförfattare", 2024, true);
            var member1 = new Member("M001", "Test Person", "test@test.com", Convert.ToDateTime("02/14/2026"));
            var member2 = new Member("M001", "Test Person", "test@test.com", Convert.ToDateTime("02/14/2026"));
            var member3 = new Member("M001", "Test Person", "test@test.com", Convert.ToDateTime("02/14/2026"));
            Loan loan1 = new Loan(book1, member1, Convert.ToDateTime("02/14/2026"), classManager);
            Loan loan2 = new Loan(book2, member2, Convert.ToDateTime("02/14/2026"), classManager);
            Loan loan3 = new Loan(book3, member3, Convert.ToDateTime("02/14/2026"), classManager);

            //Assert
            Assert.Equal(3, classManager.allLoans.Count);

        }

        [Fact]
        public void ProlificLoaner_ShouldReturnMemberWithMostLoans()
        {
            //Arrange and Act
            ClassManager classManager = new ClassManager();
            Book book1 = new Book(978 - 91 - 0 - 012345 - 6, "Testbok", "TestBeskrivning", "Testförfattare", 2024, true);
            Book book2 = new Book(978 - 91 - 0 - 012345 - 6, "Testbok", "TestBeskrivning", "Testförfattare", 2024, true);
            Book book3 = new Book(978 - 91 - 0 - 012345 - 6, "Testbok", "TestBeskrivning", "Testförfattare", 2024, true);
            Member[] members = {
                new Member("M001", "Test Person", "test@test.com", Convert.ToDateTime("02/14/2026")),
                new Member("M001", "Test Person", "test@test.com", Convert.ToDateTime("02/14/2026")),
                new Member("M001", "Test Person", "test@test.com", Convert.ToDateTime("02/14/2026"))
            };
            Loan loan1 = new Loan(book1, members[0], Convert.ToDateTime("02/14/2026"), classManager);
            Loan loan2 = new Loan(book2, members[0], Convert.ToDateTime("02/14/2026"), classManager);
            Loan loan3 = new Loan(book3, members[2], Convert.ToDateTime("02/14/2026"), classManager);

            Assert.Equal(members[0], classManager.ProlificLoaner(members));
        }

        [Fact]
        public void SortBooksByPublishedYear_ShouldReturnNewToOld()
        {
            //Arrange and Act
            ClassManager classManager = new ClassManager();
            LibraryItem[] libraryItems = {
            new Book(978 - 91 - 0 - 012345 - 6, "Testbok1", "TestBeskrivning1", "Testförfattare1", 2024, true),
            new Book(978 - 91 - 0 - 012345 - 6, "Testbok2", "TestBeskrivning2", "Testförfattare2", 2023, true),
            new Book(978 - 91 - 0 - 012345 - 6, "Testbok3", "TestBeskrivning3", "Testförfattare3", 2022, true)
            };

            classManager.SortListByYear(libraryItems.ToList());
        }
    }
}
