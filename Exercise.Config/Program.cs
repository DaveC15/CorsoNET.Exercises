using System;
using Microsoft.Extensions.Configuration;

namespace Exercise.Config
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appconfig.json").Build();
            Setting settings = config.GetRequiredSection("setting").Get<Setting>();
            Console.WriteLine(settings.Username);
            Console.WriteLine(settings.Password);
        }
    }

    public class Setting
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
