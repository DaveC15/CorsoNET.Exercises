using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise.Logger
{
    public class Log
    {
        private static string _Path;
        private static Log _instance; private Log()
        {
            _Path = @"C:\LOG\class.csv";
        }
        public static Log Instance()
        {
            if (_instance == null)
            {
                _instance = new Log();
            }
            return _instance;
        }
        public void WriteLog<T>(T message) where T : class
        {
            StringBuilder sb = new StringBuilder();
            var prova = message.GetType().GetProperties().ToList();

            sb.AppendLine($"Tipo classe: {message.GetType().Name}");
            sb.AppendLine();
            sb.AppendLine($"Proprietà: ");
            foreach ( var prop in prova )
            {
                sb.AppendLine($"{prop.Name}, {prop.GetValue(message)}");
            }
            
            File.AppendAllText(_Path, sb.ToString());
        }
    }
}
