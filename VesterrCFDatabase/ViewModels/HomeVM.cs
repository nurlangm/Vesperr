using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VesterrCFDatabase.Models;

namespace VesterrCFDatabase.ViewModels
{
    public class HomeVM
    {
        public Entrance SiteEntrances { get; set; }
        public List<ServiceCard> ServiceCards { get; set; }
        public List<PortfolioCategory> PortfolioCategories { get; set; }
    }
}
