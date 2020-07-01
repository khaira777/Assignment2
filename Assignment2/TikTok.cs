﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2
{
    public enum Audience { World, Group, Special }
    class TikTok
    {
        private static int _ID;
        public string Originator { get; }
        public int Length { get; }
        public string HashTag { get; }
        public Audience Audience { get; }
        public int Id { get; }

        public TikTok(string originator, int length, string hashTag, Audience audience)
        {
            Originator = originator;
            Length = length;
            HashTag = hashTag;
            Audience = audience;
            Id = _ID;
            _ID++;
        }

        public TikTok(int id, string originator, int length, string hashTag, Audience audience)
        {
            Id = id;
            Originator = originator;
            Length = length;
            HashTag = hashTag;
            Audience = audience;
        }

        public override string ToString()
        {
            return $"({Id}) {HashTag} : From {Originator}, have length {Length} and audience is {Audience}";
        }

        public static TikTok Parse(string line)
        {

            String[] parts = line.Split('\t');
            string origin = parts[0];
            int len = Convert.ToInt32(parts[1]);
            string hash = parts[2];
            Audience aud = (Audience)Enum.Parse(typeof(Audience), parts[3]);
            TikTok t = new TikTok(01, origin, len, hash, aud);
            Console.WriteLine(t+"   //printing t");
            return t;
        }
    }
}