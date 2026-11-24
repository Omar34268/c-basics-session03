string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

PrintFirstBook();

void PrintFirstBook()
{
    if (books.Length == 0)
    {
        return;
    }
    Console.WriteLine(books[0]);
}
