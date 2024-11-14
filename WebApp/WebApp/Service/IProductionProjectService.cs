using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Service
{
    public interface IProductionProjectService
    {
        ProductProduction GetProductProductionById(Guid guid);
        IEnumerable<ProductProduction> GetAllProductProductions();
        void CreateProductProduction();
        void UpdateProductProduction(ProductProduction productionProject);
        void UpdateStatusForProductProduction(string status, Guid guid);
        void DeleteProductProduction(Guid guid);
    }
}
