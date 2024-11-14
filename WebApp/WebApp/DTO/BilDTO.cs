using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.DTO
{
    public class BilDTO
    {
        public BilDTO(int id, string name, DateTime year)
        {
            Id = id;
            Name = name;
            Year = year;
        }

        public BilDTO()
        {
        }

        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return "Navn: " + Name + " - Year: " + Year.ToString();
        }
    }
}