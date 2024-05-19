using Oracle.ManagedDataAccess.Client;
using System;

namespace Escravo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int predio_max = 0;

            using (OracleConnection connection = new OracleConnection("Data Source=25.50.68.130:1521/freepdb1;User Id =Vanilla_for_dev;Password=Vanilla_for_dev;"))
            {
                try
                {
                    connection.Open();

                
                    using (OracleCommand cmd = new OracleCommand("select max(a.predio) as total from view_enderecos_cd a where a.ocupado = 'S'", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();                        
                            Console.WriteLine(reader["total"]);
                            predio_max = Convert.ToInt32(reader["total"]);                            
                        }
                    }
                }
                catch (Exception ex)
                {
                 
                }
            }
            for (int i = 1; i <= predio_max; i++)
            {
                using (OracleConnection connection = new OracleConnection("Data Source=25.50.68.130:1521/freepdb1;User Id =Vanilla_for_dev;Password=Vanilla_for_dev;"))
                {
                    try
                    {
                        connection.Open();


                        using (OracleCommand cmd = new OracleCommand($"select a.la from view_enderecos_cd a where a.predio = {i} and a.ocupado = 'S'", connection))
                        {
                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                Console.Write($"Predio {i} - ");
                                while (reader.Read())
                                {
                                    Console.Write($"{reader["la"]} ");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
}
