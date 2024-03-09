using Domain;

namespace Infrastructure;

public interface ILibrary
{
    void AddBook(Book book);    
    List<Book> DisplayBooks();
    void UpdateBook(int id, Book updatedBook);
    void DeleteBook(int id);
    Book SearchByTitle(string title);
    List<Book> SearchByAuthor(string author);

}
