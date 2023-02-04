using NLog;
using WebAutomator.ReportHelper;

public class Program
{
    private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
    public static int Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        ReportManager.Instance.Log("Trace", "WebAutomator starts");
        ReportManager.Instance.Log("Debug", "WebAutomator starts");
        ReportManager.Instance.Log("Warn", "WebAutomator starts");
        ReportManager.Instance.Log("Error", "WebAutomator starts");
        ReportManager.Instance.Log("Fatal", "WebAutomator starts");
        ReportManager.Instance.Log("Info", "WebAutomator starts");
        return 0;
    }
}