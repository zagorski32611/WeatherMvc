using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace weatherMvc.Models
{
    public class requestAndResponse
    {
        [Key]
        public int rAndRId { get; set; }
        public string request_string { get; set; }
        public string response_string { get; set; }
        public DateTime timeStamp { get; set; }
        public string targetUri { get; set; }
        public string httpStatusCode { get; set; }
    }

    public class requestAndResponseVerification
    {
        [NotMapped]
        public string save_success_string { get; set; }

        public bool save_success_flag { get; set; }
    }

}