using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class ProductProduction
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Product Product { get; set; }
        public int QuantityToProduce { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Deadline { get; set; }
        public TimeSpan TimeSpent { get; set; }
        public Status Status { get; set; }

        public ProductProduction()
        {

        }
        public ProductProduction(string projectName, Product product, int quantityToProduce, DateTime createdAt, DateTime deadline, Status status)
        {
            ProjectName = projectName;
            Product = product;
            QuantityToProduce = quantityToProduce;
            CreatedAt = createdAt;
            Deadline = deadline;
            Status = status;
        }
    }
}