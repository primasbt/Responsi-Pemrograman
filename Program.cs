using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilihan Menu Aplikasi ");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
            Console.WriteLine();
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            Console.WriteLine("Tambah Penjualan");

            Console.Write("Nota : ");
            string nota = Console.ReadLine();
            Console.Write("Tanggal : ");
            string tgl = Console.ReadLine();
            Console.Write("Customer : ");
            string cust = Console.ReadLine();
            Console.Write("Jenis [T/K] : ");
            string jenis = Console.ReadLine();
            Console.Write("Total Nota : ");
            int totalNota = Convert.ToInt32(Console.ReadLine());

            Penjualan pnj = new Penjualan(nota, tgl, cust, jenis, totalNota);

            daftarPenjualan.Add(pnj);

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            int i = 1;

            Console.WriteLine("Data Penjualan");

            foreach (Penjualan kk in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", i, kk.Nota, kk.Tanggal, kk.Cust, kk.Jenis, kk.TotalNota);
                i++;
            }

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}