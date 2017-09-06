using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.API
{
    class AnyWriter : IWriter
    {
        public void Write(string text = "Hello World")
        {
            throw new NotImplementedException();
        }
    }
}
