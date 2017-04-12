using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Twilio.Models
{
    public class SmsHelper
    {
        public static void SendSms(VMSms sms)
        {
            try
            {
                // Your Account SID from twilio.com/console
                var accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
                // Your Auth Token from twilio.com/console
                var authToken = "auth_token";

                TwilioClient.Init(accountSid, authToken);

                foreach (var item in sms.MobileNos.Split(','))
                {
                    var message = MessageResource.Create(
                   to: new PhoneNumber(item),
                   from: new PhoneNumber("+15017250604"),
                   body: sms.Message);
                }
            }
            catch { }
        }

    }
}