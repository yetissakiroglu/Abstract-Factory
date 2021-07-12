using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class OracleCommand : Command
    {
        public override void ExecuteCommand(string query)
        {
            // Gelen sorgunun çalıştırılması için
            // Gerekli operasyonel işlemler...
            Console.WriteLine("Sorgu Çalıştı: Sorgunuz: ", query);

        }
    }
}
