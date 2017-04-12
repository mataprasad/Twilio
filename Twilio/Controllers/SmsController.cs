using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Twilio.Models;

namespace Twilio.Controllers
{
    public class SmsController : ApiController
    {
        public IHttpActionResult Post([FromBody]VMSms sms)
        {
            SmsHelper.SendSms(sms);
            return Ok();
        }
    }
}