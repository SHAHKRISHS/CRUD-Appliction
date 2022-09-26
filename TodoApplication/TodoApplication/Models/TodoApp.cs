using System.ComponentModel.DataAnnotations;

namespace TodoApplication.Models
{
    public class TodoApp
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? EmailId { get; set; }

        [Required]
        public string? Number { get; set; }
    }
}
