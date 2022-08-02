using Arabitey.ViewModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arabitey.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Text is required")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Name Of Brand is required")]
        [MinLength(3, ErrorMessage = "UserName must be more than 3 characters")]
        [MaxLength(30, ErrorMessage = "UserName  must be less than 30 characters")]
        public string UserName { get; set; }

        [ForeignKey("post")]
        public int postId { get; set; }
        public virtual Post post { get; set; }
    }
}
