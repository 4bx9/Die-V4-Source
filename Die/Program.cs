using Microsoft.Win32;

namespace Die
{
    internal static class Program
    {
        public static string doyoulikeitsugarplum = string.Empty;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {

            const string regp = @"HKEY_CURRENT_USER\Software\Die";
            const string regn = "IPLAYEDTHESEGAMESBEFOREEEE";

            object myass = Registry.GetValue(regp, regn, null);

            if (myass != null && (string)myass == "uhuh")
            {
               // MessageBox.Show("You have already used this application.");
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            else
            {
                Registry.SetValue(regp, regn, "uhuh");
                MessageBox.Show("Welcome to Die V4, This is a One-Time message Press Ok To Proceed.");
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
        }
    }
}