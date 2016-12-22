using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreClassLibrary
{
    public interface IGreetingService
    {
        string Iam(string groot);
    }
    public class GreetingService: IGreetingService
    {
        public GreetingService()
        {
        }

        public string Iam(string groot)
        {
            System.Diagnostics.Debug.WriteLine(groot);
            return "I am " + groot;
        }
    }
}
