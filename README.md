# ArvKompositionAlgoritmerBibliotek

A small .NET 9/C# library and sample console app demonstrating inheritance, composition, and simple search/sort logic for library items (Book, Movie, Magazine), members and loans. Includes unit tests that exercise search, loan and statistics behaviors.

## Features
- Domain types: Book, Movie, Magazine, Member, Loan, LibraryItem
- Manager for search, sorting and statistics: ClassManager
- ISearchable-based matching
- Unit tests covering core scenarios

## Requirements
- .NET 9 SDK
- C# 13
- Visual Studio 2022+ or any editor with dotnet CLI

## Build & run
- Restore & build: dotnet restore && dotnet build
- Run console app: dotnet run --project ArvKompositionAlgoritmerBibliotek
- Run tests: dotnet test

In Visual Studio, open the solution, set the startup project in __Solution Explorer__, and run tests via __Test Explorer__.

## Notes
- If the compiler reports multiple entry points (CS0017), ensure only one `Main` exists or set the entry type explicitly when building.
- Tests and example data live alongside implementation in the repository.
