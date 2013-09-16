using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inovate.Web.Models
{
    public class ProjectViewModel
    {
        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Title { get; set; }
        [Required]
        [StringLength(8000, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Desciption { get; set; }
        public string Owner { get; set; }
        [DataType(DataType.Currency)]
        public float Required { get; set; }
        [DataType(DataType.Currency)]
        public float CurrentCollected { get; set; }
        [DataType(DataType.Date)]
        public DateTime MaxDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public List<string> Tags { get; set; }
        public int Backers { get; set; }
    }
}