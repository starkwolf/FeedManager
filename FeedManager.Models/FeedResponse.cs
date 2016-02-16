using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FeedManager.Models
{
    public class FeedResponse
    {
        public FeedResponse(int id)
        {
            IsSuccess = true;
            StatusCode = HttpStatusCode.OK;
            Messages = "Kasun read the request";
        }

        public bool IsSuccess { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string Messages { get; set; }

    }
}
