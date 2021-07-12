using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    // Soyut sınıfımızdır.
    abstract class Connection
    {
        //Bağlantı Açma
        public abstract bool OpenConnection();
        //Bağlantı Kapat
        public abstract bool CloseConnection();
    }
}
