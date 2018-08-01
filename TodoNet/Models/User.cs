using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoNet.Models
{
    public class User
    {
        public int Id { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Please enter name")]
        [MinLength(4, ErrorMessage = "The name must be at least 4 characters")]
        [MaxLength(60, ErrorMessage = "The name may not be greater than 60 characters")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public List<Todo> Todos { get; set; } = new List<Todo>();
    }

    public class Login
    {
        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class Register
    {
        [DisplayName("Name")]
        [Required(ErrorMessage = "Please enter name")]
        [MinLength(4, ErrorMessage = "The name must be at least 4 characters")]
        [MaxLength(60, ErrorMessage = "The name may not be greater than 60 characters")]
        public string Name { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password confirmation does not match")]
        public string ConfirmPassword { get; set; }
    }
}