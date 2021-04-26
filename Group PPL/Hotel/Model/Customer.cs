using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Model
{
    class Customer
    {
        string nama, jenisIdentitas, identitas;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string JenisIdentitas
        {
            get { return jenisIdentitas; }
            set { jenisIdentitas = value; }
        }

        public string Identitas
        {
            get { return identitas; }
            set { identitas = value; }
        }

    }
}
