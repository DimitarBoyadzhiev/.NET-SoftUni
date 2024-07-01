using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ForumApp.Infrastructure.Constants.ValidationConstants;

namespace ForumApp.Infrastructure.Data.Models
{
    [Comment("Posts Table")]
    public class Post
    {
        [Key]
        [Comment("Post Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("Post Title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(ContentMaxLength)]
        [Comment("Post Content")]
        public string Content { get; set; } = string.Empty;
    }
}
