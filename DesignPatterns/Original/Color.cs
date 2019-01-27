using System;
using System.Collections.Generic;

namespace DesignPatterns.Original
{
    class Color
    {
        private static readonly Dictionary<int, Color> Cache = new Dictionary<int, Color>();

        private Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public int R { get; }
        public int G { get; }
        public int B { get; }

        public static Color Get(int r, int g, int b)
        {
            if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255)
                throw new ArgumentException();

            var key = r + (g * 1000) + (b * 100000);

            if (!Cache.ContainsKey(key))
                Cache.Add(key, new Color(r, g, b));

            Cache.TryGetValue(key, out var c);

            return c;
        }
    }
}

