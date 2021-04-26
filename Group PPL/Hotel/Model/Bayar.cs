using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Model
{
    class Bayar
    {
        string identitas, tipe, tipeBed, noKamar, extraBed, metode, bank;

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

        public string Metode
        {
            get { return metode; }
            set { metode = value; }
        }

        public string Bank
        {
            get { return bank; }
            set { bank = value; }
        }


        int harga, no;

        public int No
        {
            get { return no; }
            set { no = value; }
        }

        public int Harga
        {
            get { return harga; }
            set { harga = value; }
        }
    }
}
