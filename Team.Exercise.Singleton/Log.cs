using System;
using System.IO;
using System.Text;

namespace Team.Exercise.Singleton
{
    public class Log
    {
        private static string _Path = $"";
        private static string _FileName = $"";
        private static Log _instance;
        
        private Log(string Path, string FileName) 
        {
            _Path = Path;
            _FileName = FileName;
        }
        public static Log Instance(string Path, string FileName)
        {
            if (_instance == null)
            {
                _instance = new Log(Path, FileName);
            }
            return _instance;
        }

        public static void WriteonFile(Utente data)
        {
            StringBuilder sb = new StringBuilder();

            string FilePath = Path.Combine(_Path, _FileName);

            if (!File.Exists(FilePath))
            {
                string header = string.Format("      DATA E ORA:         STATO   USERNAME       IP");
                sb.AppendLine(header);
            }

            sb.AppendLine();
            sb.AppendLine(string.Format($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss:fff")}: {data.Stato}  {data.Username} con IP: {data.IP}"));
            sb.AppendLine();
            File.AppendAllText(FilePath, sb.ToString());

        }
    }
}
