using AvanisHerbalSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AvanisHerbalSalon.ViewModels
{
    public class ServicesVM
    {
        public List<HairCare> HairCareOptions { get; set; }
        public List<SkinCare> SkinCareOptions { get; set; }
        public List<MassageCare> MassageCareOptions { get; set; }
        public List<NailsCare> NailsCareOptions { get; set; }
    }
}
