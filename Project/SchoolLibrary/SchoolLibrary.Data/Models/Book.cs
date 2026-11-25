namespace SchoolLibrary.Data.Models;

public class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;
    // с get, set и начална стойност празен низ.
    public bool IsBorrowed { get; set; }
}