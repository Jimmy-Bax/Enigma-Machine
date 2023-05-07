namespace Enigma_Machine
{
    public partial class EnigmaMachine : Form
    {

        Wheel rotor1 = new Wheel("EKMFLGDQVZNTOWYHXUSPAIBRCJ", 'Q', 0);
        Wheel rotor2 = new Wheel("AJDKSIRUXBLHWTMCQGZNPYFVOE", 'E', 0);
        Wheel rotor3 = new Wheel("BDFHJLCPRTXVZNYEIWGAKMUSQO", 'V', 0);
        Wheel rotor4 = new Wheel("ESOVPZJAYQUIRHXLNFTGKDCMWB", 'J', 0);
        Wheel rotor5 = new Wheel("VZBRGITYUPSDNHLXAWMJQOFECK", 'Z', 0);

        public EnigmaMachine()
        {
            InitializeComponent();
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            if (checkIfWheelSelectionIsPosible())
            {
                MessageBox.Show("Encoding");
                //call encoder
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
    }
}