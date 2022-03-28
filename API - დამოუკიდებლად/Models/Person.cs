using System;
using System.ComponentModel.DataAnnotations;

namespace API___დამოუკიდებლად.Models
{
    public class Person
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Firstname can only be 30 charcters long!")]
        public string Firstname { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Lastname can only be 30 charcters long!")]
        public string Lastname { get; set; }

        [Required]
        public int Age { get; set; }

    }
}
