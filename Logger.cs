using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic
{
    public static class Logger
    {
        public static void Log(string text)
        {
            //get date time now and attach it to the log text
            DateTime dateTimeNow = DateTime.Now;
            text = $"{dateTimeNow} \t {text}";

            //get calling method
            StackTrace stackTrace = new StackTrace();
            var method = stackTrace.GetFrame(1).GetMethod();

            //get path
            string path = @"D:\FACULTATE\Licenta\HealthClinicSolution\HealthClinic\log.txt";

            //if file does not exist, create the file
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path));
            }

            //write to file
            File.AppendAllText(path, $"{method.Name} from class {method.ReflectedType.Name}: {text} \n");
        }
    }
}
