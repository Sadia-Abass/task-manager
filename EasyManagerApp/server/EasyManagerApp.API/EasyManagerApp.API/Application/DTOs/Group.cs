using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyManagerApp.API.Application.DTOs
{
    public class Group
    {
        public int Id { get; set; }

        [Display(Name = "Group Name")]
        [Required(ErrorMessage = "{0} is required." )]
        [StringLength(128, ErrorMessage = "{0} cannot be more than {1} characters.")]
        public string GroupName { get; set; } = string.Empty;

        [Display(Name = "Created Date")]
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
    }
}
