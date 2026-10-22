using System;
using System.Windows.Forms;
using OliveBranchBakes.Forms;

namespace OliveBranchBakes
{
    
    
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());
        }
    }
}
