
using System.Collections.Generic;
using Domain;
using Infrastructure;

try
{
   Library libs = new Library();
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("Write 1. Add book");
            Console.WriteLine("Write 2. Show books");
            Console.WriteLine("Write 3. Update book");
            Console.WriteLine("Write 4. Delete Book");
            Console.WriteLine("Write 5. Search by Title");
            Console.WriteLine("Write 6. Search by Author");
            Console.Write("Choose option: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Write Id book: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write Title Book: ");
                    string title = Console.ReadLine();
                    Console.Write("Write Autor Book ");
                    string author = Console.ReadLine();
                    libs.AddBook( new Book { Id = id, Title = title, Author = author });
                    break;
                case 2:
                        foreach (var it in libs.DisplayBooks())
                        {
                            System.Console.WriteLine($"Id: {it.Id}");
                            System.Console.WriteLine($"Title: {it.Title}");
                            System.Console.WriteLine($"Author: {it.Author}");

                        }
                    break;
                case 3:
                    Console.Write("Write Id Book for Updating: ");
                    int idUpd = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write new Title : ");
                    string newTitle = Console.ReadLine();
                    Console.Write("Write new Author Book: : ");
                    string newAuthor = Console.ReadLine();
                    libs.UpdateBook(idUpd, new Book { Title = newTitle, Author = newAuthor });
                    break;
                case 4:
                    Console.Write("Write Id For Deleting Book: ");
                    int idToDelete = Convert.ToInt32(Console.ReadLine());
                    libs.DeleteBook(idToDelete);
                    break;
                case 5:
                    Console.Write("Write Title for Search by Title: ");
                    string searchTitle = Console.ReadLine();
                    var resByTitle = libs.SearchByTitle(searchTitle);

if (resByTitle != null)
                    {
                        Console.WriteLine($"Find Book: Id: {resByTitle.Id}, Title: {resByTitle.Title}, Author: {resByTitle.Author}");
                    }
                    else
                    {
                        Console.WriteLine("Book has not Found: ");
                    }
                    break;
                case 6:
                    Console.Write("Write Name Author for Search by Author: ");
                    string searchAuthor = Console.ReadLine();
                    var resByAuthor = libs.SearchByAuthor(searchAuthor);
                    if (resByAuthor.Count > 0)
                    {
                        Console.WriteLine("Find Books");
                        foreach (var book in resByAuthor)
                        {
                            Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Kitobxoi xami Author has not Found: ");
                    }
                    break;
                case 7:
                    

                default:
                    Console.WriteLine("Erorr ne verniy Vvod: ");
                    break;
            }
        }
 
 
}
catch (System.Exception)
{
    
        System.Console.WriteLine("Ne verniy format: ");
}
