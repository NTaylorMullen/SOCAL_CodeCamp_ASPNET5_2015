using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet5DemoRaw
{
    public class StringMagicUtility
    {
        public string Magic()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
