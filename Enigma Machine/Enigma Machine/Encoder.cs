using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    public class Encoder
    {
        Reflector reflector;
        Wheel wheel1;
        Wheel wheel2;
        Wheel wheel3;

        bool rotateWheel1;
        bool rotateWheel2;

        public Encoder(int wheel1, int wheel1Pos, int wheel2, int wheel2Pos, int wheel3, int wheel3Pos, int reflector, int reflectorPos)
        {
            this.reflector = new Reflector(reflector);
            this.wheel1 = new Wheel(wheel1, wheel1Pos);
            this.wheel2 = new Wheel(wheel2, wheel2Pos);
            this.wheel3 = new Wheel(wheel3, wheel3Pos);

            RotateWheel1 = false;
            RotateWheel2 = false;
        }

        public int Encode(int input)
        {
            int output = wheel3.RunThrough(input, true);
            output = wheel2.RunThrough(output, true);
            output = wheel1.RunThrough(output, true);

            output = reflector.RunThrough(output, true);
            output = reflector.RunThrough(output, false);

            output = wheel1.RunThrough(output, false);
            output = wheel2.RunThrough(output, false);
            output = wheel3.RunThrough(output, false);

            return output;
        }

        public void UpdateWheelPositions()
        {
            wheel3.NextPosition();

            if (wheel3.RotateNextWheel())
            {
                RotateWheel2 = true;
                wheel2.NextPosition();
            }

            if (wheel2.RotateNextWheel())
            {
                RotateWheel1 = true;
                wheel1.NextPosition();
            }
        }

        public bool RotateWheel1
        {
            get { return rotateWheel1; }
            set { rotateWheel1 = value; }
        }

        public bool RotateWheel2
        {
            get { return rotateWheel2; }
            set { rotateWheel2 = value; }
        }
    }
}
