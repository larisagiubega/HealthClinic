using System;

namespace HealthClinic.Exceptions
{
    public class Exceptions : Exception
    {
        public Exceptions()
        {

        }
        public Exceptions(string exception) : base($"{exception}")
        {

        }
    }
}
