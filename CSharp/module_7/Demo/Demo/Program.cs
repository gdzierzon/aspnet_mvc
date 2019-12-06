using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {

        static void Main(string[] args)
        {

            SqlConnection connection = null;

            try
            {
                DoWork();
                connection =
                    new SqlConnection(""); //"Data Source=localhost;initial catalog=finance;integrated security=true;");

                connection.Open();
                //get some data

                Console.WriteLine("Connection succeeded");

            }
            catch (Exception e)
            {
                //log information Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        private static void DoWork()
        {
            throw new Exception("custom message"); 
        }
    }
}
