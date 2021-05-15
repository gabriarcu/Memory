using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class MyFunz
    {
        public static void CaricaCarte(string[] ca)
        {
            for (int i=1;i<9;i++)
            {
                ca[i] = $"{i}.png";

            }
            for (int i = 9; i < 17; i++)
            {
                ca[i] = $"{i}.png";

            }

        }
    }
}
