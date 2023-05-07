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
        private string wiring;
        private char turnoverNotch;
        private int position;

        public Wheel(string wiring, char turnoverNotch, int position)
        {
            this.wiring = wiring;
            this.turnoverNotch = turnoverNotch;
            this.position = position;
        }

        public void SetPosition(char position)
        {
            this.position = wiring.IndexOf(position);
        }

        public char EncodeChar(char c)
        {
            // adjust for rotor position
            int index = (wiring.IndexOf(c) + position) % wiring.Length;
            char encodedChar = wiring[index];

            // adjust for rotor position again
            int reverseIndex = (wiring.IndexOf(encodedChar) - position + wiring.Length) % wiring.Length;
            encodedChar = wiring[reverseIndex];

            // rotate rotor if necessary
            position = (position + 1) % wiring.Length;
            if (wiring[position] == turnoverNotch)
            {
                // if this rotor has reached its turnover notch, rotate the next rotor
                OnTurnover();
            }

            return encodedChar;
        }

        // event to handle rotor turnover
        public event EventHandler Turnover;

        protected virtual void OnTurnover()
        {
            EventHandler handler = Turnover;
            handler?.Invoke(this, EventArgs.Empty);
        }
    }
}
