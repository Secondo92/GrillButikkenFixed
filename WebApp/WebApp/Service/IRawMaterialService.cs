using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DTO;
using WebApp.Models;

namespace WebApp.Service
{
    public interface IRawMaterialService
    {
        // Create, Get, GetAll, Update, Delete
        List<RawMaterialDTO> GetRawMaterialByName(String name);
        List<RawMaterialDTO> GetAllRawMaterials();
        RawMaterialDTO CreateRawMaterial(string name, MeasurementType measurementType, double measurementValue);
        RawMaterialDTO UpdateRawMaterial(RawMaterialDTO rawMaterialDTO);
        RawMaterialDTO DeleteRawMaterial(RawMaterialDTO rawMaterialDTO);
    }
}
