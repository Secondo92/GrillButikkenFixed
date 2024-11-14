using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApp.Models.Frontend
{
    public class ProductionFactory : IProductionFactory
    {
        public int SteelRequiredPerUnit = 3; // Here we define how many raw materials we need for this specific production

        public bool HasEnoughRawMaterials(int plannedQuantity, List<RawMaterials> rawMaterials) // Items should be retrieved from the datamodel
        {
            return rawMaterials.Where(item => item.MaterialName == "Steel").Sum(item => item.Quantity) >= (SteelRequiredPerUnit * plannedQuantity);
        }

        public Production CreateProduction(string productionName, int plannedQuantity, List<RawMaterials> items) // Should retrieve raw materials from datamodel
        {
            DateTime startDate = DateTime.Now;

            if (!HasEnoughRawMaterials(plannedQuantity, items))
            {
                Console.WriteLine("There are not enough raw materials to create the production.");
                return null;
            }

            Console.WriteLine("Creating Grillspyd production...");
            return new Production(productionName, startDate, plannedQuantity, items);

        }
    }
}