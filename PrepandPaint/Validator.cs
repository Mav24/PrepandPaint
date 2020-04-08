using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepandPaint
{
    class Validator
    {
        public static bool IsPresent(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"{textBox.Tag} is a required field!", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool DateFormat(MaskedTextBox maskedTextBox)
        {
            DateTime dt;
            bool valid = DateTime.TryParseExact(maskedTextBox.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt);
            if (!valid)
            {
                MessageBox.Show($"{maskedTextBox} Date is not formated dd/mm/yyyy", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}
