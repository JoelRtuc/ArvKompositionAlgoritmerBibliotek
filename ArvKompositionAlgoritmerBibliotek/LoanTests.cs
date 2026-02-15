using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArvKompositionAlgoritmerBibliotek
{
    public class LoanTests
    {
        [Fact]
        public void IsOverdue_ShouldReturnFalse_WhenDueDateIsInFuture()
        {
            // Arrange
            var book = new Book(123, "Test", "desc", "Author", 2024, true);
            var member = new Member("M001", "Test Person", "test@test.com", Convert.ToDateTime("02/14/2026"));
            var loan = new Loan(book, member, Convert.ToDateTime("02/14/2026"), new ClassManager());

            // Act & Assert
            Assert.False(loan.OverdueFunc());
        }

        [Fact]
        public void OverdueFunc_ShouldReturnTrue_WhenDueDateHasPassed()
        {
            //Arrange
            var book = new Book(123, "Test", "desc", "Author", 2024, true);
            var member = new Member("M001", "Test Person", "test@test.com", Convert.ToDateTime("02/14/2026"));
            var loan = new Loan(book, member, Convert.ToDateTime("02/14/2026"), new ClassManager());
            loan.returnDate = Convert.ToDateTime("02/14/2026").AddDays(-14);

            // Act & Assert
            Assert.True(loan.dueDate > loan.returnDate);
        }

        [Fact]
        public void IsReturned_ShouldReturnTrue_WhenReturnDateIsSet()
        {
            //Arrange
            var book = new Book(123, "Test", "desc", "Author", 2024, true);
            var member = new Member("M001", "Test Person", "test@test.com", Convert.ToDateTime("02/14/2026"));
            ClassManager manager = new ClassManager();
            Loan loan = new Loan(book, member, Convert.ToDateTime("02/14/2026"), manager);
            loan.Return(book, manager);

            //Act and Arrange
            Assert.True(loan.isReturned);
        }

        [Fact]
        public void WhatBooksLoaned_ShouldReturnLoanedAmount_OnceLoaned()
        {
            //Arrange
            LibraryItem[] books = { new Book(123, "Test", "desc", "Author", 2024, true),
            new Book(123, "Test1", "desc", "Author1", 2024, true),
            new Book(123, "Test2", "desc", "Author2", 2024, true)
            };
        
            var member = new Member("M001", "Test Person", "test@test.com", Convert.ToDateTime("02/14/2026"));
            ClassManager manager = new ClassManager();
            Loan loan = new Loan(books[0], member, Convert.ToDateTime("02/14/2026"), manager);

            //Act And Assert
            Assert.Equal(3, books.Length);
            Assert.Equal(1, manager.WhatBooksLoaned(books));
        }
    }
}
