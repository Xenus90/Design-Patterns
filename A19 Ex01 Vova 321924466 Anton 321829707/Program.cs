using System;
using System.Windows.Forms;

namespace A19_Ex01_Vova_321924466_Anton_321829707
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppUI());
        }
    }
}