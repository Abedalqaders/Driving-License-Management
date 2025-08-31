using System;
using System.Windows.Forms;

namespace ApplicationLayer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the Login form first
            Login loginForm = new Login();
            DialogResult result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // You can pass loginForm.UserId if needed
                Application.Run(new MainForm(loginForm.UserId));
            }
        }
    }
}
