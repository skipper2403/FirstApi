using System.ComponentModel.DataAnnotations;

namespace FirstRepositoryPatternApi.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string BookName { get; set; }

        [Required]
        public string WriterName { get; set; }
        
        [Required]
        public DateTime PublishDate { get; set; }
    }
}
