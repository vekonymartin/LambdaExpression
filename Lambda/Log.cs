using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lambda
{
    class Log
    {
        public static Logger logger = new Logger();
        public static void Logging(string path, string text)
        {
            

            logger.AddLogMehtod(Console.WriteLine);
            logger.AddLogMehtod(message => File.AppendAllText("log.txt", message + Environment.NewLine));
            // It's not necessary
            logger.AddLogMehtod(message =>
            {
                using (StreamWriter sw = new StreamWriter("log2.txt", true))
                {
                    sw.WriteLine(message);
                }
            });

            logger.Log(text);
        }

        public static void Numbers(int border)
        {
            Random r = new Random();
            List<int> list = new List<int>();

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                list.Add(r.Next(border));
                Console.Write(list[i] + " ");
            }
            Console.WriteLine("\n");
            logger.Log(list.FindLast(number => number % 2 == 0).ToString());
            list.RemoveAll(number => number < 20 || number > 80);
            logger.Log(list.Aggregate("a", (text, number) => text + " " + number));
        }
    }
}
