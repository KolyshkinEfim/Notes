using System.ComponentModel.DataAnnotations;

namespace learnASP.NET_CORE_mvc.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreationDateTime { get; set; } = DateTime.Now;
    }
}
    