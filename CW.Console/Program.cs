using CW.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var writerName = System.Configuration.ConfigurationManager.AppSettings.Get("writer");
            var writer = WriterFactory.GetWriter(writerName);
            writer.Write();
            System.Console.ReadLine();
        }
    }
}
