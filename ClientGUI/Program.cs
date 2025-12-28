using System.Diagnostics;

namespace ClientGUI;

static class Program
{
    public static Process pythonServer = new Process();
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        try
        {
            pythonServer.StartInfo.FileName = "PythonServer";
            pythonServer.StartInfo.UseShellExecute = false;
            pythonServer.StartInfo.CreateNoWindow = true;

            pythonServer.Start();

            Thread.Sleep(500);
        }

        catch (Exception ex)
        {
            MessageBox.Show($"Failed to start python server: {ex.Message}");
            return;
        }

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());

        try
        {
            if (pythonServer != null && !pythonServer.HasExited)
            {
                pythonServer.Kill();
                pythonServer.Dispose();
            }
        }
        catch
        {

        }
    }   
}