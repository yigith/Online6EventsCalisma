using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrnek
{
    public delegate void OlayEylem();

    public class Animsatici
    {
        public event OlayEylem? Yap;

        public void Animsat(int saniye)
        {
            Console.Clear();
            while (saniye > 0)
            {
                Console.WriteLine(saniye--);
                Thread.Sleep(1000);
                Console.Clear();
            }

            if (Yap != null)
                Yap();
        }
    }
}
