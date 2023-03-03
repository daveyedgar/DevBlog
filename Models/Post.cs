using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevBlog.Models
{
    public class Post
    {
        public int Id { get; set; }


        [Display(Name = "Blog Name")]
        public int BlogId { get; set; }
        public string AuthorId { get; set; }


        [Required]
        [StringLength(75, ErrorMessage = "The {0} must be betwen {2} and {1} characters.", MinimumLength = 2)]
        public string Title { get; set; }


        [Required]
        [StringLength(200, ErrorMessage = "The {0} must be betwen {2} and {1} characters.", MinimumLength = 2)]
        public string Abstract { get; set; }

        [Required]
        public string Content { get; set; }



        [Display(Name = "Date Created")]
        public DateTime Created { get; set; } = DateTime.Now;


        [Display(Name = "Date Updated")]
        public DateTime? Updated { get; set; }

        public bool IsReady { get; set; }
        public string Slug { get; set; }


        [Display(Name = "Post Image")]
        public byte[]? ImageData { get; set; }

        [Display(Name = "Image Type")]
        public string? ContentType { get; set; }

        [NotMapped]
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public IFormFile? Image { get; set; }

        //Navigation
        public virtual Blog Blog { get; set; }
        public virtual IdentityUser Author { get; set; }

        public ICollection<Tag> Tags { get; set; } = new HashSet<Tag>();
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
