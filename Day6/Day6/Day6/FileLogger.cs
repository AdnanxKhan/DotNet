using System;
using System.IO;
namespace Day6
{
    public class Filelogger : ILogger
    {
        private readonly string _path;
        public Filelogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "ERROR");

        }
        public void LogInfo(string message)
        {
            Log(message, "ERROR");
        }
        private void Log(string message, string messageType)
        {
            using (var streamwriter = new StreamWriter(_path, true))
            {
                streamwriter.WriteLine("error " + message);
            }
        }
        
    }
}

       
        