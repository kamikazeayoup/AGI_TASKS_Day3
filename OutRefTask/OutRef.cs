using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutRefTask
{
    public static class OutRef
    {
        public static void swapRefOut(ref int x, ref int y, out int ResultX, out int ResultY)
        {
            ResultX = x;
            ResultY = y;
            int z = x;
            x = y;
            y = z;
            z = ResultX;
            ResultX = ResultY;
            ResultY = z;

        }
    }
}
