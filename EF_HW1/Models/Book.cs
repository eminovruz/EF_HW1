using Microsoft.EntityFrameworkCore;

namespace EF_HW1.Models;

public class Book : BaseEntity
{
    public string? Name { get; set; }
    public int Page { get; set; }
    public int ThemeId { get; set; }
    public int StudentId { get; set; }

    public Theme? Theme { get; set; }
    public List<Author>? Authors { get; set; }
    public Student? Student { get; set; }


}
