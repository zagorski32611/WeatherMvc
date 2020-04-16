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