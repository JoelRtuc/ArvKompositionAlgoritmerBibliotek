using ArvKompositionAlgoritmerBibliotek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        ClassManager classManager = new ClassManager();
        LibraryItem[] items = {new Book(12345678901, "Book Title", "Author Authorsson", "hahabook", 1984, true),
        new Book(12345678901, "Book Title sequel", "new newberry", "hahabook", 1984, true),
        new Movie(0, "Movie Title", "hahamovie", "Scorsese", 1985, false, 128, Movie.MovieType.DVD),
        new Magazine(0, "Magazine Title", "hahamagazine", "Carl", 1986, true, 2, "Sports")
        };
        Member[] allMembers = { new Member("ab123", "John Jonas", "John@Jonas", Convert.ToDateTime("05/01/1996")),
        new Member("cd123", "Joel Ringh", "joel.Ringh@", Convert.ToDateTime("05/02/2001")), 
        new Member("ef123", "Erin Svensson", "Erin.wa@wa", Convert.ToDateTime("02/06/2006")), };

        Loan JohnsLoan1 = new Loan(items[0], allMembers[0], DateTime.Now, classManager);
        Loan JohnsLoan2 = new Loan(items[1], allMembers[0], DateTime.Now, classManager);
        Loan ErinsLoan = new Loan(items[2], allMembers[2], DateTime.Now, classManager);

        Console.WriteLine("\nGet Info");
        foreach (LibraryItem item in items)
        {
            Console.WriteLine(item.GetInfo());
        }

        Console.WriteLine("\nSearchClass");
        classManager.SearchClass(items, "Scorsese");

        Console.WriteLine("\nProlific Loaner");
        Console.WriteLine(classManager.ProlificLoaner(allMembers).memberName);

        Console.WriteLine("\nSort List By year");
        foreach (LibraryItem item in classManager.SortListByYear(items.ToList()))
        {
            Console.WriteLine(item.title);
        }

        Console.WriteLine("\nAll Books");
        Console.WriteLine(classManager.AllBooks(items));

        Console.WriteLine("\nWhat Books Loaned");
        Console.WriteLine(classManager.WhatBooksLoaned(items));

    }
}
