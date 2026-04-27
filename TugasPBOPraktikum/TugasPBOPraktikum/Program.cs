using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace TugasPBO
{
    class Kendaraan
    {
        public string Nama;
        public int Kecepatan;

        public virtual void Bergerak()
        {

        }

        public void Infokendaraan()
        {
            Console.WriteLine(
                $"Nama Kendaraan : {Nama}\n" +
                $"Kecepatan : {Kecepatan}");
        }
    }

    class Darat : Kendaraan
    {
        public int JumlahRoda;
        public int HitungRoda()
        {
            return JumlahRoda;
        }
    }

    class Air : Kendaraan
    {
        public string JenisAir;

        public void CekKondisiAir(bool kondisiair)
        {
            if (kondisiair = true)
            {
                Console.WriteLine($"Kondisi Air {JenisAir} Bagus");
            }
            else
            {
                Console.WriteLine($"Kondisi Air {JenisAir} Jelek");
            }
        }
    }

    class Mobil : Darat
    {
       public void Klakson()
       {
            Console.WriteLine("Mobil mengeluarkan klakson TINN! TIIIIIN!");
       }
       public void GasPol()
       {
            Console.WriteLine("Mobil gaspol dengan cepat!");
       }

       public override void Bergerak()
       {
           Console.WriteLine("Mobil Mulai Bergerak");
       }
    }
    class Motor : Darat
    {
        public void Klakson()
        {
            Console.WriteLine("Motor mengeluarkan klakson TINN! TIIIIIN!");
        }
        public void GasPol()
        {
            Console.WriteLine("Motor gaspol dengan cepat!");
        }
        public override void Bergerak()
        {
            Console.WriteLine("Motor Mulai Bergerak");
        }
    }

    class Kapal : Air
    {
        public void Berlayar()
        {
            Console.WriteLine("Kapal mulai berlayar di laut");
        }

        public void Dayung()
        {
            Console.WriteLine("Kapal mulai didayung");
        }
        public override void Bergerak()
        {
            Console.WriteLine("Kapal Mulai Bergerak");
        }
    }

    class Perahu : Air
    {
        public void Berlayar()
        {
            Console.WriteLine("Perahu mulai berlayar di Danau");
        }
        public void Dayung()
        {
            Console.WriteLine("Perahu mulai didayung");
        }
        public override void Bergerak()
        {
            Console.WriteLine("Perahu Mulai Bergerak");
        }
    }

    class Garasi
    {
        public List<string> KoleksiKendaraan;

        public Garasi()
        {
            KoleksiKendaraan = new List<string>();
        }

        public void TambahKendaraan(string koleksikendaraan)
        {
            KoleksiKendaraan.Add(koleksikendaraan);
        }
        public void DaftarKendaraan()
        {
            for (int i = 0; i < KoleksiKendaraan.Count; i++)
            {
                Console.WriteLine($"Kendaraan ke {i + 1} = {KoleksiKendaraan[i]}");
            }
        }
    }

    class Program
    {
        public static void Main()
        {

            // Penggunaan Garasi, Menambahkan dan Melihat Daftarnya
            Garasi GarasiNabil = new Garasi();
            Mobil Avanza = new Mobil();
            Avanza.Nama = "AvanzaSport";
            Avanza.Kecepatan = 10;
            Avanza.JumlahRoda = 4;
            Motor Honda = new Motor();
            Honda.Nama = "HondaSport";
            Kapal Feri = new Kapal();
            Feri.Nama = "Mariana";
            Perahu Kayak = new Perahu();
            Kayak.Nama = "PenebasLawud";
            GarasiNabil.TambahKendaraan(Avanza.Nama);
            GarasiNabil.TambahKendaraan(Honda.Nama);
            GarasiNabil.TambahKendaraan(Feri.Nama);
            GarasiNabil.TambahKendaraan(Kayak.Nama);
            GarasiNabil.DaftarKendaraan();

            // Demonstrasi Polymorphism

            Avanza.Bergerak();
            Honda.Bergerak();
            Feri.Bergerak();
            Kayak.Bergerak();

            // Method Khusus

            Avanza.Infokendaraan();
            Console.WriteLine($"Roda Avanza = {Avanza.HitungRoda()}");

            Air AirTawar = new Air();
            AirTawar.JenisAir = "Tawar";
            AirTawar.CekKondisiAir(true);

            Avanza.Klakson();
            Honda.Klakson();
            Feri.Berlayar();
            Kayak.Berlayar();

            Kayak.Dayung();

            Kendaraan Supra = new Motor();
            Supra.Bergerak();
        }
    }
}