using System;
using System.ComponentModel.DataAnnotations;

namespace MovieDb.Data
{
    public class Movie
    {
        [Key, Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}