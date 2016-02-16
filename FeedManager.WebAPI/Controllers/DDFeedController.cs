using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FeedManager.Models;
using System.Web.Http.Description;

namespace FeedManager.WebAPI.Controllers
{
    public class DDFeedController : ApiController
    {
        [ResponseType(typeof(FeedResponse))]
        public IHttpActionResult Get(int id)
        {            
                return Ok(new FeedResponse(id));
        }
    }
}
