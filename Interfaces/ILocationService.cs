using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weatherMvc.Models;

namespace weatherMvc.Interfaces
{
    public interface ILocationService
    {
        Task<LocationData> LocationSearch(string searchAddress);

        void SaveLocationData(LocationData location);
    }
}
