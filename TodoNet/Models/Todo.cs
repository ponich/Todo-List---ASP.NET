using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoNet.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "Please enter title")]
        [MinLength(4, ErrorMessage = "The title must be at least 4 characters")]
        [MaxLength(60, ErrorMessage = "The title may not be greater than 60 characters")]
        public string Title { get; set; }

        [DisplayName("Content")]
        [Required(ErrorMessage = "Please enter content")]
        [MinLength(8, ErrorMessage = "The title must be at least 8 characters")]
        public string Content { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "Please choose status")]
        [Range(0, 1, ErrorMessage = "Invalid status")]
        [DefaultValue(0)]
        public bool Status { get; set; }

        public User User { get; set; }
    }
}