using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcast.GenericUtility
{
    public class CSharpUtility
    {
        public int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(1000);
        }
    }
}
