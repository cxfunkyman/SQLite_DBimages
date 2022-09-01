using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite_DBimages
{
    internal class Validator
    {
        public static bool IsEmpty(string text) //check if the textbox is empty
        {
            if (text == "")
            {                
                return false;
            }
            return true;
        }
        public static bool IsADigit(string text)
        {
            int tempID;

            if (!(Int32.TryParse(text, out tempID)))
            {
                MessageBox.Show("Attention, seuls les chiffres sont acceptés", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            else
                return true;
        }
    }
}
