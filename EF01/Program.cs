
//using Bookstore;
//using Microsoft.EntityFrameworkCore;

//using var context = new BookstoreContext();

//context.Database.Migrate();

//Console.WriteLine(
//    $"Can connect: {context.Database.CanConnect()}");

//// 1. Display database tables and columns

//var conn = context.Database.GetDbConnection();
//conn.Open();

//using (var cmd = conn.CreateCommand())
//{
//    cmd.CommandText = @"
//        SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, IS_NULLABLE
//        FROM INFORMATION_SCHEMA.COLUMNS
//        WHERE TABLE_NAME <> '__EFMigrationsHistory'
//        ORDER BY TABLE_NAME, ORDINAL_POSITION";

//    using var reader = cmd.ExecuteReader();

//    while (reader.Read())
//    {
//        Console.WriteLine(
//            $"{reader["TABLE_NAME"],-12} " +
//            $"{reader["COLUMN_NAME"],-16} " +
//            $"{reader["DATA_TYPE"],-10} " +
//            $"nullable={reader["IS_NULLABLE"]}");
//    }
//}

//conn.Close();

//// 2. Insert sample data

//if (!context.Books.Any())
//{
//    var author = new Author
//    {
//        FirstName = "Naguib",
//        LastName = "Mahfouz",
//        Email = "n.mahfouz@books.com",
//        Biography = "Nobel laureate novelist.",
//        DateOfBirth = new DateTime(1911, 12, 11)
//    };

//    var category = new Category
//    {
//        Name = "Fiction",
//        Description = "Novels and stories",
//        IsActive = true
//    };

//    context.Books.Add(new Book
//    {
//        Title = "Palace Walk",
//        ISBN = "9780385264662",
//        Price = 250.50m,
//        NumberOfPages = 498,
//        PublishedYear = 1956,
//        IsInStock = true,
//        Author = author,
//        Category = category
//    });

//    context.SaveChanges();
//}

//// 3. Read and display books

//foreach (var b in context.Books
//    .Include(b => b.Author)
//    .Include(b => b.Category))
//{
//    Console.WriteLine(
//        $"{b.Title} by {b.Author.FirstName} " +
//        $"{b.Author.LastName} [{b.Category.Name}] - {b.Price}");
//}
