using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection
{


    public class SqlConnection : DBConnection
    {
        public override void OpenConnection()
        {
            Console.WriteLine("SQL Database Connection Open.");
            //throw new NotImplementedException();
        }
        public override void CloseConnection()
        {
            Console.WriteLine("SQL Database Connection Close.");

            //throw new NotImplementedException();
        }
    }


    public class OracleConnection : DBConnection
      {
        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Database Connection Open.");

            //throw new NotImplementedException();
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Database Connection CLose.");

            //throw new NotImplementedException();
        }

    }
    public abstract class DBConnection
    {

        public abstract void OpenConnection();
        public abstract void CloseConnection();





    }


    public class Program
    {

        public TimeSpan Timeout;
        public static void Main(String[] Args)
        {
            var sqlconn = new SqlConnection();
            var oracleconn = new OracleConnection();
            Console.WriteLine("Enter 'sql' or 'oracle' for choosing a DB for a connection :");
            var ConnectionString = Console.ReadLine();

            if (ConnectionString == "sql")
            {
                Console.WriteLine("Enter 'open' or 'close' for the connection: ");
                var sqlopen = Console.ReadLine();
                if (sqlopen == "open")
                {
                    sqlconn.OpenConnection();
                }
                else if (sqlopen == "close")
                {
                    sqlconn.CloseConnection();
                }
                else
                {
                    Console.WriteLine("Enter open or close.");
                }


            }
            else if (ConnectionString == "oracle")
            {
                Console.WriteLine("Enter 'open' or 'close' for the connection: ");
                var oracleopen = Console.ReadLine();
                if (oracleopen == "open")
                {
                    oracleconn.OpenConnection();
                }
                else if (oracleopen == "close")
                {
                    oracleconn.CloseConnection();
                }
                else
                {
                    Console.WriteLine("Enter open or close.");
                }
            }

            else
            {
                Console.WriteLine("Please Enter a valid DB.");
            }



        }
    }
}