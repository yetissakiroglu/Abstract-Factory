using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    // Oracle için ilişkili nesneler üretildi.
    class OracleDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        {
            return new OracleCommand();
        }
        public Connection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
