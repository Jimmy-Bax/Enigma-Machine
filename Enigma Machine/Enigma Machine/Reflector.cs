using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    internal class Reflector
    {
        private string[] reflectorWiring;

        public Reflector(string alphabet, string wiring)
        {
            // Ensure the wiring is valid
            if (wiring.Length != alphabet.Length)
            {
                throw new ArgumentException("Wiring length must match alphabet length");
            }

            // Create a dictionary to map input characters to output characters
            reflectorWiring = new string[alphabet.Length];
            for (int i = 0; i < alphabet.Length; i++)
            {
                int index = wiring.IndexOf(alphabet[i]);
                if (index < 0)
                {
                    throw new ArgumentException("Wiring must contain all characters in the alphabet");
                }
                reflectorWiring[i] = alphabet[index].ToString();
            }
        }

        public string GetReflectedCharacter(string input)
        {
            int index = Array.IndexOf(reflectorWiring, input.ToUpper());
            return reflectorWiring[index];
        }
    }
}
