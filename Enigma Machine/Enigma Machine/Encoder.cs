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

        int wheel1Value;
        int wheel2Value;
        int wheel3Value;

        public Encoder(int wheel1, int wheel2, int wheel3, int reflector)
        {
            this.reflector = new Reflector(reflector);
            this.wheel1 = new Wheel(wheel1);
            this.wheel2 = new Wheel(wheel2);
            this.wheel3 = new Wheel(wheel3);

            wheel1Value = wheel1;
            wheel2Value = wheel2;
            wheel3Value = wheel3;
        }

        public int Encode(int input)
        {
            wheel3.NextPosition();
            int output = wheel3.RunThrough(input, true);

            if (wheel3.RotateNextWheel())
            {
                wheel2.NextPosition();
            }
            output = wheel2.RunThrough(output, true);

            if (wheel2.RotateNextWheel())
            {
                wheel1.NextPosition();
            }
            output = wheel1.RunThrough(output, true);

            output = reflector.RunThrough(output, true);
            output = reflector.RunThrough(output, false);

            output = wheel1.RunThrough(output, false);
            output = wheel2.RunThrough(output, false);
            output = wheel3.RunThrough(output, false);

            return output;
        }
    }
}
