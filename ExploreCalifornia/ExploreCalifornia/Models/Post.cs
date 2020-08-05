using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        [Display(Name = "Post Title")]
        [Required]
        //[DataType(DataType.Password)]
        [DataType(DataType.Text)]
        [StringLength(100,MinimumLength =5 ,ErrorMessage = "Title must be between 5 to 100 characters" )]
        public string Title { get; set; }
        public DateTime Posted { get; set; }
        public string Author { get; set; }
        [Display(Name = "Post Body")]
        [DataType(DataType.MultilineText)]
        [Required]
        [StringLength(100,  ErrorMessage = "Body must be between characters long")]
        public string Body { get; set; }
    }
}
