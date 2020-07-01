using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

namespace Assignment2
{
    public static class TiktokManager
    {
        private static List<TikTok> TIKTOKS;
        private static string FILENAME = "tiktok.txt";

        static TiktokManager()
        {
            TIKTOKS = new List<TikTok>();
            string line;
            StreamReader file = new StreamReader(FILENAME);
            while (null != (line = file.ReadLine()))
            {
                line = file.ReadLine();
                Console.WriteLine(line);
                TIKTOKS.Add(TikTok.Parse(line));
            }
        }
        public static void Initialize()
        {

        }
        public static void Show()
        {

        }
        public static void Show(string hashtag)
        {

        }
        public static void Show(int length)
        {

        }
        public static void Show(Audience audience)
        {

        }

    }
}