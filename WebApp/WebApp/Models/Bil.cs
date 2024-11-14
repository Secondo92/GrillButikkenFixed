using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Bil
    {
        public Bil() { }
        public Bil(int id, string name, DateTime year)
        {
            Id = id;
            Name = name;
            Year = year;
        }

        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}