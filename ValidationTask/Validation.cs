using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationTask
{
    internal static class Validation
    {
        public static bool IsInt(string? n)
        {
            if(int.TryParse(n , out int result)){
                return true;
            };
            throw new Exception("The Input is Non Numerical Value");
        }

    }
}
