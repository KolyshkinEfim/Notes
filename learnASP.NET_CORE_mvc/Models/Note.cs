using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace learnASP.NET_CORE_mvc.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreationDateTime { get; set; } = DateTime.Now;
    }
}
    