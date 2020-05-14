using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weatherMvc.Models;

namespace weatherMvc.Interfaces
{
    interface ILocationService
    {
        public Task<LocationData> LocationSearch(string searchAddress);

        public void SaveLocationData(LocationData location);


    }
}
