using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inovate.Web.Models
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Title { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 50)]
        public string ShortDescription { get; set; }
        [Required]
        [StringLength(8000, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 200)]
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


        public static List<ProjectViewModel> GenerateSampleData(int n)
        {
            Random rd = new Random(n);
            var list = new List<ProjectViewModel>();
            for (int i = 0; i < n; i++)
            {
                var project = new ProjectViewModel();
                project.Id = i;
                project.ImageUrl = "http://lorempixel.com/140/140";
                project.Title = NLipsum.Core.LipsumGenerator.Generate(3, NLipsum.Core.Features.Words, "{0}", NLipsum.Core.Lipsums.TierrayLuna);
                project.Desciption = NLipsum.Core.LipsumGenerator.Generate(6, NLipsum.Core.Features.Paragraphs, "{0}", NLipsum.Core.Lipsums.TierrayLuna);
                project.ShortDescription = NLipsum.Core.LipsumGenerator.Generate(2, NLipsum.Core.Features.Sentences, "{0}", NLipsum.Core.Lipsums.TierrayLuna);
                project.Owner = i % 2 == 0 ? "Gabriel" : "Takenet";
                int required = rd.Next(200, 1000);
                project.Required = required;
                project.CurrentCollected = rd.Next(0, required);
                project.StartDate = DateTime.Today.AddDays(-i);
                project.MaxDate = DateTime.Today.AddDays(5 + i);
                project.Backers = rd.Next(0, 15);
                list.Add(project);
            }
            return list;
        }
    }

}