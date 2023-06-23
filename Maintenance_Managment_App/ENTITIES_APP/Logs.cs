using System;
using System.IO;
using System.Text;

namespace ENTITIES_APP
{
    public class Logs
    {
        public void GenerateLog(string logUsername, string logDescription)
        {
            string route = Path.GetFullPath(".\\..\\..\\..\\..\\FILES\\logs.txt");
            string date = DateTime.Now.Date.ToString("yyyy/MM/dd hh:mm:ss");

            string text = $"\n{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")} - {logUsername,-15} - {logDescription}";

            File.AppendAllText(route, text);
        }
    }
}
