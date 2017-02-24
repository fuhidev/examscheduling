using System;
using System.Threading;
using System.Windows.Forms;

namespace ExamSchedule.GUI.WindowsWait
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new WaitForm("aa"));
            WaitFormManager.ShowWaitForm("a");
            WaitFormManager.CloseWaitForm();
        }
    }
}