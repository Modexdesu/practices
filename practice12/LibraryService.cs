using System;

public static class LibraryService
{
    public static void BorrowBook(int memberId, int bookId)
    {
        // id check
        Member member = MemberService.GetMemberById(memberId);
        if (member == null)
        {
            Console.WriteLine("Member not found");
            return;
        }

        // Step 2: id find
        Book book = BookService.GetBookById(bookId);
        if (book == null)
        {
            Console.WriteLine("Book not found");
            return;
        }

        // Step 3: aris tu ara wigni
        if (book.IsBorrowed)
        {
            Console.WriteLine("Book is already borrowed");
            return;
        }

        // Step 4: status
        book.IsBorrowed = true;
        book.BorrowedByMemberId = memberId;

        // Step 5: es debugistvis
        Console.WriteLine("Book borrowed successfully");
    }

    public static void ReturnBook(int bookId)
    {
     
        Book book = BookService.GetBookById(bookId);
        if (book == null)
        {
            Console.WriteLine("Book not found");
            return;
        }

       
        if (!book.IsBorrowed)
        {
            Console.WriteLine("Book is not borrowed");
            return;
        }

   
        book.IsBorrowed = false;
        book.BorrowedByMemberId = null;

      
        Console.WriteLine("Book returned successfully");
    }
}
