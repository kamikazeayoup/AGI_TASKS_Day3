using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutRefTask
{
    public static class OutRef
    {
        public static void swapRef(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }
        public static void swapOut(int x, int y, out int ResultX, out int ResultY)
        {
            ResultX = y;
            ResultY = x;

        }
    }
}
