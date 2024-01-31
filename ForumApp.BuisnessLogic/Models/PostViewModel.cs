using ForumApp.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ForumApp.Infrastructure.Constants.ValidationConstants;

namespace ForumApp.BuisnessLogic.Models
{
    /// <summary>
    /// Post Data transfer model
    /// </summary>
    public class PostViewModel
    {
        /// <summary>
        /// Post identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Post title
        /// </summary>
        [Required(ErrorMessage = fieldNotEmpty )]
        [StringLength(MaximumTitleLength,
            MinimumLength = MinimumTitleLength,
            ErrorMessage = stringLength)]   
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Post content
        /// </summary>
        [Required(ErrorMessage = fieldNotEmpty)]
        [StringLength(MaximumTitleLength,
                    MinimumLength = MinimumTitleLength,
                    ErrorMessage = stringLength)]
        public string Content { get; set; } = string.Empty;
    }
}
