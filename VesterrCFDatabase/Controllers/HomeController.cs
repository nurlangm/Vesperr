using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VesterrCFDatabase.DAL;
using VesterrCFDatabase.Models;
using VesterrCFDatabase.ViewModels;

namespace VesterrCFDatabase.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                ServiceCards=_context.ServiceCards.Include(s => s.ServiceIcon).ToList(),
                PortfolioCategories=_context.PortfolioCategories.Include(pc => pc.PortfolioCardCategories).ThenInclude(pcc => pcc.PortfolioCard).ToList()
            };
            return View(homeVM);
        }
    }
}
