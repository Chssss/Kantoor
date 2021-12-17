using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace KantoorInrichtingWPF.Data
{
   public class Plattegrond_Database
    {
        public static Dictionary<int, List<string>> GetDatabase()
        {
            Dictionary<int, List<string>> output = new Dictionary<int, List<string>>();
            Dictionary<int, List<string>> outputPlategrondSQL = new Dictionary<int, List<string>>();
            Dictionary<int, List<string>> outputCanvasSQL = new Dictionary<int, List<string>>();
            int count = 0;
            int count1 = 0;
            int count2 = 0;
            #region plattegrond sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    String sql = "SELECT * FROM  ";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                List<string> listVaule = new List<string>();
                                listVaule.Add(reader.GetString(0));//project naam
                                listVaule.Add(reader.GetString(1));//plattegrond naam
                                listVaule.Add(reader.GetString(2));//datum
                                listVaule.Add(reader.GetString(3));//plattegrondcode
                                listVaule.Add(reader.GetString(4));//lengte
                                listVaule.Add(reader.GetString(5));//breedte
                                listVaule.Add(reader.GetString(6));//hoogte
                                /*
                                listVaule.Add(reader.GetString(7));//image type(type image)
                                listVaule.Add(reader.GetString(8));//image name(naam meubel)
                                listVaule.Add(reader.GetString(9));//image tag(prijs)
                                listVaule.Add(reader.GetString(10));//x coord
                                listVaule.Add(reader.GetString(11));//y coord
                                */
                                outputPlategrondSQL.Add(count1, listVaule);
                                count1++;
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
            #region plategrond canvas sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    String sql = "SELECT * FROM  ";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                List<string> listVaule = new List<string>();

                                listVaule.Add(reader.GetString(0));//plattegrondcode
                                listVaule.Add(reader.GetString(1));//image type(type image)
                                listVaule.Add(reader.GetString(2));//image name(naam meubel)
                                listVaule.Add(reader.GetString(3));//image tag(prijs)
                                listVaule.Add(reader.GetString(4));//x coord
                                listVaule.Add(reader.GetString(5));//y coord

                                outputCanvasSQL.Add(count2, listVaule);
                                count2++;
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
            return output;
            //return nepDatabase;
        }
        public static void DeleteFromDatabase(string naam)
        {
            #region test sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "";

                String sql = $"DELETE FROM  WHERE plattegrondcode =" + $"'{naam}'";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");


                    
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
            #endregion

        }
        public static void ToevoegenAanDatabase(string projectNaam, string plattegrondNaam,string datum, string plattegrondcode,string lengte,string breedte, string hoogte)
        {


            #region test sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(null, connection);
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                   
                    command.CommandText = $"INSERT INTO  VALUES () ";
/*
                    SqlParameter productcodeParam = new SqlParameter("@productcode", System.Data.SqlDbType.Text, 100);
                    SqlParameter leverancierParam = new SqlParameter("@leverancier", System.Data.SqlDbType.Text, 100);
                    SqlParameter imgParam = new SqlParameter("@img", System.Data.SqlDbType.Text, 100);
                    SqlParameter nameParam = new SqlParameter("@name", System.Data.SqlDbType.Text, 100);
                    SqlParameter prijsParam = new SqlParameter("@prijs", System.Data.SqlDbType.Text, 100);
                    SqlParameter lengteParam = new SqlParameter("@lengte", System.Data.SqlDbType.Text, 100);
                    SqlParameter breedteParam = new SqlParameter("@breedte", System.Data.SqlDbType.Text, 100);
                    SqlParameter tagParam = new SqlParameter("@tag", System.Data.SqlDbType.Text, 100);
                    SqlParameter categorieParam = new SqlParameter("@categorie", System.Data.SqlDbType.Text, 100);
                    SqlParameter hoogteParam = new SqlParameter("@hoogte", System.Data.SqlDbType.Text, 100);

                    productcodeParam.Value = productCode;
                    leverancierParam.Value = leverancier;
                    imgParam.Value = image;
                    nameParam.Value = naam;
                    prijsParam.Value = prijs;
                    lengteParam.Value = lengte;
                    breedteParam.Value = breedte;
                    tagParam.Value = tag;
                    categorieParam.Value = categorie;
                    hoogteParam.Value = hoogte;

                    command.Parameters.Add(productcodeParam);
                    command.Parameters.Add(leverancierParam);
                    command.Parameters.Add(imgParam);
                    command.Parameters.Add(nameParam);
                    command.Parameters.Add(prijsParam);
                    command.Parameters.Add(lengteParam);
                    command.Parameters.Add(breedteParam);
                    command.Parameters.Add(tagParam);
                    command.Parameters.Add(categorieParam);
                    command.Parameters.Add(hoogteParam);
*/
                    command.Prepare();
                    command.ExecuteNonQuery();

                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
            #endregion


        }

    }

}
