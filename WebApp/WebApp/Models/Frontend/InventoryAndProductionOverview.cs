using System;
using System.Collections.Generic;

namespace WebApp.Models.Frontend
{
    public class InventoryAndProductionOverview
    {
        public List<RawMaterials> RawMaterials { get; set; } // Taken from database
        public List<Production> Productions { get; set; } // Taken from database

        public InventoryAndProductionOverview()
        {
            RawMaterials = new List<RawMaterials>();
            Productions = new List<Production>();
        }

        // Dette er en datamodel der er rent deklarativ. Vores controller eller BLL skal populere denne klasse.

    }
}
