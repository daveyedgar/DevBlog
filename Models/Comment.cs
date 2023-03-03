using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DevBlog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string AuthorId { get; set; }
        public string ModeratorId { get; set; }


        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be betwen {2} and {1} characters.", MinimumLength = 2)]
        [Display(Name = "Comment")]
        public string Body { get; set; }


        [Display(Name = "Date Created")]
        public DateTime Created { get; set; } = DateTime.Now;

        [Display(Name = "Date Updated")]
        public DateTime? Updated { get; set; }

        [Display(Name = "Date Moderated")]
        public DateTime? Moderated { get; set; }


        [Display(Name = "Date Deleted")]
        public DateTime? Deleted { get; set; }



        [StringLength(500, ErrorMessage = "The {0} must be betwen {2} and {1} characters.", MinimumLength = 2)]
        [Display(Name = "Moderated Comment")]
        public string ModeratedBody { get; set; }

        // Navigation
        public virtual Post Post { get; set; }
        public virtual IdentityUser Author { get; set; }
        public virtual IdentityUser Moderator { get; set; }

    }
}
