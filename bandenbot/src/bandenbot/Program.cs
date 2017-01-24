using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bandenbot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stop = false;
            var config = Config.GetConfig();
            

            //ToDo: Add Bot

            while (!stop)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.S && key.Modifiers == ConsoleModifiers.Alt)
                {
                    stop = true;
                }
            }
        }
    }
}
