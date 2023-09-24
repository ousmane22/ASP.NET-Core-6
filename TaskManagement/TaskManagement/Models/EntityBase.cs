using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime YearOfBirth { get; set; }
        public string? PlaceOfBirth { get; set; }
    }
}
