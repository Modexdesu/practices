using System;

// Initialize services
MemberService.Initialize();
BookService.Initialize();

bool running = true;

while (running)
{
    Console.WriteLine("\n=== Library Management System ===");
    Console.WriteLine("1. Member Management");
    Console.WriteLine("2. Book Management");
    Console.WriteLine("3. Borrow/Return Books");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            ManageMembersMenu();
            break;
        case "2":
            ManageBooksMenu();
            break;
        case "3":
            ManageBorrowReturnMenu();
            break;
        case "4":
            running = false;
            Console.WriteLine("Thank you for using Library Management System. Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}

void ManageMembersMenu()
{
    bool memberMenuRunning = true;

    while (memberMenuRunning)
    {
        Console.WriteLine("\n=== Member Management ===");
        Console.WriteLine("1. Add Member");
        Console.WriteLine("2. View All Members");
        Console.WriteLine("3. Update Member");
        Console.WriteLine("4. Delete Member");
        Console.WriteLine("5. Back to Main Menu");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter Age: ");
                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.WriteLine("Invalid age input.");
                    break;
                }
                Console.Write("Enter Email: ");
                string email = Console.ReadLine();
                Console.Write("Enter Personal Number: ");
                string personalNumber = Console.ReadLine();

                MemberService.AddMember(firstName, lastName, age, email, personalNumber);
                break;

            case "2":
                MemberService.GetAllMembers();
                break;

            case "3":
                MemberService.GetAllMembers();
                Console.Write("Enter Member ID to update: ");
                if (int.TryParse(Console.ReadLine(), out int memberId))
                {
                    MemberService.UpdateMember(memberId);
                }
                else
                {
                    Console.WriteLine("Invalid ID input.");
                }
                break;

            case "4":
                MemberService.GetAllMembers();
                Console.Write("Enter Member ID to delete: ");
                if (int.TryParse(Console.ReadLine(), out int deleteId))
                {
                    MemberService.DeleteMember(deleteId);
                }
                else
                {
                    Console.WriteLine("Invalid ID input.");
                }
                break;

            case "5":
                memberMenuRunning = false;
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}

void ManageBooksMenu()
{
    bool bookMenuRunning = true;

    while (bookMenuRunning)
    {
        Console.WriteLine("\n=== Book Management ===");
        Console.WriteLine("1. Add Book");
        Console.WriteLine("2. View All Books");
        Console.WriteLine("3. Update Book");
        Console.WriteLine("4. Delete Book");
        Console.WriteLine("5. Back to Main Menu");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter Title: ");
                string title = Console.ReadLine();
                Console.Write("Enter Author: ");
                string author = Console.ReadLine();
                Console.Write("Enter Genre: ");
                string genre = Console.ReadLine();
                Console.Write("Enter Published Year: ");
                if (!int.TryParse(Console.ReadLine(), out int year))
                {
                    Console.WriteLine("Invalid year input.");
                    break;
                }

                BookService.AddBook(title, author, genre, year);
                break;

            case "2":
                BookService.GetAllBooks();
                break;

            case "3":
                BookService.GetAllBooks();
                Console.Write("Enter Book ID to update: ");
                if (int.TryParse(Console.ReadLine(), out int bookId))
                {
                    BookService.UpdateBook(bookId);
                }
                else
                {
                    Console.WriteLine("Invalid ID input.");
                }
                break;

            case "4":
                BookService.GetAllBooks();
                Console.Write("Enter Book ID to delete: ");
                if (int.TryParse(Console.ReadLine(), out int deleteBookId))
                {
                    BookService.DeleteBook(deleteBookId);
                }
                else
                {
                    Console.WriteLine("Invalid ID input.");
                }
                break;

            case "5":
                bookMenuRunning = false;
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}

void ManageBorrowReturnMenu()
{
    bool borrowMenuRunning = true;

    while (borrowMenuRunning)
    {
        Console.WriteLine("\n=== Borrow/Return Books ===");
        Console.WriteLine("1. Borrow Book");
        Console.WriteLine("2. Return Book");
        Console.WriteLine("3. Back to Main Menu");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                MemberService.GetAllMembers();
                Console.Write("Enter Member ID: ");
                if (!int.TryParse(Console.ReadLine(), out int memberId))
                {
                    Console.WriteLine("Invalid Member ID input.");
                    break;
                }

                BookService.GetAllBooks();
                Console.Write("Enter Book ID to borrow: ");
                if (!int.TryParse(Console.ReadLine(), out int bookId))
                {
                    Console.WriteLine("Invalid Book ID input.");
                    break;
                }

                LibraryService.BorrowBook(memberId, bookId);
                break;

            case "2":
                BookService.GetAllBooks();
                Console.Write("Enter Book ID to return: ");
                if (int.TryParse(Console.ReadLine(), out int returnBookId))
                {
                    LibraryService.ReturnBook(returnBookId);
                }
                else
                {
                    Console.WriteLine("Invalid Book ID input.");
                }
                break;

            case "3":
                borrowMenuRunning = false;
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}
