using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Model
{
    class Kamar
    {
        string noKamar, tipe, tipeBed;

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

        int lantai, harga, extraBed;

        public int Lantai
        {
            get { return lantai; }
            set { lantai = value; }
        }

        public int Harga
        {
            get { return harga; }
            set { harga = value; }
        }

        public int ExtraBed
        {
            get { return extraBed; }
            set { extraBed = value; }
        }
    }
}
