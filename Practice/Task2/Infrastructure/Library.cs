using Domain;

namespace Infrastructure;

public class Library : ILibrary
{
    List<Book> _books = new List<Book>();
    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void DeleteBook(int id)
    {
        var deleted = _books.FirstOrDefault(e=> e.Id == id);
        if (deleted != null)
        {
            _books.Remove(deleted);
        }else
        {
            System.Console.WriteLine("Book has been not founded");
        }
    }

    public List<Book> DisplayBooks()
    {
        return _books;
    }

    public List<Book> SearchByAuthor(string author)
    {
       var auth = _books.FindAll(e=> e.Author == author);
       return auth;
    }

    public Book SearchByTitle(string title)
    {
        var titl = _books.FirstOrDefault(e=> e.Title == title);
        return titl;
    }

    public void UpdateBook(int id, Book updatedBook)
    {
        var updBook = _books.FirstOrDefault(e=> e.Id == id);
        if (updBook != null)
        {
            updBook.Title = updatedBook.Title;
            updBook.Author = updatedBook.Author;
        }else
        {
            System.Console.WriteLine("Book with this ID is not Founded: ");
        }
    }
}
