using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataFirlatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Program.cs dosyasındaki Main metoduna 
         * 
         * Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
         * 
         * Ekleniyor. Application_ThreadException metodu aşağıdaki gibi olacak;
         * 
         * private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
                {
                    System.IO.File.AppendAllText("D:\\HataOku.txt",
                        e.Exception.Message + " " +
                        e.Exception.Source + " " +
                        e.Exception.StackTrace + " " +
                        "\r\n\r\n".ToString());
                }
         *          
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 5;
            int j = 0;
            int x = i / j;
        }
    }
}
