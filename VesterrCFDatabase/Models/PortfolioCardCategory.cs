using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesterrCFDatabase.Models
{
    public class PortfolioCardCategory
    {
        public int Id { get; set; }
        public PortfolioCard PortfolioCard { get; set; }
        public PortfolioCategory PortfolioCategory { get; set; }
        public int PortfolioCardId { get; set; }
        public int PortfolioCategoryId { get; set; }
    }
}
