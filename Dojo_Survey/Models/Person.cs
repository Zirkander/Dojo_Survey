using System.ComponentModel.DataAnnotations;
namespace Dojo_Survey.Models
{
    public class Person
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
        public string Location { get; set; }
        public string Language { get; set; }
        [MaxLength(20)]
        public string Comment { get; set; }
        [Required]
        [MinLength(5)]
        [RegularExpression(@"[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$", ErrorMessage = "Email is invalid, please enter a vaild Email.")]
        public string Email { get; set; }


    }
}