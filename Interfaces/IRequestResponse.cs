using System;
using weatherMvc.Models;

namespace weatherMvc.Interfaces
{
    public interface IRequestResponse
    {
        requestAndResponseVerification takeRequestResponseSnapshot(string request_string, string response_string, DateTime time_stamp,
                                                                    string target_uri, string http_status_code);
    }
}

