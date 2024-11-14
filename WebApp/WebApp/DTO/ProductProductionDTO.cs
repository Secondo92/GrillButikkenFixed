using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.DTO
{
    public class ProductProductionDTO
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Product Product { get; set; }
        public int QuantityToProduce { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Deadline { get; set; }
        public TimeSpan TimeSpent { get; set; }
        public Status Status { get; set; }

        public ProductProductionDTO()
        {

        }
        public ProductProductionDTO(int projectId, string projectName, Product product, int quantityToProduce, DateTime createdAt, DateTime deadline, TimeSpan timeSpent, Status status)
        {
            ProjectId = projectId;
            ProjectName = projectName;
            QuantityToProduce = quantityToProduce;
            CreatedAt = createdAt;
            Deadline = deadline;
            TimeSpent = timeSpent;
            Status = status;
        }
    }
}