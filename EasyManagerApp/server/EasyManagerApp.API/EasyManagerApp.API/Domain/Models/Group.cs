namespace EasyManagerApp.API.Domain.Models
{
    public class Group : BaseModel
    {
        public int Id { get; set; }
        public string GroupName { get; set; } = string.Empty;
    }
}
