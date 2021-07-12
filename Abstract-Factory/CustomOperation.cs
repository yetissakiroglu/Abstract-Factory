using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class CustomOperation
    {
        IDatabaseFactory _databaseFactory;
        Connection _connection;
        Command _command;

        public CustomOperation(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _command = databaseFactory.CreateCommand();
            _connection = databaseFactory.CreateConnection();
        }

        public void RemoveById(int id)
        {
            _connection.OpenConnection();
            // Gerçeği Yansıtmayaın Kod
            _command.ExecuteCommand("DELETE FROM personel WHERE bolum='1'");
            _connection.CloseConnection();
        }
    }
}
