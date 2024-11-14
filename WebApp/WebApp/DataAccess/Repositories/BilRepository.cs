using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.DataAccess.Context;
using WebApp.DTO;
using WebApp.DTO.Mappers; 

namespace WebApp.DataAccess.Repositories
{
    public class BilRepository
    {
        public static BilDTO getBil(int id)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                //If not found return NULL
                return BilMapper.Map(context.Biler.Find(id));

            }
        }
        public static void AddBil(BilDTO bilDto)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                context.Biler.Add(BilMapper.Map(bilDto));
                context.SaveChanges();
            }
        }

        public static void EditBil(BilDTO bilDto)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                Models.Bil databil = context.Biler.Find(bilDto.Id);
                BilMapper.Update(bilDto, databil);

                context.SaveChanges();
            }
        }
    }
}