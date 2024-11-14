using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApp.Models;
using WebApp.Models.Frontend;
using Unit = WebApp.Models.Frontend.Unit;

namespace WebApp.Controllers
{
    public class OverviewController : Controller
    {
        private ProductionFactory grillSpydFactory = new ProductionFactory();

        public ActionResult RåvarerView()
        {
            List<RawMaterials> items = new List<RawMaterials>
            {
                new RawMaterials("Stål", Unit.kg, 20) { Category = "Metal" },
                new RawMaterials("Træ", Unit.pcs, 20) { Category = "Material" }
            };

            List<Production> productions = new List<Production>
            {
                new Production("Grill Spyd", DateTime.Now, 10, items)
            };

            var model = new InventoryAndProductionOverview
            {
                RawMaterials = items,
                Productions = productions
            };


            return View(model);
        }


        [HttpPost]
        public ActionResult StartProduction(string productionName, int plannedQuantity)
        {
            List<RawMaterials> items = GetItems();

            Production production = grillSpydFactory.CreateProduction(productionName, plannedQuantity, items);

            production?.StartProduction();
            return RedirectToAction("TestView");
        }

        private List<RawMaterials> GetItems()
        {
            // For demo purposes. In reality, we would need to retrieve from a data model
            return new List<RawMaterials>
            {
                new RawMaterials("Steel", Unit.kg, 20) { Category = "Metal" },
                new RawMaterials("Wood", Unit.pcs, 20) { Category = "Material" }
            };
        }
    }
}