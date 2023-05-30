using System.Windows.Forms;

namespace Enigma_Machine
{
    public partial class EnigmaMachine : Form
    {
        Encoder encoder;
        public EnigmaMachine()
        {
            InitializeComponent();
            comboBoxReflector.SelectedIndex = 0;
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            if (checkIfWheelSelectionIsPosible())
            {
                encoder = new Encoder(Decimal.ToInt32(numericUpDownWheel1.Value), Decimal.ToInt32(numericUpDownWheel2.Value), Decimal.ToInt32(numericUpDownWheel3.Value), comboBoxReflector.SelectedIndex);

                richTextBoxOutput.Clear();
                string[] characterArray = GetTextAsArray(richTextBoxInput);

                for (int i = 0; i < characterArray.Length; i++)
                {
                    if (characterArray[i] == " " || !IsAlphabetical(characterArray[i]))
                    {
                        AddCharToRichTextBox(richTextBoxOutput, characterArray[i]);
                    }
                    else
                    {
                        AddCharToRichTextBox(richTextBoxOutput, ConvertToString(encoder.Encode(ConvertToIndex(characterArray[i]))));
                    }
                }
            }
            else
            {
                MessageBox.Show("Your chosen wheel configuration is not possible, make sure u use unique wheels in all slots", "WARNING" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool checkIfWheelSelectionIsPosible()
        {
            if (numericUpDownWheel1.Value != numericUpDownWheel2.Value && numericUpDownWheel1.Value != numericUpDownWheel3.Value
                && numericUpDownWheel2.Value != numericUpDownWheel3.Value)
            {
                return true;
            }

            return false;
        }

        private int ConvertToIndex(string input)
        {
            input = input.ToUpper();
            char toConvertChar = input.ToCharArray()[0];
            return toConvertChar - 65;
        }

        private string ConvertToString(int input)
        {
            input += 65;
            char toConvertChar = (char)input;
            return toConvertChar.ToString();
        }

        private string[] GetTextAsArray(RichTextBox richTextBox)
        {
            string text = richTextBox.Text;
            string[] characters = text.Select(c => c.ToString()).ToArray();
            return characters;
        }

        private void AddCharToRichTextBox(RichTextBox richTextBox, string character)
        {
            richTextBox.SelectionStart = richTextBox.TextLength;
            richTextBox.SelectionLength = 0;
            richTextBox.SelectedText = character;
        }

        private bool IsAlphabetical(string input)
        {
            bool isAlphabetical = input.All(char.IsLetter);
            return isAlphabetical;
        }
    }
}