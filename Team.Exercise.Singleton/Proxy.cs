using System;

namespace Team.Exercise.Singleton
{
    public class Proxy
    {
        private static Proxy _instance;
        private int[] _ip = new int[3];
        private Random _p = new Random();
        int[] memory = new int[3];
        Proxy()
        {
            for (int i = 0; i < _ip.Length; i++)
            {
                _ip[i] = _p.Next(10000, 50000);
            }
        }

        public static Proxy Getinstance()
        {
            if (_instance == null)
            {
                _instance = new Proxy();
            }
            return _instance;
        }

        public int IP()
        {
            int i = _p.Next(0, _ip.Length);
            for (int j = 0; j< memory.Length; j++)
            {
                if (memory[j] == _ip[i])
                {
                    IP();
                }
                else if (memory[j] == 0)
                {
                    memory[j] = _ip[i];
                    return _ip[i];
                }
            }

            return _ip[i];
        }
    }
}
