using KantoorInrichtingWPF.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace KantoorInrichtingWPF.Data
{
   public class Leverancier_Database
    {
        public static Leverancier GetleverancierDataDatabase(string leverancier)
        {
            Leverancier outputLeverancierSQL = new Leverancier("testnaam","testemail","123");
           

            #region leverancier sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "Inventaris";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    String sql = "SELECT * FROM leverancier Where naam LIKE " + $"'{leverancier}'";//INSERT INTO leverancier VALUES ('Ikea', 'Ikea@gmail.com', '050-7111267')

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                outputLeverancierSQL.Naam = reader.GetString(0);
                                outputLeverancierSQL.Email = reader.GetString(1);
                                outputLeverancierSQL.TelefoonNR = reader.GetString(2);

                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
            #endregion

            return outputLeverancierSQL;
            //return nepDatabase;
        }

    }
}
