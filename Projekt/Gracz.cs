using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Gracz
    {
        public string nazwaGracza;
        public Color KolorGracza;
        public int punkty=0;
        public Gracz(string name, string color)
        {
            nazwaGracza = name;
            KolorGracza = Color.FromName(color);
        }
    }
}
