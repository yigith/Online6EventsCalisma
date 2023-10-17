using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace Online6SuDeposu
{
    public class SuDeposu
    {
        public event SuMiktariDegisimOlayi? SuMiktariDegisti;
        public event DepoDolmaOlayi? DepoDoldu;

        public int Kapasite { get; }
        public int SaniyedeAzalan { get; }
        public int SuMiktari { get; private set; }
        public double DolulukOrani => (double)SuMiktari / Kapasite;

        public SuDeposu(int kapasite, int saniyedeAzalan)
        {
            if (Kapasite < 0)
                throw new ArgumentException("Kapasite sıfırdan küçük olamaz.");

            if (saniyedeAzalan < 0)
                throw new ArgumentException("Drenaj miktarı sıfırdan küçük olamaz.");

            Kapasite = kapasite;
            SaniyedeAzalan = saniyedeAzalan;

            if (saniyedeAzalan > 0)
            {
                Timer timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += Azalt;
                timer.Start();
            }
        }

        private void Azalt(object? sender, EventArgs e)
        {
            int yeniMiktar = Math.Max(SuMiktari - SaniyedeAzalan, 0);

            if (yeniMiktar != SuMiktari)
            {
                SuMiktari = yeniMiktar;

                if (SuMiktariDegisti != null)
                    SuMiktariDegisti();
            }

        }

        public void SuEkle(int miktar)
        {
            if (miktar < 0) 
                throw new ArgumentException("Miktar sıfırdan küçük olamaz.");

            int mevcutMiktar = SuMiktari;
            int hedefMiktar = SuMiktari + miktar;
            int yeniMiktar = Math.Min(Kapasite, hedefMiktar);

            // SU MİKTARI ARTTI
            if (yeniMiktar > mevcutMiktar)
            {
                SuMiktari = yeniMiktar;
                if (SuMiktariDegisti != null)
                    SuMiktariDegisti();

                // DEPO DOLDU VEYA DOLDU+TAŞTI
                if (hedefMiktar >= Kapasite)
                {
                    int tasanMiktar = hedefMiktar - Kapasite;
                    if (DepoDoldu != null)
                        DepoDoldu(tasanMiktar);
                }
            }
        }

    }
}
