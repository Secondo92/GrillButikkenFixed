using System;
using System.Collections.Generic;
using WebApp.Models.Frontend;

namespace WebApp.Models.Frontend
{
    public enum ProductionStatus
    {
        Planned,
        InProgress,
        Completed
    }

    public class Production
    {
        private static Dictionary<string, string> ProductionUUID = new Dictionary<string, string>();
        private static Dictionary<RawMaterials, int> RawMaterialsRequired = new Dictionary<RawMaterials, int>();
        public string UUID { get; private set; }
        public string ProductionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; private set; }
        public List<RawMaterials> Items { get; set; }
        public ProductionStatus Status { get; private set; }
        public int PlannedQuantity { get; set; }
        public int CompletedQuantity { get; private set; } // Possibly redundant

        public Production(string productionName, DateTime startDate, int plannedQuantity, List<RawMaterials> items)
        {
            ProductionName = productionName;
            StartDate = startDate;
            PlannedQuantity = plannedQuantity;
            Items = items;
            Status = ProductionStatus.Planned;

            if (!ProductionUUID.ContainsKey(productionName))
            {
                ProductionUUID[productionName] = Guid.NewGuid().ToString();
            }

            UUID = ProductionUUID[productionName];

            // Calculate the raw materials required for this production
        }

        public void StartProduction()
        {
            Status = ProductionStatus.InProgress;
            Console.WriteLine($"Production '{ProductionName}' has now started.");
        }

        public void CompleteProduction(int completedQuantity)
        {
            CompletedQuantity = completedQuantity;
            EndDate = DateTime.Now;
            Status = ProductionStatus.Completed;
            Console.WriteLine($"Production '{ProductionName}' has been completed with {CompletedQuantity} units produced.");
        }
    }
}
