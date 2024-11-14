using System.Collections.Generic;

namespace WebApp.Models.Frontend
{
    public interface IProductionFactory
    {
        Production CreateProduction(string productionName, int plannedQuantity, List<RawMaterials> rawMaterials);
        bool HasEnoughRawMaterials(int plannedQuantity, List<RawMaterials> rawMaterials);
    }
}