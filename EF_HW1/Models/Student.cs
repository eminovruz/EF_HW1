using EF_HW1.Enums;

namespace EF_HW1.Models;

public class Student : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int School { get; set; }
    public Gender Gender { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Phone { get; set; }

    public List<Book>? Books { get; set; }

}



