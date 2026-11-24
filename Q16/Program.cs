string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

foreach (string book in books)
{
    if (book == "Refactoring")
    {
        break;
    }
    Console.WriteLine(book);
}
