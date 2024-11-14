using System;
using System.Collections.Generic;

namespace WebApp.Models.Frontend
{
    public enum Unit
    {
        kg,
        L,
        pcs
    }

    public class RawMaterials
    {
        private static Dictionary<string, string> materialUUIDs = new Dictionary<string, string>();
        public string UUID { get; private set; }
        public string MaterialName { get; set; }
        public string Category { get; set; }
        public Unit Unit { get; set; }
        public DateTime ReceivedDate { get; set; }
        // Possibly expiration date
        public int Quantity { get; set; }

        public RawMaterials(string materialName, Unit unit, int quantity)
        {
            MaterialName = materialName;
            ReceivedDate = DateTime.Now;
            Unit = unit;
            Quantity = quantity;

            if (!materialUUIDs.ContainsKey(materialName))
            {
                materialUUIDs[materialName] = Guid.NewGuid().ToString();
            }

            UUID = materialUUIDs[materialName];
        }
    }
}
