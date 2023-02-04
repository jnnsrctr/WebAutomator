using Microsoft.VisualBasic;
using NLog;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebAutomator.ReportHelper;


public class ReportManager
{
    private static readonly object padlock = new();
    private static ReportManager _instance;
    private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

    public ReportManager()
    {

    }
    public static ReportManager Instance
    {
        get
        {
            lock (padlock)
            {
                if (_instance == null)
                    _instance = new ReportManager();
            }
            return _instance;
        }
    }

    public void Log(string logLevel, string message)
    {
        switch (logLevel)
        {
            case "Trace":
                _logger.Trace(message);
                break;
            case "Debug":
                _logger.Debug(message);
                break;
            case "Info":
                _logger.Info(message);
                break;
            case "Warn":
                _logger.Warn(message);
                break;
            case "Error":
                _logger.Error(message);
                break;
            case "Fatal":
                _logger.Fatal(message);
                break;
            default:
                _logger.Info(message);
                break;
        }
    }
}