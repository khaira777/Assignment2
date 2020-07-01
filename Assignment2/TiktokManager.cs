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
                Console.WriteLine(line + "   //printing line");
                TIKTOKS.Add(TikTok.Parse(line));
            }
        }
        public static void Initialize()
        {
            TIKTOKS.Add(new TikTok("India",55,"Khaira",Audience.World));
            TIKTOKS.Add(new TikTok("USA", 66, "GK", Audience.Group));
            TIKTOKS.Add(new TikTok("Canada", 77, "Hyman", Audience.Group));
            TIKTOKS.Add(new TikTok("Australia", 88, "DudePerfect", Audience.World));
            TIKTOKS.Add(new TikTok("UK", 99, "Beneke", Audience.Special));
        }
        public static void Show()
        {
            foreach (TikTok tiktok in TIKTOKS)
            {
                Console.WriteLine(tiktok);
            }
        }
        public static void Show(string hashtag)
        {
            foreach (TikTok tiktok in TIKTOKS)
            {
                if (hashtag.Equals(tiktok.HashTag, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine(tiktok);
                }
            }
            
        }
        public static void Show(int length)
        {
            foreach (TikTok tiktok in TIKTOKS)
            {
                if (tiktok.Length > length)
                {
                    Console.WriteLine(tiktok);
                }
            }
        }
        public static void Show(Audience audience)
        {
            foreach (TikTok tiktok in TIKTOKS)
            {
                if (tiktok.Audience == audience)
                {
                    Console.WriteLine(tiktok);
                }
            }
        }

    }
}