using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        /* public int Id { get; set; }

         [Display(Name ="名称")]
         public string? Title { get; set; }

         [DataType(DataType.Date)]
         [Display(Name ="发布日期")]
         public DateTime ReleaseDate { get; set; }

         [Display(Name = "类型")]
         public string? Genre { get; set; }

         [Display(Name = "价格")]
         public decimal Price { get; set; }

         public string? Rating { get; set; }*/
        public int Id { get; set; }

       
        public string? Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName  = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }

      
        public string? Rating { get; set; }
    }
}
