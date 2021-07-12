using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    interface IDatabaseFactory
    {
        Connection CreateConnection();
        Command CreateCommand();
    }
}
