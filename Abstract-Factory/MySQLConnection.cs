using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class MySQLConnection : Connection
    {
        public override bool CloseConnection()
        {  
            // MySQL veri tabanı bağlantısının açılması için
            // Gerekli operasyonel işlemler...
            return true;
        }

        public override bool OpenConnection()
        {
            // MySQL veri tabanı bağlantısının kapatılması için
            // Gerekli operasyonel işlemler...
            return true;
        }
    }
}
