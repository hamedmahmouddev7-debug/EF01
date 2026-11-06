
//namespace Bookstore;

//public class Book
//{
//    public int Id { get; set; }
//    public string Title { get; set; } = string.Empty;
//    public string ISBN { get; set; } = string.Empty;
//    public decimal Price { get; set; }
//    public int NumberOfPages { get; set; }
//    public int PublishedYear { get; set; }
//    public bool IsInStock { get; set; }

//    public int AuthorId { get; set; }
//    public Author Author { get; set; } = null!;

//    public int CategoryId { get; set; }
//    public Category Category { get; set; } = null!;
//}

//public class Author
//{
//    public int Id { get; set; }
//    public string FirstName { get; set; } = string.Empty;
//    public string LastName { get; set; } = string.Empty;
//    public string Email { get; set; } = string.Empty;
//    public string Biography { get; set; } = string.Empty;
//    public DateTime DateOfBirth { get; set; }

//    public ICollection<Book> Books { get; set; }
//        = new List<Book>();
//}

//public class Category
//{
//    public int Id { get; set; }
//    public string Name { get; set; } = string.Empty;
//    public string Description { get; set; } = string.Empty;
//    public bool IsActive { get; set; }

//    public ICollection<Book> Books { get; set; }
//        = new List<Book>();
//}
