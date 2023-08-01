using aasignment20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch;
            do
            {
                Console.WriteLine("1.Add a Book \n2.View all Books \n3.Search by Id \n4.Search by Title \n5.Exit the program");
                int op = int.Parse(Console.ReadLine());
                Library library = new Library();
                switch (op)
                {
                    case 1:
                        {
                            Book book = new Book();
                            Console.WriteLine("Enter Book Id: ");
                            book.BookId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Title: ");
                            book.Title = Console.ReadLine();
                            Console.WriteLine("Enter Author: ");
                            book.Author = Console.ReadLine();
                            Console.WriteLine("Enter Genre: ");
                            book.Genre = Console.ReadLine();
                            Console.WriteLine("Enter is Available: ");
                            book.IsAvailable = bool.Parse(Console.ReadLine());
                            library.AddBook(book);
                            break;
                        }
                    case 2:
                        {
                            library.ViewAllBook();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("ENter id to search: ");
                            int id = int.Parse(Console.ReadLine());
                            library.SearchBookById(id);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter title to search: ");
                            string title = Console.ReadLine();
                            library.SearchBookByTitle(title);
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice!!");
                            break;
                        }
                }
                Console.WriteLine("Do you Want to Continue? ");
                ch = Console.ReadLine().ToLower();
            } while (ch == "y");
            Console.ReadKey();
        }
    }
}