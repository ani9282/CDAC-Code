using Mvc_ADOCRUD_Demo.Models.DAL;
using Mvc_ADOCRUD_Demo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_ADOCRUD_Demo.Models.BL
{
    public class PuppiesBL
    {
        PuppiesDAO obj = null;
        public PuppiesBL()
        {
            obj = new PuppiesDAO();
        }
       public void SavePuppies(Puppies p)
        {
            obj.SavePuppies(p);
        }
        public void ShowAllPuppies(Puppies p)
        {
            obj.SavePuppies(p);
        }
        public Puppies ShowPuppieByID(int id)
        {
            return obj.GetPuppiesByPuppiesNo(id);
        }
    }
}