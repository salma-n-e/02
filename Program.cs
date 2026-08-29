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

        //5 
        int pages = 300;
        Console.WriteLine(pages);
        double pages2 = pages;
        Console.WriteLine(pages2);


        //6 
        double price = 49.99;
        int prices2 = (int)price;

        //7
        string pagesText = "464";
        int pagesText2 = Convert.ToInt32(pagesText);
        Console.WriteLine(pagesText2);

        //8 
        string yearText = "2023";
        int year = int.Parse(yearText);
        string badText = "abc";
        if (int.TryParse(badText, out int num))
        {
            Console.WriteLine(num);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}