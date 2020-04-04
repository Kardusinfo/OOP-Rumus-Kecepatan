using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDasar
{
    class Hitung
    {

        private double jarak;
        private double waktu;
        private double kecepatan;

        public double getJarak()
        {
            return jarak;
        }

        public void setJarak(double jaraknya)
        {
            jarak = jaraknya;
        }
        public double getWaktu()
        {
            return waktu;
        }

        public void setWaktu(double waktunya)
        {
            waktu = waktunya;
        }

        public void cariKecepatan()
        {
            kecepatan = jarak / waktu;
            Console.WriteLine($"Hasilnya adalah {kecepatan} m/s");
        }
    }
}
