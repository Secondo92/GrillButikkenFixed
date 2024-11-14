using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.DataAccess.Repositories;
using WebApp.DTO;

namespace WebApp.BLL
{
    public class BilBLL
    {
        public BilBLL() { }
        public BilDTO getBil(int id)
        {
            if (id < 0) throw new IndexOutOfRangeException();
            return BilRepository.getBil(id);
        }
        public void AddBil(BilDTO bilDTO)
        {
            //valider employee
            BilRepository.AddBil(bilDTO);
        }
        public void EditBil(BilDTO bilDto)
        {
            BilRepository.EditBil(bilDto);
        }
    }
    }