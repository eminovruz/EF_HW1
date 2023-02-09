using EF_HW1.Enums;

namespace EF_HW1.Models;

public class BaseEntity
{
    public int Id { get; set; }
    public Status? Status { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set;}


    public BaseEntity()
    {
        CreatedDate= DateTime.Now;
        Status = Enums.Status.Inserted;
    }
}


