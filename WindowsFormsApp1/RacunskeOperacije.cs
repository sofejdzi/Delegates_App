using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public delegate int RacunskeOperacijeDelegat(int a, int b);

    public class RacunskeOperacije
    {
        public static int Saberi(int x, int y)
        {
            return x + y;
        }

        public static int Oduzmi(int x, int y)
        {
            return x - y;
        }

    }
}
