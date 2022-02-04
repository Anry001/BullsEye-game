using System;
using System.Windows.Forms;

namespace BullsEye
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NumberOfGuessesForm());
        }
    }
}
