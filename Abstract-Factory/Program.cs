using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomOperation customOperationmysql = new CustomOperation(new MySQLDatabaseFactory());
            customOperationmysql.RemoveById(1);

            CustomOperation customOperationmyoracle = new CustomOperation(new OracleDatabaseFactory());
            customOperationmyoracle.RemoveById(1);


            Console.WriteLine("Kodlar Çalıştı");
        }
    }
}
