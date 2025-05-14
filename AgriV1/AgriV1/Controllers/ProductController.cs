using AgriV1.Areas.Identity.Data;
using AgriV1.Data;
using AgriV1.Models;
using AgriV1.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriV1.Controllers
{

    //Author: Theo Walcot12
    //Accessable: https://stackoverflow.com/questions/31219704/how-to-connect-to-sql-server-using-asp-net-mvc-web-application
    //Date Accessed: 12 May 2025
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AgriV1User> _userManager;
        //[Authorize(Roles = "Farmer")]
        public ProductController(ApplicationDbContext context, UserManager<AgriV1User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [Authorize(Roles = "Farmer")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Farmer")]
        public async Task<IActionResult> MyProducts()
        {
            var userId = _userManager.GetUserId(User);
            var myProducts = await _context.Products
                .Where(p => p.FarmerId == userId)
                .ToListAsync();

            return View(myProducts);
        }

        //[Authorize(Roles = "Employee")]
        //[HttpGet]
        //public async Task<IActionResult> AllProducts(DateTime? startDate, DateTime? endDate)
        //{
        //    var productsQuery = _context.Products.Include(p => p.Farmer).AsQueryable();

        //    if (startDate.HasValue)
        //    {
        //        productsQuery = productsQuery.Where(p => p.ProductionDate >= startDate.Value);
        //    }

        //    if (endDate.HasValue)
        //    {
        //        productsQuery = productsQuery.Where(p => p.ProductionDate <= endDate.Value);
        //    }

        //    var filteredProducts = await productsQuery.ToListAsync();
        //    return View(filteredProducts);
        //}

        [Authorize(Roles = "Employee")]
        public IActionResult AllProducts(DateTime? startDate, DateTime? endDate, string category, string farmerId)
        {
            var productsQuery = _context.Products.Include(p => p.Farmer).AsQueryable();

            // Apply date filters
            if (startDate.HasValue)
                productsQuery = productsQuery.Where(p => p.ProductionDate >= startDate.Value);

            if (endDate.HasValue)
                productsQuery = productsQuery.Where(p => p.ProductionDate <= endDate.Value);

            // Apply category filter
            if (!string.IsNullOrEmpty(category))
                productsQuery = productsQuery.Where(p => p.Category == category);

            // Apply farmer filter
            if (!string.IsNullOrEmpty(farmerId))
                productsQuery = productsQuery.Where(p => p.FarmerId == farmerId);

            // Load unique categories for dropdown
            var categories = _context.Products
                .Select(p => p.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            // Load list of farmers for dropdown
            ViewBag.Farmers = _context.Users
                .OrderBy(u => u.Email)
                .Select(u => new { u.Id, u.Email })
                .ToList();

            ViewBag.Categories = categories;

            return View(productsQuery.ToList());
        }


        [Authorize(Roles = "Farmer")]
        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                var product = new Product
                {
                    Name = model.Name,
                    Category = model.Category,
                    ProductionDate = model.ProductionDate,
                    FarmerId = user.Id
                };

                _context.Products.Add(product);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Product added successfully!";
                return RedirectToAction("FarmerDashboard", "Dashboard");
            }

            return View(model);
        }


        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> AllFarmers()
        {
            var farmers = await _userManager.GetUsersInRoleAsync("Farmer");
            return View(farmers);
        }
    }
}

