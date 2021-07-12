using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    // Soyut sınıfımızdır.
    public abstract class Command
    {
        // Komutu çalıştır
        public abstract void ExecuteCommand(string query);
    }
}
