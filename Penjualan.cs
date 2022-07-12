using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    public class Penjualan
    {
        private string nota, tanggal, cust, jenis;
        private int totalNota;

        public int TotalNota
        {
            get { return totalNota; }
            set { totalNota = value; }
        }

        public string Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public string Tanggal
        {
            get { return tanggal; }
            set { tanggal = value; }
        }

        public string Cust
        {
            get { return cust; }
            set { cust = value; }
        }

        public string Jenis
        {
            get { return jenis; }
            set { jenis = value; }
        }

        public Penjualan(string _nota, string _tanggal, string _cust, string _jenis, int _total)
        {
            this.nota = _nota;
            this.tanggal = _tanggal;
            this.cust = _cust;
            this.jenis = _jenis == "T" ? "Tunai" : "Kredit";
            this.totalNota = _total;
        }
        // PERINTAH: lengkapi property class penjualan, sesuai petunjuk soal
    }
}