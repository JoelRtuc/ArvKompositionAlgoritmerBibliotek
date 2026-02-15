using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvKompositionAlgoritmerBibliotek
{
    public class Loan
    {
        public LibraryItem item;//instead of books
        public Member member;
        public bool isOverdue;
        public bool isReturned;
        public DateTime loanDate, dueDate, returnDate;

        public Loan(LibraryItem item, Member member, DateTime loanDate, ClassManager manager) 
        {
            this.item = item;
            this.member = member;
            member.loans.Add(this);
            this.loanDate = loanDate;
            dueDate = returnDueDate();
            manager.allLoans.Add(this);
            item.isAvailable = false;
        }

        DateTime returnDueDate()
        {
            DateTime newDate = loanDate.AddDays(14);
            return newDate;
        }

        public bool OverdueFunc()
        {
            if(dueDate > loanDate)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Return(Book book, ClassManager manager)
        {
            isReturned = true;
            manager.allLoans.Remove(this);
            book.isAvailable = true;
        }

    }
}
