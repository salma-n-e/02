using System;
// 1st answer
class Book
{

    public string Title;
    public int Pages;
}
class program
{
    static void Main()
    {
        Book book = new Book();
        book.Title = "english";
        book.Pages = 10;
        object obj = book;
        Console.WriteLine(obj);
    }
}