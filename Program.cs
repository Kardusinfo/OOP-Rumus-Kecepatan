using System;

namespace OOPDasar
{
    class Program
    {

/*     Mainan Motor – motoran Kak Candra menempuh jarak 100 meter dengan waktu 25 detik.
       Berapakah kecepatan motor-motoran Kak Candra?
*/
        static void Main(string[] args)
        {
            //proses inisialiasi
            var hitung = new Hitung();

            //proses input jarak
            Console.WriteLine("Masukkan jarak dalam satuan meter");
            double jarakKu = Convert.ToDouble(Console.ReadLine());
            hitung.setJarak(jarakKu);

            //proses input waktu
            Console.WriteLine("Masukkan waktu dalam satuan detik");
            double waktuKu = Convert.ToDouble(Console.ReadLine());
            hitung.setWaktu(waktuKu);

            //proses menampilkan data waktu dan jarak
            Console.WriteLine($"Jarak adalah {hitung.getJarak()} m");
            Console.WriteLine($"Waktu adalah {hitung.getWaktu()} s");

            //proses perhitungan waktu
            hitung.cariKecepatan();

           
        }
    }
}
