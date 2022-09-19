using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTracker
{
    public class Utils
    {
        public static void OpenForm(Form fmParent, Form fmChild)
        {
            fmChild.MdiParent = fmParent;
            fmChild.StartPosition = FormStartPosition.CenterParent;
            fmChild.WindowState = FormWindowState.Maximized;
            fmChild.Show();
        }
    }
}
