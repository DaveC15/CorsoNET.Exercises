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
                string header = string.Format("     Ora,     IP,    stato");
                sb.AppendLine(header);
            }


            sb.AppendLine(string.Format($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss:fff")}, {data.IP}, {data.Stato}"));
            sb.AppendLine();
            File.AppendAllText(FilePath, sb.ToString());

        }
    }
}
