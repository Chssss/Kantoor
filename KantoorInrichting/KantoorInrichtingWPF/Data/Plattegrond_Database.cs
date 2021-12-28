using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows;

namespace KantoorInrichtingWPF.Data
{
   public class Plattegrond_Database
    {
        public static Dictionary<int, List<string>> GetPlattegrondDataDatabase()
        {
            Dictionary<int, List<string>> outputPlategrondSQL = new Dictionary<int, List<string>>(); 
            int count1 = 0;
            
            #region plattegrond sql
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

                    String sql = "SELECT * FROM plattegrond ";

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
           
            return outputPlategrondSQL;
            //return nepDatabase;
        }
        public static Dictionary<int, List<string>> GetPlattegrondCanvasDataDatabase(string plattegrondcode)
        {
            Dictionary<int, List<string>> outputCanvasSQL = new Dictionary<int, List<string>>();
            int count2 = 0;
           
            #region plategrond canvas sql
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

                    String sql = "SELECT * FROM canvasItem WHERE plattegrondcode =" + $"'{plattegrondcode}'";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                List<string> listVaule = new List<string>();
                                listVaule.Add(reader.GetString(0));//canvasItemcode
                                listVaule.Add(reader.GetString(1));//plattegrondcode
                                listVaule.Add(reader.GetString(2));//image type(type image)
                                listVaule.Add(reader.GetString(3));//image name(naam meubel)
                                listVaule.Add(reader.GetString(4));//image tag(prijs)
                                listVaule.Add(reader.GetString(5));//x coord
                                listVaule.Add(reader.GetString(6));//y coord

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
            return outputCanvasSQL;
            //return nepDatabase;
        }
        public static void DeletePlategrondFromDatabase(string plattegrondcode)
        {
            #region delete plattegrondData sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "Inventaris";

                String sql = $"DELETE FROM plattegrond WHERE plattegrondcode = " + $"'{plattegrondcode}'";
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
            #region delete canvasData sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "Inventaris";

                String sql = $"DELETE FROM canvasItem WHERE plattegrondcode = " + $"'{plattegrondcode}'";
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
        public static void DeleteCanvasitemFromDatabase(string plattegrondcode)
        {
            
            #region delete canvasData sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "Inventaris";

                String sql = $"DELETE FROM canvasItem WHERE plattegrondcode = " + $"'{plattegrondcode}'";
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
            #region toevoegen plattegrond
            /*try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "Inventaris";

                String sql = $"INSERT INTO plattegrond VALUES ({projectNaam}, {plattegrondNaam}, {datum}, {plattegrondcode}, {lengte}, {breedte}, {hoogte} )";
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
            Console.ReadLine();*/
            #endregion

            #region toevoegen plattegrondData sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "Inventaris";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(null, connection);
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");


                    command.CommandText = $"INSERT INTO plattegrond VALUES (@projectnaam, @plattegrondnaam, @datum, @plattegrondcode, @lengte, @breedte, @hoogte ) ";

                    SqlParameter projectNaamParam = new SqlParameter("@projectnaam", System.Data.SqlDbType.Text, 100);
                    SqlParameter plattegrondNaamParam = new SqlParameter("@plattegrondnaam", System.Data.SqlDbType.Text, 100);
                    SqlParameter datumParam = new SqlParameter("@datum", System.Data.SqlDbType.Text, 100);
                    SqlParameter plattegrondcodeParam = new SqlParameter("@plattegrondcode", System.Data.SqlDbType.Text, 100);

                    SqlParameter lengteParam = new SqlParameter("@lengte", System.Data.SqlDbType.Text, 100);
                    SqlParameter breedteParam = new SqlParameter("@breedte", System.Data.SqlDbType.Text, 100);
                    SqlParameter hoogteParam = new SqlParameter("@hoogte", System.Data.SqlDbType.Text, 100);

                    projectNaamParam.Value = projectNaam;
                    plattegrondNaamParam.Value = plattegrondNaam;
                    datumParam.Value = datum;
                    plattegrondcodeParam.Value = plattegrondcode;
                    lengteParam.Value = lengte;
                    breedteParam.Value = breedte;
                    hoogteParam.Value = hoogte;

                    command.Parameters.Add(projectNaamParam);
                    command.Parameters.Add(plattegrondNaamParam);
                    command.Parameters.Add(datumParam);
                    command.Parameters.Add(plattegrondcodeParam);

                    command.Parameters.Add(lengteParam);
                    command.Parameters.Add(breedteParam);

                    command.Parameters.Add(hoogteParam);

                    command.Prepare();
                    command.ExecuteNonQuery();

                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("ToevoegenAanDatabase " + e.ToString());
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
            #endregion

        }
        public static void ToevoegenCanvasDataAanDatabase(string plattegrondcode, string canvasItemcode, string image_name_typeImage, string image_tag_naamMeubel, string image_tag_prijs, string x_coord, string y_coord)
        {
            #region toevoegen canvasData
            /* try
             {
                 SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                 builder.DataSource = "127.0.0.1, 1433";
                 builder.UserID = "sa";
                 builder.Password = "Kantoorinrichting!";
                 builder.InitialCatalog = "Inventaris";

                 String sql = $"INSERT INTO canvasItem VALUES ({plattegrondcode}, {canvasItemcode}, {image_name_typeImage}, {image_tag_naamMeubel}, {image_tag_prijs}, {x_coord}, {y_coord}) ";
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
             Console.ReadLine();*/
            #endregion
            #region toevoegen canvasData sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "Inventaris";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(null, connection);
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");


                    command.CommandText = $"INSERT INTO canvasItem VALUES (@plattegrondcode, @canvasItemcode, @imageNameTypeImage, @imageTagNaamMeubel, @imageTagPrijs, @xcoord, @ycoord) ";

                    //SqlParameter test = new SqlParameter("", System.Data.SqlDbType.Text, 100);
                    //test.Value = ;
                    //command.Parameters.Add(test);

                    SqlParameter plattegrondcodeParam = new SqlParameter("@plattegrondcode", System.Data.SqlDbType.Text, 100);
                    SqlParameter canvasItemcodeParam = new SqlParameter("@canvasItemcode", System.Data.SqlDbType.Text, 100);
                    SqlParameter imageNameTypeImage = new SqlParameter("@imageNameTypeImage", System.Data.SqlDbType.Text, 100);
                    SqlParameter imageTagNaamMeubel = new SqlParameter("@imageTagNaamMeubel", System.Data.SqlDbType.Text, 100);
                    SqlParameter imageTagPrijs = new SqlParameter("@imageTagPrijs", System.Data.SqlDbType.Text, 100);
                    SqlParameter xcoord = new SqlParameter("@xcoord", System.Data.SqlDbType.Text, 100);
                    SqlParameter ycoord = new SqlParameter("@ycoord", System.Data.SqlDbType.Text, 100);

                    plattegrondcodeParam.Value = plattegrondcode;
                    canvasItemcodeParam.Value = canvasItemcode;
                    imageNameTypeImage.Value = image_name_typeImage;
                    imageTagNaamMeubel.Value = image_tag_naamMeubel;
                    imageTagPrijs.Value = image_tag_prijs;
                    xcoord.Value = x_coord;
                    ycoord.Value = y_coord;

                    command.Parameters.Add(plattegrondcodeParam);
                    command.Parameters.Add(canvasItemcodeParam);
                    command.Parameters.Add(imageNameTypeImage);
                    command.Parameters.Add(imageTagNaamMeubel);
                    command.Parameters.Add(imageTagPrijs);
                    command.Parameters.Add(xcoord);
                    command.Parameters.Add(ycoord);

                    command.Prepare();
                    command.ExecuteNonQuery();

                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("ToevoegenCanvasDataAanDatabase " + e.ToString());
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
            #endregion
        }
        public static Dictionary<int, List<string>> ZoekenNaamPlattegrondDatabase(string zoekbalk) 
        {
            Dictionary<int, List<string>> outputPlategrondSQL = new Dictionary<int, List<string>>();
            int count1 = 0;

            #region plattegrond sql
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

                    String sql = "SELECT * FROM plattegrond WHERE plattegrondnaam LIKE " + $"'%{zoekbalk}%'";

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

            return outputPlategrondSQL;
        }
        public static Dictionary<int, List<string>> ZoekenNaamProjectDatabase(string zoekbalk)
        {
            Dictionary<int, List<string>> outputPlategrondSQL = new Dictionary<int, List<string>>();
            int count1 = 0;

            #region plattegrond sql
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

                    String sql = "SELECT * FROM plattegrond WHERE projectnaam LIKE " + $"'%{zoekbalk}%'";

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

            return outputPlategrondSQL;
        }
        public static string GetPlattegrondcodeDataDatabase(string plattegrondcode)
        {

            string output="leeg";
            #region plattegrond sql
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

                    String sql = "SELECT plattegrondcode FROM plattegrond WHERE plattegrondcode = " + $"'{plattegrondcode}'";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                
                                 output =reader.GetString(0);
                               
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
        public static void UpdateDatabase(string projectNaam, string plattegrondNaam, string datum, string plattegrondcode, string lengte, string breedte, string hoogte)
        {
           

            #region update plattegrondData sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "Inventaris";


                String sql = $"UPDATE plattegrond SET projectnaam = '{projectNaam}', plattegrondnaam = '{plattegrondNaam}', datum = '{datum}', plattegrondcode = '{plattegrondcode}', lengte = '{lengte}', breedte = '{breedte}', hoogte = '{hoogte}' WHERE plattegrondcode LIKE " + $"'{plattegrondcode}'";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");



                    command.ExecuteNonQuery();
                }
                #region old code
                /*using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(null, connection);
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    //projectnaam plattegrondnaam datum plattegrondcode lengte breedte hoogte
                    command.CommandText = $"UPDATE plattegrond SET projectnaam = '@projectnaam', plattegrondnaam = '@plattegrondnaam', datum = '@datum', plattegrondcode = '@plattegrondcod', lengte = '@lengte', breedte = '@breedte', hoogte = '@hoogte' WHERE plattegrondcode LIKE " + $"'{plattegrondcode}'";

                    SqlParameter projectNaamParam = new SqlParameter("@projectnaam", System.Data.SqlDbType.Text, 100);
                    SqlParameter plattegrondNaamParam = new SqlParameter("@plattegrondnaam", System.Data.SqlDbType.Text, 100);
                    SqlParameter datumParam = new SqlParameter("@datum", System.Data.SqlDbType.Text, 100);
                    SqlParameter plattegrondcodeParam = new SqlParameter("@plattegrondcod", System.Data.SqlDbType.Text, 100);

                    SqlParameter lengteParam = new SqlParameter("@lengte", System.Data.SqlDbType.Text, 100);
                    SqlParameter breedteParam = new SqlParameter("@breedte", System.Data.SqlDbType.Text, 100);
                    SqlParameter hoogteParam = new SqlParameter("@hoogte", System.Data.SqlDbType.Text, 100);

                    projectNaamParam.Value = projectNaam;
                    plattegrondNaamParam.Value = plattegrondNaam;
                    datumParam.Value = datum;
                    plattegrondcodeParam.Value = plattegrondcode;
                    lengteParam.Value = lengte;
                    breedteParam.Value = breedte;
                    hoogteParam.Value = hoogte;

                    command.Parameters.Add(projectNaamParam);
                    command.Parameters.Add(plattegrondNaamParam);
                    command.Parameters.Add(datumParam);
                    command.Parameters.Add(plattegrondcodeParam);

                    command.Parameters.Add(lengteParam);
                    command.Parameters.Add(breedteParam);

                    command.Parameters.Add(hoogteParam);

                    command.Prepare();
                    command.ExecuteNonQuery();

                }*/
                #endregion
            }
            catch (SqlException e)
            {
                MessageBox.Show("UpdateDatabase " + e.ToString());
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
            #endregion

        }
        public static void UpdateCanvasDataDatabase(string plattegrondcode, string canvasItemcode, string image_name_typeImage, string image_tag_naamMeubel, string image_tag_prijs, string x_coord, string y_coord)
        {
         
            #region update canvasData sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "Inventaris";


                String sql = $"UPDATE canvasItem SET plattegrondcode = '{plattegrondcode}', canvasItemcode = '{canvasItemcode}', imageNameTypeImage = '{image_name_typeImage}', imageTagNaamMeubel = '{image_tag_naamMeubel}', imageTagPrijs  = '{image_tag_prijs}', xcoord= '{x_coord}', ycoord = '{y_coord}' WHERE plattegrondcode LIKE " + $"'{plattegrondcode}'";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");



                    command.ExecuteNonQuery();
                }
                #region old code
                /* using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                 {
                     connection.Open();
                     SqlCommand command = new SqlCommand(null, connection);
                     Console.WriteLine("\nQuery data example:");
                     Console.WriteLine("=========================================\n");


                     command.CommandText = $"UPDATE canvasItem SET plattegrondcode = '@plattegrondcod', canvasItemcode = '@canvasItemcode', imageNameTypeImage = '@imageNameTypeImage', imageTagNaamMeubel = '@imageTagNaamMeubel', imageTagPrijs  = '@imageTagPrijs', xcoord= '@xcoord', ycoord = '@ycoord' WHERE plattegrondcode LIKE " + $"'{plattegrondcode}'";

                     //SqlParameter test = new SqlParameter("", System.Data.SqlDbType.Text, 100);
                     //test.Value = ;
                     //command.Parameters.Add(test);

                     SqlParameter plattegrondcodeParam = new SqlParameter("@plattegrondcod", System.Data.SqlDbType.Text, 100);
                     SqlParameter canvasItemcodeParam = new SqlParameter("@canvasItemcode", System.Data.SqlDbType.Text, 100);
                     SqlParameter imageNameTypeImage = new SqlParameter("@imageNameTypeImage", System.Data.SqlDbType.Text, 100);
                     SqlParameter imageTagNaamMeubel = new SqlParameter("@imageTagNaamMeubel", System.Data.SqlDbType.Text, 100);
                     SqlParameter imageTagPrijs = new SqlParameter("@imageTagPrijs", System.Data.SqlDbType.Text, 100);
                     SqlParameter xcoord = new SqlParameter("@xcoord", System.Data.SqlDbType.Text, 100);
                     SqlParameter ycoord = new SqlParameter("@ycoord", System.Data.SqlDbType.Text, 100);

                     plattegrondcodeParam.Value = plattegrondcode;
                     canvasItemcodeParam.Value = canvasItemcode;
                     imageNameTypeImage.Value = image_name_typeImage;
                     imageTagNaamMeubel.Value = image_tag_naamMeubel;
                     imageTagPrijs.Value = image_tag_prijs;
                     xcoord.Value = x_coord;
                     ycoord.Value = y_coord;

                     command.Parameters.Add(plattegrondcodeParam);
                     command.Parameters.Add(canvasItemcodeParam);
                     command.Parameters.Add(imageNameTypeImage);
                     command.Parameters.Add(imageTagNaamMeubel);
                     command.Parameters.Add(imageTagPrijs);
                     command.Parameters.Add(xcoord);
                     command.Parameters.Add(ycoord);

                     command.Prepare();
                     command.ExecuteNonQuery();

                 }*/
                #endregion
            }
            catch (SqlException e)
            {
                MessageBox.Show("UpdateCanvasDataDatabase " + e.ToString());
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
            #endregion
        }
        public static string GetCanvasItemcodeDatabase(string canvasitemcode)
        {

            string output = "leeg";
            #region plattegrond sql
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

                    String sql = "SELECT canvasItemcode FROM canvasItem WHERE canvasItemcode = " + $"'{canvasitemcode}'";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                output = reader.GetString(0);

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

    }

}
