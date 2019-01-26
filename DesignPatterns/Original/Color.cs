using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Original {
    class Color {
        // slovnik pro kontrolu existence instance se stejnymi parametry
        private readonly static Dictionary<int, Color> cache
            = new Dictionary<int, Color>();
        private readonly int r;
        private readonly int g;
        private readonly int b;


        // privatni konstruktor
        private Color(int pR, int pG, int pB) {
            this.r = pR;
            this.g = pG;
            this.b = pB;
        }


        public static Color Get(int pR, int pG, int pB) {
            if (pR < 0 || pR > 255 || pG < 0 || pG > 255 || pB < 0 || pB > 255) {
                throw new ArgumentException();
            }

            // generovani klice
            int key = pR + (pG * 1000) + (pB * 100000);
            
            if (!cache.ContainsKey(key)) {
                Color.cache.Add(key, new Color(pR, pG, pB));
            }

            Color c;
            cache.TryGetValue(key, out c);

            return c;
        }

        public int GetR() {
            return this.r;
        }
        public int GetG() {
            return this.g;
        }
        public int GetB() {
            return this.b;
        }
    }
}

