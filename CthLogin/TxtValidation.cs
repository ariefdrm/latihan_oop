using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CthLogin
{
    internal class TxtValidation
    {
        public static void txtValidation(KeyEventArgs e, TextBox currentObject, TextBox nextObject)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = currentObject.Text;
                if (text == "")
                {
                    MessageBox.Show("Data tidak boleh Kosong");
                }
                else
                {
                    nextObject.Focus();
                }
            }
        }
    }
}
