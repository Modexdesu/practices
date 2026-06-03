using System;

public static class BookService
{
    private static Book[] books = new Book[100];
    private static int bookCount = 0;

    public static void Initialize()
    {
        Book[] initialBooks = new Book[10]
        { //eseni ai chamovawerine wera damezara xelit
            new Book { Id = 1, Title = "Clean Code", Author = "Robert Martin", Genre = "Programming", PublishedYear = 2008, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Genre = "Programming", PublishedYear = 1999, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 3, Title = "Design Patterns", Author = "Erich Gamma", Genre = "Programming", PublishedYear = 1994, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 4, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy", PublishedYear = 1937, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 5, Title = "1984", Author = "George Orwell", Genre = "Dystopian", PublishedYear = 1949, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 6, Title = "Atomic Habits", Author = "James Clear", Genre = "Self Development", PublishedYear = 2018, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 7, Title = "Deep Work", Author = "Cal Newport", Genre = "Productivity", PublishedYear = 2016, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 8, Title = "Rich Dad Poor Dad", Author = "Robert Kiyosaki", Genre = "Finance", PublishedYear = 1997, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 9, Title = "The Alchemist", Author = "Paulo Coelho", Genre = "Novel", PublishedYear = 1988, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 10, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic", PublishedYear = 1960, IsBorrowed = false, BorrowedByMemberId = null }
        };

        for (int i = 0; i < 10; i++)
        {
            books[i] = initialBooks[i];
        }
        bookCount = 10;
    }

    public static void AddBook(string title, string author, string genre, int publishedYear)
    {
        if (bookCount >= 100)
        {
            Console.WriteLine("Cannot add more books. Maximum capacity reached.");
            return;
        }

        int newId = bookCount > 0 ? books[bookCount - 1].Id + 1 : 1;

        Book newBook = new Book
        {
            Id = newId,
            Title = title,
            Author = author,
            Genre = genre,
            PublishedYear = publishedYear,
            IsBorrowed = false,
            BorrowedByMemberId = null
        };

        books[bookCount] = newBook;
        bookCount++;
        Console.WriteLine($"Book '{title}' added successfully with ID: {newId}");
    }

    public static void GetAllBooks()
    {
        if (bookCount == 0)
        {
            Console.WriteLine("No books found.");
            return;
        }

        Console.WriteLine("\n=== All Books ===");
        for (int i = 0; i < bookCount; i++)
        {
            if (books[i] != null)
            {
                books[i].PrintInfo();
            }
        }
    }

    public static void UpdateBook(int id)
    {
        Book bookToUpdate = FindBookById(id);
        if (bookToUpdate == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        Console.WriteLine("\nWhat would you like to update?");
        Console.WriteLine("1. Title");
        Console.WriteLine("2. Author");
        Console.WriteLine("3. Genre");
        Console.WriteLine("4. Published Year");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter new Title: ");
                bookToUpdate.Title = Console.ReadLine();
                break;
            case "2":
                Console.Write("Enter new Author: ");
                bookToUpdate.Author = Console.ReadLine();
                break;
            case "3":
                Console.Write("Enter new Genre: ");
                bookToUpdate.Genre = Console.ReadLine();
                break;
            case "4":
                Console.Write("Enter new Published Year: ");
                if (int.TryParse(Console.ReadLine(), out int year))
                {
                    bookToUpdate.PublishedYear = year;
                }
                else
                {
                    Console.WriteLine("Invalid year input.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine("Book updated successfully.");
    }

    public static void DeleteBook(int id)
    {
        int indexToDelete = -1;
        for (int i = 0; i < bookCount; i++)
        {
            if (books[i] != null && books[i].Id == id)
            {
                indexToDelete = i;
                break;
            }
        }

        if (indexToDelete == -1)
        {
            Console.WriteLine("Book not found.");
            return;
        }

      
        for (int i = indexToDelete; i < bookCount - 1; i++)
        {
            books[i] = books[i + 1];
        }

        books[bookCount - 1] = null;
        bookCount--;
        Console.WriteLine("Book deleted successfully.");
    }

    private static Book FindBookById(int id)
    {
        for (int i = 0; i < bookCount; i++)
        {
            if (books[i] != null && books[i].Id == id)
            {
                return books[i];
            }
        }
        return null;
    }

    public static Book GetBookById(int id)
    {
        return FindBookById(id);
    }

    public static int GetBookCount()
    {
        return bookCount;
    }

    public static Book[] GetBooksArray()
    {
        return books;
    }
}
