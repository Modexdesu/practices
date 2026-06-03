using System;

public class Member
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string PersonalNumber { get; set; }
    public DateTime CreatedOn { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Personal Number: {PersonalNumber}");
        Console.WriteLine($"Created On: {CreatedOn.ToShortDateString()}");
        Console.WriteLine(new string('-', 50));
    }
}
