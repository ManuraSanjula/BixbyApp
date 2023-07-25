using Bixbu_UI.Properties;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bixbu_UI;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        try
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += Application_ApplicationExit;

            var form = new BixbyApp();
            form.FormBorderStyle = FormBorderStyle.FixedSingle; // Prevent resizing
            form.MaximizeBox = false; // Disable maximize button
       
            Application.Run(form);
        }
        catch (Exception ex)
        {
            Settings.Default.TokenValue = null;
            Settings.Default.Save();

            Settings.Default.Email = null;
            Settings.Default.Save();
        }
    }
    private static void Application_ApplicationExit(object sender, EventArgs e)
    {
        /*Settings.Default.TokenValue = null;
        Settings.Default.Email = null;
        Settings.Default.Save();*/
    }
}