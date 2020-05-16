using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using weatherMvc.Models;

namespace weatherMvc.Controllers
{
    public partial class WeatherController : Controller
    {

        public IActionResult GeneralReport()
        {

            List<DailyData> days = _context.DailyData
                                        .Where(f => f.temperatureHigh != 0)
                                        .ToList();

            ViewData["general_report"] = days;

            return View();
        }
    }
}