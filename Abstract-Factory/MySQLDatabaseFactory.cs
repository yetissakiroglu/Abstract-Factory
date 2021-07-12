using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class MySQLDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        {
            return new MySQLCommand();
        }

        public Connection CreateConnection()
        {
            return new MySQLConnection();
        }
    }
}
