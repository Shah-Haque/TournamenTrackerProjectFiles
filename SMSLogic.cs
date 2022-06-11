using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TrackerLibrary
{
    /// <summary>
    /// The logic behind the texting of Tournament Tracker
    /// </summary>
    public class SMSLogic
    {
        /// <summary>
        /// The logic behind the SMS messaging 
        /// </summary>
        /// <param name="to"></param>
        /// <param name="message"></param>
        public static void SendSMSMessage(string to, string Textmessage)
        {
            string accountSid = GlobalConfig.AppKeyLookup("smsAccountSid");
            string authToken = GlobalConfig.AppKeyLookup("smsAuthToken");
            string fromPhoneNumber = GlobalConfig.AppKeyLookup("smsFromPhoneNumber");

            TwilioClient.Init(accountSid, authToken);

            try
            {
                var message = MessageResource.Create
                (
                     to: new PhoneNumber(to),
                     from: new PhoneNumber(fromPhoneNumber),
                     body: Textmessage
                );
            }
            catch
            { 
            }

            //Console.WriteLine(message.ErrorMessage);
        }
    }
}