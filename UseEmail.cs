
namespace HealthClinic
{
    using HealthClinic.Exceptions;
    using HealthClinic.Localization;
    using System;
    using System.Resources;

    public static class UseEmail
    {
        private static ResourceManager res = HealthClinicLocalization.GetResourceManager();

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
            catch
            {
                success = false;

                Logger.Log(res.GetString(new SendEmailException().Message));
            }

            return success;
        }

        public static bool CanSendEmail(DateTime now)
        {
            return now >= lastEmailSent.AddMinutes(30);
        }
    }
}
