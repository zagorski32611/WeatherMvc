using System;
using weatherMvc.Data;
using weatherMvc.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using weatherMvc.Models;
using weatherMvc.Services;

namespace weatherMvc.Services
{
    public class RequestResponseService : IRequestResponse
    {
        private readonly WeatherMvcDbContext _context;

        public RequestResponseService(WeatherMvcDbContext context)
        {
            _context = context;
        }

        public requestAndResponseVerification takeRequestResponseSnapshot(string request, string response, DateTime timeStamp,
                                        string targetUri, string httpStatusCode)
        {
            bool successflag = false;

            requestAndResponse rr = new requestAndResponse();
            rr.request_string = request;
            rr.response_string = response;
            rr.timeStamp = timeStamp;
            rr.targetUri = targetUri;
            rr.httpStatusCode = httpStatusCode;

            try
            {
                _context.Add(rr);
                _context.SaveChanges();
                successflag = true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e}");
            }
            requestAndResponseVerification rrv = new requestAndResponseVerification()
            {
                save_success_flag = successflag,
                save_success_string = $"{successflag}"
            };
            return rrv;

        }
    }
}