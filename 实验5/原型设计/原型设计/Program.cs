using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 原型设计
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
             */
            LoginForm f1 = new LoginForm();
            MainForm f2 = new MainForm();
            DialogResult dr1 = f1.ShowDialog();
            if (dr1 == DialogResult.Yes)
            {
                Application.Run(f2);
            }
        }
    }
}
