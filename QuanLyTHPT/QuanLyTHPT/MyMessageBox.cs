using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTHPT
{
    public class MyMessageBox
    {
        public static void ShowError(string value)
        {
            MessageBox.Show(value, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowInformation(string value)
        {
            MessageBox.Show(value, "Nofi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static bool ShowQuestion(string value)
        {
            DialogResult result = MessageBox.Show(value, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }
    }
}
