string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

foreach (string book in books)
{
    if (book == "The Pragmatic Programmer")
    {
        continue;
    }
    Console.WriteLine(book);
}
