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
     //2 answer
    Console.WriteLine(book.ToString());
        Console.WriteLine(book.Equals(book));
        Console.WriteLine(book.GetHashCode());
        Console.WriteLine(book.GetType());

        // 3
        //int pages = "464"; is a string and cannot initlize it to an int;
        // int pages = 464;


        // 4 
        try
        {

            int zero = 0;
            int result = 10 / zero;

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally { Console.WriteLine("Done"); }
    }
}