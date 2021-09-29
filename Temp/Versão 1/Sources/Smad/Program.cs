using System;
using Smad.Pages;
using System.Windows.Forms;

namespace Smad {

    static class Program {

        [STAThread]
        static void Main() {
            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MasterPage());
            } catch {

            }
        }
    }
}