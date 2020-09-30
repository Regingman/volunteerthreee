using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VolunteerThree.Data;
using VolunteerThree.Models;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using System.IO;
using Microsoft.Extensions.Hosting;


namespace VolunteerThree.Controllers
{
    //[Authorize(Roles = "Admin, User")]

    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            var Role = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role).Value;
            if (Role == "Admin")
            {
                return RedirectToAction("Index", "Volunteers");
            }
            else
            {
                var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var volonteer = _context.Volunteers.FirstOrDefault(e => e.UserId == userId);
                if (volonteer != null)
                {
                    return RedirectToAction("DetailsOfVolunteer", "Volunteers");
                }

            }
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

      


    }
}
