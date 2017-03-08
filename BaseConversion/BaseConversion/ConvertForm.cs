//////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Project:    Base Conversion
//
//    File Name:    ConvertForm.cs
//
//       Author:    Nicholas Yoder
//
//  Description:    ConvertForm is the only form for this application, containing all controls necessary
//                  to convert to decimal and from decimal. This file contains the events.
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;
using System.Globalization;

namespace BaseConversion
{
    /// <summary>
    /// The main form for this application, allowing the user to convert to and from decimal
    /// </summary>
    public partial class ConvertForm : Form
    {
        /// <summary>
        /// Constructor that sets the form's text
        /// </summary>
        public ConvertForm()
        {
            InitializeComponent();
            Text = "Base Converter";
        }

        /// <summary>
        /// If buttonFromDecimal is clicked, convert the text in textBoxDecimalVal
        /// into a new value of the specified base in textBoxNewBase.
        /// </summary>
        private void buttonFromDecimal_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBoxNewBase.Text =
                    BaseConverter.FromDecimal(textBoxDecimalVal.Text,
                    (int)numericUpDownBase.Value,
                    (int)numericUpDownDigits.Value);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Decimal input is too large for an integer.");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to convert decimal input to an integer.");
            }
        }

        /// <summary>
        /// If buttonToDecimal is clicked, convert the text in textBoxNewBase
        /// into a new value of base 10 in textBoxDecimalVal.
        /// </summary>
        private void buttonToDecimal_Click(object sender, EventArgs e)
        {
            // Ensure that no digit in the textbox is too large for the specified base
            bool isValid = true;

            string toConvert = textBoxNewBase.Text;

            for (int i = 0; i < toConvert.Length && isValid; i++)
            {
                int digit = int.Parse(toConvert[i].ToString(), NumberStyles.HexNumber);

                if (digit > numericUpDownBase.Value - 1)
                {
                    isValid = false;
                }
            }

            // Convert the number to decimal
            if (isValid)
            {
                try
                {
                    this.textBoxDecimalVal.Text =
                        BaseConverter.ToDecimal(textBoxNewBase.Text.TrimStart('0'),
                        (int)numericUpDownBase.Value,
                        (int)numericUpDownDigits.Value).ToString();
                }
                catch (OverflowException)
                {
                    MessageBox.Show("The base " + numericUpDownBase.Value +
                        " number is too large for an integer!");
                }
            }
            // Else display an error if the input was not valid
            else
            {
                MessageBox.Show("Invalid number of base " + numericUpDownBase.Value);
            }
        }

        /// <summary>
        /// Closes the application if buttonExit is clicked
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Updates labelOtherBase to reflect changes in the base of the number
        /// </summary>
        private void numericUpDownBase_ValueChanged(object sender, EventArgs e)
        {
            this.labelOtherBase.Text = $"Integer Value in Base {this.numericUpDownBase.Value}";
        }

        /// <summary>
        /// Performs input validation when the user enters text in textBoxNewBase
        /// </summary>
        private void textBoxNewBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If a-f is entered, capitalize it
            if (e.KeyChar >= 'a' && e.KeyChar <= 'f')
                e.KeyChar = Char.ToUpper(e.KeyChar);

            // If the key pressed is not 0-9 or A-F, it is invalid
            if (((e.KeyChar < '0' || e.KeyChar > 'F') ||
                (e.KeyChar > '9' && e.KeyChar < 'A')) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Performs input validation when the user enters text in textBoxDecimalVal
        /// </summary>
        private void textBoxDecimalVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the key pressed is not 0-9, it is invalid
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}