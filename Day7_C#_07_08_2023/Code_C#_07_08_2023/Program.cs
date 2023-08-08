using System;
using SampleProgram;
using System.Collections;


namespace SampleProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new(101, "The Love", " Sanjai", true);
            Book book2 = new(102, "The Thunder", "Harsha", true);
            Book book3 = new(103, "The Avenger", "Yogi", false);
            Book book4 = new(104, "Infinity Wars", "JK", true);

            Library.book.Add(book1);
            Library.book.Add(book2);
            Library.book.Add(book3);
            Library.book.Add(book4);

            Library library = new Library();
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("Choose the option\n1.Borrow Book\n2.Return Book\n3.Display Books\n4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the title of the book to borrow");
                    string title = Console.ReadLine();
                    Console.WriteLine(title);
                    library.BorrowBook(title);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the title of the book to return");
                    string title = Console.ReadLine();
                    library.ReturnBook(title);
                }
                else if (choice == 3)
                {
                    library.DisplayBookDetails();
                }
                else if (choice == 4)
                {
                    break;
                }


            }
        }
    }
}