using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppAPI.Models;

namespace AppWeb.Controllers
{
    public class ProductsController : Controller
    {
        private readonly MySaleDBContext _context;

        public ProductsController(MySaleDBContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
