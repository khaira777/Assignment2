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
            TextReader file = new StreamReader(FILENAME);
            while (null != file.ReadLine())
            {
                TIKTOKS.Add(TikTok.Parse(file.ReadLine()));
            }
        }
        public static void Initialize()
        {
            //Assigns the TIKOKS field
            TIKTOKS.Add(new TikTok(originator: "India",length: 55,hashTag: "Khaira",audience: Audience.World));
            TIKTOKS.Add(new TikTok(originator: "USA", length: 66, hashTag: "GK", audience: Audience.Group));
            TIKTOKS.Add(new TikTok(originator: "Canada", length: 77, hashTag: "Hyman", audience: Audience.Group));
            TIKTOKS.Add(new TikTok(originator: "Australia", length: 88, hashTag: "DudePerfect", audience: Audience.World));
            TIKTOKS.Add(new TikTok(originator: "UK", length: 99, hashTag: "Beneke", audience: Audience.Special));
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
                if (tiktok.HashTag.Equals(hashtag, StringComparison.InvariantCultureIgnoreCase))
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
                if (tiktok.Audience.Equals(audience))
                {
                    Console.WriteLine(tiktok);
                }
            }
        }
    }
}