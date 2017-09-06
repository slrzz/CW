using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CW.API
{
    public class WriterFactory
    {
        public static IWriter GetWriter(string writerClass)
        {
            Type t = Type.GetType(writerClass);
            if (t==null)
            {
                throw new Exception("Type not found.");
            }
            IWriter w =(IWriter)Activator.CreateInstance(t);
            return w;
        }
    }
}
