using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    internal class Plugboard
    {
        private Dictionary<char, char> plugboardMap;

        public Plugboard(Dictionary<char, char> plugboardPairs)
        {
            plugboardMap = new Dictionary<char, char>();
            foreach (var pair in plugboardPairs)
            {
                // Ensure that the input characters are valid and not already mapped
                char input = Char.ToUpper(pair.Key);
                char output = Char.ToUpper(pair.Value);
                if (!Char.IsLetter(input) || !Char.IsLetter(output))
                {
                    throw new ArgumentException("Plugboard pairs must be valid characters");
                }
                if (plugboardMap.ContainsKey(input) || plugboardMap.ContainsValue(output))
                {
                    throw new ArgumentException("Input and output characters must not be already mapped");
                }
                // Add the mapping to the dictionary
                plugboardMap.Add(input, output);
                plugboardMap.Add(output, input);
            }
        }

        public char MapCharacter(char input)
        {
            // Check if the input character is mapped
            if (plugboardMap.ContainsKey(input))
            {
                return plugboardMap[input];
            }
            return input;
        }
    }
}
