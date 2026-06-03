using System;

public static class MemberService
{
    private static Member[] members = new Member[100];
    private static int memberCount = 0;

    public static void Initialize()
    {
        // init
        Member initialMember = new Member
        {
            Id = 1,
            FirstName = "Giorgi",
            LastName = "Beridze",
            Age = 30,
            Email = "giorgi@example.com",
            PersonalNumber = "12345678901",
            CreatedOn = DateTime.Now
        };

        members[0] = initialMember;
        memberCount = 1;
    }

    public static void AddMember(string firstName, string lastName, int age, string email, string personalNumber)
    {
        if (memberCount >= 100)
        {
            Console.WriteLine("Cannot add more members. Maximum capacity reached.");
            return;
        }

        int newId = memberCount > 0 ? members[memberCount - 1].Id + 1 : 1;

        Member newMember = new Member
        {
            Id = newId,
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            Email = email,
            PersonalNumber = personalNumber,
            CreatedOn = DateTime.Now
        };

        members[memberCount] = newMember;
        memberCount++;
        Console.WriteLine($"Member '{firstName} {lastName}' added successfully with ID: {newId}");
    }

    public static void GetAllMembers()
    {
        if (memberCount == 0)
        {
            Console.WriteLine("No members found.");
            return;
        }

        Console.WriteLine("\n=== All Members ===");
        for (int i = 0; i < memberCount; i++)
        {
            if (members[i] != null)
            {
                members[i].PrintInfo();
            }
        }
    }

    public static void UpdateMember(int id)
    {
        Member memberToUpdate = FindMemberById(id);
        if (memberToUpdate == null)
        {
            Console.WriteLine("Member not found.");
            return;
        }

        Console.WriteLine("\nWhat would you like to update?");
        Console.WriteLine("1. First Name");
        Console.WriteLine("2. Last Name");
        Console.WriteLine("3. Age");
        Console.WriteLine("4. Email");
        Console.WriteLine("5. Personal Number");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter new First Name: ");
                memberToUpdate.FirstName = Console.ReadLine();
                break;
            case "2":
                Console.Write("Enter new Last Name: ");
                memberToUpdate.LastName = Console.ReadLine();
                break;
            case "3":
                Console.Write("Enter new Age: ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    memberToUpdate.Age = age;
                }
                else
                {
                    Console.WriteLine("Invalid age input.");
                    return;
                }
                break;
            case "4":
                Console.Write("Enter new Email: ");
                memberToUpdate.Email = Console.ReadLine();
                break;
            case "5":
                Console.Write("Enter new Personal Number: ");
                memberToUpdate.PersonalNumber = Console.ReadLine();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine("Member updated successfully.");
    }

    public static void DeleteMember(int id)
    {
        int indexToDelete = -1;
        for (int i = 0; i < memberCount; i++)
        {
            if (members[i] != null && members[i].Id == id)
            {
                indexToDelete = i;
                break;
            }
        }

        if (indexToDelete == -1)
        {
            Console.WriteLine("Member not found.");
            return;
        }

       
        for (int i = indexToDelete; i < memberCount - 1; i++)
        {
            members[i] = members[i + 1];
        }

        members[memberCount - 1] = null;
        memberCount--;
        Console.WriteLine("Member deleted successfully.");
    }

    private static Member FindMemberById(int id)
    {
        for (int i = 0; i < memberCount; i++)
        {
            if (members[i] != null && members[i].Id == id)
            {
                return members[i];
            }
        }
        return null;
    }

    public static Member GetMemberById(int id)
    {
        return FindMemberById(id);
    }

    public static int GetMemberCount()
    {
        return memberCount;
    }

    public static Member[] GetMembersArray()
    {
        return members;
    }
}
