using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        public long id { get; set; }
        private string _Key;

        public string Key
        {
            get
            {
                if (_Key == null)
                {
                    _Key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
                }
                return _Key;
            }
            set
            {
                _Key = value;
            }
        }

        [Display(Name = "Post Title")]
        [Required]
        //[DataType(DataType.Password)]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Title must be between 5 to 100 characters")]
        public string Title { get; set; }
        public DateTime Posted { get; set; }
        public string Author { get; set; }
        [Display(Name = "Post Body")]
        [DataType(DataType.MultilineText)]
        [Required]
        [StringLength(100, ErrorMessage = "Body must be between characters long")]
        public string Body { get; set; }
    }
}
