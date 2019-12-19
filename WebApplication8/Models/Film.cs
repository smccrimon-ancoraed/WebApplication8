using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication8.Models
{
    public partial class Film
    {
        public Film()
        {
            FilmActor = new HashSet<FilmActor>();
            FilmCategory = new HashSet<FilmCategory>();
            Inventory = new HashSet<Inventory>();
        }

        [Key]
        public int FilmId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string ReleaseYear { get; set; }
        [Required]
        public byte LanguageId { get; set; }
        public byte? OriginalLanguageId { get; set; }
        public byte RentalDuration { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal RentalRate { get; set; }
        public short? Length { get; set; }
        [Required]
        [Column(TypeName="decimal(18,2)")]
        public decimal ReplacementCost { get; set; }
        public string Rating { get; set; }
        public string SpecialFeatures { get; set; }
        [Display(Name ="Last updated")]
        [DataType(DataType.Date)]
        public DateTime LastUpdate { get; set; }

        public virtual Language Language { get; set; }
        public virtual Language OriginalLanguage { get; set; }
        public virtual ICollection<FilmActor> FilmActor { get; set; }
        public virtual ICollection<FilmCategory> FilmCategory { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}
