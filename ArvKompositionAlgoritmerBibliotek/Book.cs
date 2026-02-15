using ArvKompositionAlgoritmerBibliotek;
using System;

public class Book : LibraryItem
{
    public readonly long ISBN;

    public Book(long ISBN, string title, string description, string author, int publishedYear, bool isAvailable)
	{
		this.ISBN = ISBN;
        base.title = title;
        base.description = description;
        base.publishedYear = publishedYear;
        base.isAvailable = isAvailable;
        base.author = author;
	}

}
