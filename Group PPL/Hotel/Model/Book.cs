using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Model
{
    class Book
    {
        string tipe, tipeBed, noKamar, extraBed, identitas, status, tanggal, waktu;

        public string Waktu
        {
            get { return waktu; }
            set { waktu = value; }
        }

        public string Tanggal
        {
            get { return tanggal; }
            set { tanggal = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Identitas
        {
            get { return identitas; }
            set { identitas = value; }
        }

        public string Tipe
        {
            get { return tipe; }
            set { tipe = value; }
        }

        public string TipeBed
        {
            get { return tipeBed; }
            set { tipeBed = value; }
        }

        public string NoKamar
        {
            get { return noKamar; }
            set { noKamar = value; }
        }

        public string ExtraBed
        {
            get { return extraBed; }
            set { extraBed = value; }
        }

        int lantai, harga, jumlahHari;

        public int JumlahHari
        {
            get { return jumlahHari; }
            set { jumlahHari = value; }
        }

        public int Harga
        {
            get { return harga; }
            set { harga = value; }
        }

        public int Lantai
        {
            get { return lantai; }
            set { lantai = value; }
        }
    }
}
