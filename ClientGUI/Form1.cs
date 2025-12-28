using System.Diagnostics;

namespace ClientGUI;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            var process = new Process();
            process.StartInfo.FileName = "ClientCLI";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            label2.Text = output.Trim();
        }

        catch (Exception ex)
        {
            label2.Text = $"Error: {ex.Message}";
        }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            if (Program.pythonServer != null && !Program.pythonServer.HasExited)
            {
                Program.pythonServer.Kill();
                Program.pythonServer.Dispose();
            }
        }
        catch
        {

        }
    }
}
