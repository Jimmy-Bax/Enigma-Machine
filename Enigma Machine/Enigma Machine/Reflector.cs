using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    internal class Reflector
    {
        private int[,] wiring;
        private int position;

        public Reflector(int reflectorNo, int position = 0)
        {
            this.position = position;

            switch (reflectorNo)
            {
                case 0://A
                    wiring = new int[,] { { 0, 4 }, { 1, 9 }, { 2, 12 }, { 3, 25 }, { 4, 0 }, { 5, 11 }, { 6, 24 }, { 7, 23 }, { 8, 21 }, { 9, 1 }, { 10, 22 }, { 11, 5 }, { 12, 2 }, { 13, 17 }, { 14, 16 }, { 15, 20 }, { 16, 14 }, { 17, 13 }, { 18, 19 }, { 19, 18 }, { 20, 15 }, { 21, 8 }, { 22, 10 }, { 23, 7 }, { 24, 6 }, { 25, 3 }, };
                    break;
                case 1://B
                    wiring = new int[,] { { 0, 24 }, { 1, 17 }, { 2, 20 }, { 3, 7 }, { 4, 16 }, { 5, 18 }, { 6, 11 }, { 7, 3 }, { 8, 15 }, { 9, 23 }, { 10, 13 }, { 11, 6 }, { 12, 14 }, { 13, 10 }, { 14, 12 }, { 15, 8 }, { 16, 4 }, { 17, 1 }, { 18, 5 }, { 19, 25 }, { 20, 2 }, { 21, 22 }, { 22, 21 }, { 23, 9 }, { 24, 0 }, { 25, 19 }, };
                    break;
                case 2://C
                    wiring = new int[,] { { 0, 5 }, { 1, 21 }, { 2, 15 }, { 3, 9 }, { 4, 8 }, { 5, 0 }, { 6, 14 }, { 7, 24 }, { 8, 4 }, { 9, 3 }, { 10, 17 }, { 11, 25 }, { 12, 23 }, { 13, 22 }, { 14, 6 }, { 15, 2 }, { 16, 19 }, { 17, 10 }, { 18, 20 }, { 19, 16 }, { 20, 18 }, { 21, 1 }, { 22, 13 }, { 23, 12 }, { 24, 7 }, { 25, 11 }, };
                    break;
            }
        }

        public int RunThrough(int input, bool forward)
        {
            input = (input + position) % 26;
            if (forward)
            {
                return (wiring[input, 1] - position + 26) % 26;
            }
            else
            {
                return (wiring[input, 0] - position + 26) % 26;
            }
        }
    }
}
