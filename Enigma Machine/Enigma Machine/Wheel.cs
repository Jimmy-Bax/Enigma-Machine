using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    public class Wheel
    {
        int[,] wiring;
        int position;
        int rotorNo;
        int notch;

        public Wheel(int rotorNumber, int rotorPosition = 0)
        {
            rotorNo = rotorNumber;
            position = rotorPosition;
            switch (rotorNo)
            {
                case 1:
                    wiring = new int[,] { { 0, 4 }, { 1, 10 }, { 2, 12 }, { 3, 5 }, { 4, 11 }, { 5, 6 }, { 6, 3 }, { 7, 16 }, { 8, 21 }, { 9, 25 }, { 10, 13 }, { 11, 19 }, { 12, 14 }, { 13, 22 }, { 14, 24 }, { 15, 7 }, { 16, 23 }, { 17, 20 }, { 18, 18 }, { 19, 15 }, { 20, 0 }, { 21, 8 }, { 22, 1 }, { 23, 17 }, { 24, 2 }, { 25, 9 },};
                    notch = 16; //Q
                    break;
                case 2:
                    wiring = new int[,] { { 0, 0 }, { 1, 9 }, { 2, 3 }, { 3, 10 }, { 4, 18 }, { 5, 8 }, { 6, 17 }, { 7, 20 }, { 8, 23 }, { 9, 1 }, { 10, 11 }, { 11, 7 }, { 12, 22 }, { 13, 19 }, { 14, 12 }, { 15, 2 }, { 16, 16 }, { 17, 6 }, { 18, 25 }, { 19, 13 }, { 20, 15 }, { 21, 24 }, { 22, 5 }, { 23, 21 }, { 24, 14 }, { 25, 4 },};
                    notch = 4;//E
                    break;
                case 3:
                    wiring = new int[,] { { 0, 1 }, { 1, 3 }, { 2, 5 }, { 3, 7 }, { 4, 9 }, { 5, 11 }, { 6, 2 }, { 7, 15 }, { 8, 17 }, { 9, 19 }, { 10, 23 }, { 11, 21 }, { 12, 25 }, { 13, 13 }, { 14, 24 }, { 15, 4 }, { 16, 8 }, { 17, 22 }, { 18, 6 }, { 19, 0 }, { 20, 10 }, { 21, 12 }, { 22, 20 }, { 23, 18 }, { 24, 16 }, { 25, 14 }, };
                    notch = 21;//V
                    break;
                case 4:
                    wiring = new int[,] { { 0, 4 }, { 1, 18 }, { 2, 14 }, { 3, 21 }, { 4, 15 }, { 5, 25 }, { 6, 9 }, { 7, 0 }, { 8, 24 }, { 9, 16 }, { 10, 20 }, { 11, 8 }, { 12, 17 }, { 13, 7 }, { 14, 23 }, { 15, 11 }, { 16, 13 }, { 17, 5 }, { 18, 19 }, { 19, 6 }, { 20, 10 }, { 21, 3 }, { 22, 2 }, { 23, 12 }, { 24, 22 }, { 25, 1 },};
                    notch = 9;//J
                    break;
                case 5:
                    wiring = new int[,] { { 0, 21 }, { 1, 25 }, { 2, 1 }, { 3, 17 }, { 4, 6 }, { 5, 8 }, { 6, 19 }, { 7, 24 }, { 8, 20 }, { 9, 15 }, { 10, 18 }, { 11, 3 }, { 12, 13 }, { 13, 7 }, { 14, 11 }, { 15, 23 }, { 16, 0 }, { 17, 22 }, { 18, 12 }, { 19, 9 }, { 20, 16 }, { 21, 14 }, { 22, 5 }, { 23, 4 }, { 24, 2 }, { 25, 10 },};
                    notch = 25;//Z
                    break;
            }
        }

        public int RunThrough(int input, bool forward)
        {
            if (forward)
            {
                input = (input + position) % 26;

                return (wiring[input, 1] - position + 26) % 26;
            }
            else
            {
                input = (input + position) % 26;

                for (int i = 0; i < 26; i++)
                {
                    if (input == wiring[i, 1])
                    {
                        int output = (wiring[i, 0] - position + 26);
                        return output % 26;
                    }
                }
            }
            return -1;
        }

        public void NextPosition()
        {
            position++;
            position = position % 26;
        }

        public bool RotateNextWheel()
        {
            if (notch == position)
            {
                return true;
            }

            return false;
        }

        public int Position
        {
            get { return position; }
        }
    }
}
