namespace EasyManagerApp.API.Domain.Models
{
    public class BaseModel
    {
        public DateTimeKind CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
