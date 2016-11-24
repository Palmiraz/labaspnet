using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoesEcommers.ShopWeb.Models;

namespace ShoesEcommers.ShopWeb.Controllers
{
    public class BaseApiController : ApiController
    {
        protected Result Res;
        protected string Message;
        public BaseApiController()
        {
            Res = new Result();
            Message = string.Empty;
        }

        protected HttpResponseMessage CreateResponse(HttpStatusCode state = HttpStatusCode.OK,
            string message = "", HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            Res.State = (int)state;
            if (!string.IsNullOrEmpty(message))
                Res.Message = message;
            var httpResponseMessage = Request.CreateResponse(statusCode, Res);
            httpResponseMessage.Headers.Add("Access-Control-Allow-Origin", "*");
            return httpResponseMessage;
        }

        protected HttpResponseMessage Error(Exception ex)
        {
            return CreateResponse(HttpStatusCode.BadRequest, ex.Message, HttpStatusCode.BadRequest);
        }
       
    }
}
