using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        public int ID { get; set; }

        [MinLength(5)]
        public required string Name { get; set; }

        [RegularExpression(@"^\d{9}$")]
        public required string ContactNumber { get; set; }

        [EmailAddress]
        public required string Email { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}