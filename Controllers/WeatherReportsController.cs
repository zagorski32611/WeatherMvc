using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using weatherMvc.Data;
using weatherMvc.Models;
using System.Text.RegularExpressions;

namespace weatherMvc.Controllers
{
    public class weatherReportsController : Controller
    {
        private readonly WeatherMvcDbContext _context;

        public weatherReportsController(WeatherMvcDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult sortDays()
        {
            var reportData = new WeatherReport();
            return View(reportData);
        }

        [HttpPost]
        public IActionResult sortDays(WeatherReport weather)
        {
            var listofDays = _context.DailyData
                            .Where(d => d.temperatureMax > 30)
                            .ToList();
            ViewData["days"] = listofDays;

            return View();
        }
    }
}