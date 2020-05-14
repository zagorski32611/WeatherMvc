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
    public class DevTools : Controller
    {
        private readonly WeatherMvcDbContext _context;

        //public void TakeRequestResponseSnapshot(string input, bool request_or_response, string type)
        //{
        //    requestAndResponse r_and_r = new requestAndResponse()
        //    {
        //        
        //    }
        //}
    }
}