using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumApp.Infrastructure.Constants;

namespace ForumApp.Infrastructure.Data.Models
{
    [Comment("All posts table")]
    public class Post
    {
        [Key]
        [Comment("Post identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(ValidationConstants.MaximumTitleLength)]
        [Comment("Post Title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(ValidationConstants.MaximumContentLength)]
        [Comment("Post Content")]
        public string Content { get; set; } = string.Empty;

    }
}
