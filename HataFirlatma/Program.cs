using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataFirlatma
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.Run(new Form1());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            System.IO.File.AppendAllText("D:\\HataOku.txt", //C sürücüsüne dosya oluşturmasında hata çıkabilir bu sebeple D sürücüsünü seçtim
                e.Exception.Message + " " +
                e.Exception.Source + " " +
                e.Exception.StackTrace + " " +
                "\r\n\r\n".ToString());
        }
    }
}
