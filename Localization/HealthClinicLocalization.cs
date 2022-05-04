using HealthClinic.Exceptions;
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HealthClinic.Localization
{
    public static class HealthClinicLocalization
    {
        private static string path = @"D:\FACULTATE\Licenta\HealthClinicSolution\HealthClinic\lang.txt";
        private static ResourceManager resourceManager;

        #region Resource Manager
        public static ResourceManager GetResourceManager()
        {
            resourceManager = new ResourceManager("HealthClinic.Localization.lang", Assembly.GetExecutingAssembly());

            string lang = GetLanguage();

            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(lang);

            return resourceManager;
        }

        #endregion

        #region Language

        public static string GetLanguage()
        {
            string language;

            try
            {
                language = ReadLanguage();

                if (!language.ToUpper().Equals("EN") && !language.ToUpper().Equals("RO") && !language.ToUpper().Equals("FR"))
                {
                    language = "en";
                }
            }
            catch
            {
                language = string.Empty;
                Logger.Log(resourceManager.GetString(new GetLanguageException().Message));

            }

            return language.ToUpper();
        }

        public static void SetLanguage(string lang)
        {
            try
            {
                File.WriteAllText(path, string.Empty);

                using (StreamWriter outputFile = new StreamWriter(path))
                {
                    outputFile.WriteLine(lang);
                }

            }
            catch
            {
                Logger.Log(resourceManager.GetString(new SetLanguageException().Message));
            }
        }

        public static string GetLanguageByShortString(string lang)
        {
            switch (lang.ToUpper())
            {
                case "RO":
                    return "Romanian";
                case "EN":
                    return "English";
                //case "FR": -- to-do
                default: return string.Empty;
            }
        }

        public static string GetLanguageByLongString(string lang)
        {
            switch (lang.ToUpper())
            {
                case "ROMANIAN":
                    return "ro";
                case "ENGLISH":
                    return "en";
                //case "FR": -- to-do
                default: return string.Empty;
            }
        }

        public static string GetResourceNameByValue(ResourceManager res, string value)
        {
            var entry =
                res.GetResourceSet(System.Threading.Thread.CurrentThread.CurrentUICulture, true, true)
                  .OfType<DictionaryEntry>()
                  .FirstOrDefault(e => e.Value.ToString() == value);

            var key = entry.Key.ToString();
            return key;
        }

        private static string ReadLanguage()
        {
            string content;

            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    content = streamReader.ReadToEnd();
                }
            }
            catch
            {
                content = string.Empty;
                Logger.Log(resourceManager.GetString(new ReadLanguageException().Message));
            }

            return content.Trim();
        }

        public static void FillControlsByLanguage(ResourceManager res, string lang, Panel panel)
        {
            try
            {
                foreach (var control in panel.Controls)
                {
                    if (control is Label)
                    {
                        Label label = (Label)control;
                        var name = label.Name;
                        label.Text = res.GetString(name);
                    }

                    if (control is Button)
                    {
                        Button button = (Button)control;
                        var name = button.Name;
                        button.Text = res.GetString(name);
                    }

                    if (control is CheckBox)
                    {
                        CheckBox cb = (CheckBox)control;
                        var name = cb.Name;
                        cb.Text = res.GetString(name);
                    }
                }
            }
            catch
            {
                Logger.Log(new FillByLanguageException().Message);
            }

            #endregion
        }
    }
}
