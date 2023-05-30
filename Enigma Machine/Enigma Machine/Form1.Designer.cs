namespace Enigma_Machine
{
    partial class EnigmaMachine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWheel1 = new System.Windows.Forms.Label();
            this.labelWheel2 = new System.Windows.Forms.Label();
            this.labelWheel3 = new System.Windows.Forms.Label();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelPutput = new System.Windows.Forms.Label();
            this.numericUpDownWheel1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWheel2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWheel3 = new System.Windows.Forms.NumericUpDown();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.comboBoxReflector = new System.Windows.Forms.ComboBox();
            this.labelReflector = new System.Windows.Forms.Label();
            this.comboBoxReflectorPos = new System.Windows.Forms.ComboBox();
            this.comboBoxWheel1Pos = new System.Windows.Forms.ComboBox();
            this.comboBoxWheel2Pos = new System.Windows.Forms.ComboBox();
            this.comboBoxWheel3Pos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWheel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWheel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWheel3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWheel1
            // 
            this.labelWheel1.AutoSize = true;
            this.labelWheel1.Location = new System.Drawing.Point(280, 117);
            this.labelWheel1.Name = "labelWheel1";
            this.labelWheel1.Size = new System.Drawing.Size(63, 20);
            this.labelWheel1.TabIndex = 3;
            this.labelWheel1.Text = "Wheel 1";
            // 
            // labelWheel2
            // 
            this.labelWheel2.AutoSize = true;
            this.labelWheel2.Location = new System.Drawing.Point(364, 117);
            this.labelWheel2.Name = "labelWheel2";
            this.labelWheel2.Size = new System.Drawing.Size(63, 20);
            this.labelWheel2.TabIndex = 4;
            this.labelWheel2.Text = "Wheel 2";
            // 
            // labelWheel3
            // 
            this.labelWheel3.AutoSize = true;
            this.labelWheel3.Location = new System.Drawing.Point(449, 117);
            this.labelWheel3.Name = "labelWheel3";
            this.labelWheel3.Size = new System.Drawing.Size(63, 20);
            this.labelWheel3.TabIndex = 5;
            this.labelWheel3.Text = "Wheel 3";
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(192, 333);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(501, 398);
            this.richTextBoxInput.TabIndex = 6;
            this.richTextBoxInput.Text = "";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(837, 333);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(501, 398);
            this.richTextBoxOutput.TabIndex = 7;
            this.richTextBoxOutput.Text = "";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(192, 310);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(43, 20);
            this.labelInput.TabIndex = 8;
            this.labelInput.Text = "Input";
            // 
            // labelPutput
            // 
            this.labelPutput.AutoSize = true;
            this.labelPutput.Location = new System.Drawing.Point(837, 310);
            this.labelPutput.Name = "labelPutput";
            this.labelPutput.Size = new System.Drawing.Size(55, 20);
            this.labelPutput.TabIndex = 9;
            this.labelPutput.Text = "Output";
            // 
            // numericUpDownWheel1
            // 
            this.numericUpDownWheel1.Location = new System.Drawing.Point(280, 140);
            this.numericUpDownWheel1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownWheel1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWheel1.Name = "numericUpDownWheel1";
            this.numericUpDownWheel1.Size = new System.Drawing.Size(63, 27);
            this.numericUpDownWheel1.TabIndex = 10;
            this.numericUpDownWheel1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownWheel2
            // 
            this.numericUpDownWheel2.Location = new System.Drawing.Point(364, 140);
            this.numericUpDownWheel2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownWheel2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWheel2.Name = "numericUpDownWheel2";
            this.numericUpDownWheel2.Size = new System.Drawing.Size(63, 27);
            this.numericUpDownWheel2.TabIndex = 11;
            this.numericUpDownWheel2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownWheel3
            // 
            this.numericUpDownWheel3.Location = new System.Drawing.Point(449, 140);
            this.numericUpDownWheel3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownWheel3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWheel3.Name = "numericUpDownWheel3";
            this.numericUpDownWheel3.Size = new System.Drawing.Size(63, 27);
            this.numericUpDownWheel3.TabIndex = 12;
            this.numericUpDownWheel3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(837, 117);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(501, 120);
            this.buttonEncode.TabIndex = 13;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // comboBoxReflector
            // 
            this.comboBoxReflector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReflector.FormattingEnabled = true;
            this.comboBoxReflector.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBoxReflector.Location = new System.Drawing.Point(192, 140);
            this.comboBoxReflector.Name = "comboBoxReflector";
            this.comboBoxReflector.Size = new System.Drawing.Size(63, 28);
            this.comboBoxReflector.TabIndex = 14;
            // 
            // labelReflector
            // 
            this.labelReflector.AutoSize = true;
            this.labelReflector.Location = new System.Drawing.Point(192, 117);
            this.labelReflector.Name = "labelReflector";
            this.labelReflector.Size = new System.Drawing.Size(69, 20);
            this.labelReflector.TabIndex = 15;
            this.labelReflector.Text = "Reflector";
            // 
            // comboBoxReflectorPos
            // 
            this.comboBoxReflectorPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReflectorPos.FormattingEnabled = true;
            this.comboBoxReflectorPos.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxReflectorPos.Location = new System.Drawing.Point(192, 173);
            this.comboBoxReflectorPos.Name = "comboBoxReflectorPos";
            this.comboBoxReflectorPos.Size = new System.Drawing.Size(63, 28);
            this.comboBoxReflectorPos.TabIndex = 16;
            // 
            // comboBoxWheel1Pos
            // 
            this.comboBoxWheel1Pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWheel1Pos.FormattingEnabled = true;
            this.comboBoxWheel1Pos.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxWheel1Pos.Location = new System.Drawing.Point(280, 173);
            this.comboBoxWheel1Pos.Name = "comboBoxWheel1Pos";
            this.comboBoxWheel1Pos.Size = new System.Drawing.Size(63, 28);
            this.comboBoxWheel1Pos.TabIndex = 17;
            // 
            // comboBoxWheel2Pos
            // 
            this.comboBoxWheel2Pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWheel2Pos.FormattingEnabled = true;
            this.comboBoxWheel2Pos.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxWheel2Pos.Location = new System.Drawing.Point(364, 173);
            this.comboBoxWheel2Pos.Name = "comboBoxWheel2Pos";
            this.comboBoxWheel2Pos.Size = new System.Drawing.Size(63, 28);
            this.comboBoxWheel2Pos.TabIndex = 18;
            // 
            // comboBoxWheel3Pos
            // 
            this.comboBoxWheel3Pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWheel3Pos.FormattingEnabled = true;
            this.comboBoxWheel3Pos.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxWheel3Pos.Location = new System.Drawing.Point(449, 173);
            this.comboBoxWheel3Pos.Name = "comboBoxWheel3Pos";
            this.comboBoxWheel3Pos.Size = new System.Drawing.Size(63, 28);
            this.comboBoxWheel3Pos.TabIndex = 19;
            // 
            // EnigmaMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 827);
            this.Controls.Add(this.comboBoxWheel3Pos);
            this.Controls.Add(this.comboBoxWheel2Pos);
            this.Controls.Add(this.comboBoxWheel1Pos);
            this.Controls.Add(this.comboBoxReflectorPos);
            this.Controls.Add(this.labelReflector);
            this.Controls.Add(this.comboBoxReflector);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.numericUpDownWheel3);
            this.Controls.Add(this.numericUpDownWheel2);
            this.Controls.Add(this.numericUpDownWheel1);
            this.Controls.Add(this.labelPutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.labelWheel3);
            this.Controls.Add(this.labelWheel2);
            this.Controls.Add(this.labelWheel1);
            this.Name = "EnigmaMachine";
            this.Text = "Enigma Machine";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWheel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWheel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWheel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelWheel1;
        private Label labelWheel2;
        private Label labelWheel3;
        private RichTextBox richTextBoxInput;
        private RichTextBox richTextBoxOutput;
        private Label labelInput;
        private Label labelPutput;
        private NumericUpDown numericUpDownWheel1;
        private NumericUpDown numericUpDownWheel2;
        private NumericUpDown numericUpDownWheel3;
        private Button buttonEncode;
        private ComboBox comboBoxReflector;
        private Label labelReflector;
        private ComboBox comboBoxReflectorPos;
        private ComboBox comboBoxWheel1Pos;
        private ComboBox comboBoxWheel2Pos;
        private ComboBox comboBoxWheel3Pos;
    }
}