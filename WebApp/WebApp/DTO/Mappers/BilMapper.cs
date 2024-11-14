using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.DTO.Mappers
{
    public class BilMapper
    {
        public static BilDTO Map(Bil bil)
        {
            if (bil != null)
                return new BilDTO(bil.Id, bil.Name, bil.Year);
            else
                return null;
        }
        public static Bil Map(BilDTO bilDto)
        {
            if (bilDto != null)
                return new Bil(bilDto.Id, bilDto.Name, bilDto.Year);
            else
                return null;
        }

        internal static void Update(BilDTO bilDto, Bil bil)
        {
            if (bilDto != null)
            {
                bil.Name = bilDto.Name;
                bil.Year = bilDto.Year;
            }
            else
                bil = null;
        }

        private static List<BilDTO> Map(List<Bil> biler)
        {
            List<BilDTO> retur = new List<BilDTO>();
            foreach (Bil bil in biler)
            {
                retur.Add(BilMapper.Map(bil));
            }
            return retur;
        }
    }
}