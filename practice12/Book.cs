using System;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int PublishedYear { get; set; }
    public bool IsBorrowed { get; set; }
    public int? BorrowedByMemberId { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Published Year: {PublishedYear}");
        Console.WriteLine($"Status: {(IsBorrowed ? $"Borrowed by Member ID {BorrowedByMemberId}" : "Available")}");
        Console.WriteLine(new string('-', 50));
    }
}
