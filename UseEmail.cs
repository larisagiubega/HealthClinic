
namespace HealthClinic
{
    using System;
    public static class UseEmail
    {
        private const string EMAIL_FROM = "no-reply@healthclinic.com";
        private static DateTime lastEmailSent;

        public static bool SendEmail(string to, string subject, string body)
        {
            bool success = true;

            try
            {
                EmailLibrary.EmailLibrary.SendEmail(EMAIL_FROM, to, subject, body);
                lastEmailSent = DateTime.Now;
            }
            catch (Exception ex)
            {
                success = false;
                Logger.Log(ex.Message);
            }

            return success;
        }

        public static bool CanSendEmail(DateTime now)
        {
            return now >= lastEmailSent.AddMinutes(30);
        }
    }
}
