using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Team.Exercise.Singleton
{
    public class Log
    {
        private static string _Path = $"";
        private static string _FileName = $"";
        private static Log _instance;
        private static string _message;
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

        public static void WriteonFile(string Message,string Metodo, Utente data)
        {
            StringBuilder sb = new StringBuilder();

            string FilePath = Path.Combine(_Path, _FileName);

            if (!File.Exists(FilePath))
            {
                string header = string.Format("MESSAGGIO -- DATA E ORA: STATO  USERNAME IP");
                sb.AppendLine(header);
            }

            sb.AppendLine();
            sb.AppendLine(string.Format($"{Message} {Metodo} -- {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss:fff")}: {data.Stato}  {data.Username} con IP: {data.IP}"));
            sb.AppendLine();
            File.AppendAllText(FilePath, sb.ToString());
        }
    }
}
