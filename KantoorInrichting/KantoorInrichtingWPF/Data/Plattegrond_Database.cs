using KantoorInrichtingWPF.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows;

namespace KantoorInrichtingWPF.Data
{
   public class Plattegrond_Database
    {
        public static List<string> GetPlattegrondcode(string projectnaam) 
        {
            List<string> output = new List<string>();

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

                    String sql = "SELECT plattegrondcode FROM plattegrond WHERE projectnaam = " + $"'{projectnaam}'";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                
                                output.Add(reader.GetString(0));//project naam
                                
                               
                                
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
        }
        public static List<Plattegrond> GetPlattegrondDataDatabase()
        {
            List<Plattegrond> outputPlategrondSQL = new List<Plattegrond>(); 
           
            
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
                                /*   
                                listVaule.Add(reader.GetString(0));//project naam
                                listVaule.Add(reader.GetString(1));//plattegrond naam
                                listVaule.Add(reader.GetString(2));//datum
                                listVaule.Add(reader.GetString(3));//plattegrondcode
                                listVaule.Add(reader.GetString(4));//lengte
                                listVaule.Add(reader.GetString(5));//breedte
                                listVaule.Add(reader.GetString(6));//hoogte
                                */
                                var projectNaam =reader.GetString(0);//project naam
                                var plattegrondNaam=reader.GetString(1);//plattegrond naam
                                var datum=reader.GetString(2);//datum
                                var plattegrondcode=reader.GetString(3);//plattegrondcode
                                var lengte=reader.GetDecimal(4);//lengte
                                var breedte=reader.GetDecimal(5);//breedte
                                var hoogte=reader.GetDecimal(6);//hoogte

                                /*
                                listVaule.Add(reader.GetString(7));//image type(type image)
                                listVaule.Add(reader.GetString(8));//image name(naam meubel)
                                listVaule.Add(reader.GetString(9));//image tag(prijs)
                                listVaule.Add(reader.GetString(10));//x coord
                                listVaule.Add(reader.GetString(11));//y coord
                                */
                                var canvasItems = GetPlattegrondCanvasDataDatabase(plattegrondcode);
                                Plattegrond plattegrond = new Plattegrond(projectNaam,plattegrondNaam,datum,plattegrondcode,lengte,breedte,hoogte,canvasItems);
                                outputPlategrondSQL.Add(plattegrond);
                                
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
        public static List<CanvasItem> GetPlattegrondCanvasDataDatabase(string plattegrondcode)
        {
            List<CanvasItem> outputCanvasSQL = new List<CanvasItem>();

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
                                
                                var canvasItemcode=reader.GetString(0);//canvasItemcode
                                var Plattegrondcode=reader.GetString(1);//plattegrondcode
                                var imageType= reader.GetString(2);//image type(type image)
                                var naamMeubel=reader.GetString(3);//image name(naam meubel)
                                var prijs=reader.GetDecimal(4);//image tag(prijs)
                                var xcoord=reader.GetString(5);//x coord
                                var ycoord=reader.GetString(6);//y coord
                                var leverancier=reader.GetString(7);//leverancier
                                var productcode=reader.GetString(8);//productcode
                                var rotatie=reader.GetInt32(9);//rotatie
                                CanvasItem canvasItem = new CanvasItem(canvasItemcode,Plattegrondcode,imageType,naamMeubel,prijs,xcoord,ycoord,leverancier,productcode,rotatie);
                                outputCanvasSQL.Add(canvasItem);
                               
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
        public static void ToevoegenAanDatabase(string projectNaam, string plattegrondNaam,string datum, string plattegrondcode,decimal lengte,decimal breedte, decimal hoogte)
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

                    SqlParameter lengteParam = new SqlParameter("@lengte", System.Data.SqlDbType.Decimal, 100);
                    SqlParameter breedteParam = new SqlParameter("@breedte", System.Data.SqlDbType.Decimal, 100);
                    SqlParameter hoogteParam = new SqlParameter("@hoogte", System.Data.SqlDbType.Decimal, 100);

                    projectNaamParam.Value = projectNaam;
                    plattegrondNaamParam.Value = plattegrondNaam;
                    datumParam.Value = datum;
                    plattegrondcodeParam.Value = plattegrondcode;
                    lengteParam.Value = lengte;
                    lengteParam.Precision = 4;
                    lengteParam.Scale = 2;
                    breedteParam.Value = breedte;
                    breedteParam.Precision = 4;
                    breedteParam.Scale = 2;
                    hoogteParam.Value = hoogte;
                    hoogteParam.Precision = 4;
                    hoogteParam.Scale = 2;

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
               // MessageBox.Show("ToevoegenAanDatabase " + e.ToString());
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
            #endregion

        }
        public static void ToevoegenCanvasDataAanDatabase(string plattegrondcode, string canvasItemcode, string image_name_typeImage, string image_tag_naamMeubel, decimal image_tag_prijs, string x_coord, string y_coord, string image_tag_leverancier, string image_tag_productcode, int image_tag_rotatie)
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


                    command.CommandText = $"INSERT INTO canvasItem VALUES (@plattegrondcode, @canvasItemcode, @imageNameTypeImage, @imageTagNaamMeubel, @imageTagPrijs, @xcoord, @ycoord, @leverancier, @productcode,@rotatie) ";

                    //SqlParameter test = new SqlParameter("", System.Data.SqlDbType.Text, 100);
                    //test.Value = ;
                    //command.Parameters.Add(test);

                    SqlParameter plattegrondcodeParam = new SqlParameter("@plattegrondcode", System.Data.SqlDbType.Text, 100);
                    SqlParameter canvasItemcodeParam = new SqlParameter("@canvasItemcode", System.Data.SqlDbType.Text, 100);
                    SqlParameter imageNameTypeImage = new SqlParameter("@imageNameTypeImage", System.Data.SqlDbType.Text, 100);
                    SqlParameter imageTagNaamMeubel = new SqlParameter("@imageTagNaamMeubel", System.Data.SqlDbType.Text, 100);
                    SqlParameter imageTagPrijs = new SqlParameter("@imageTagPrijs", System.Data.SqlDbType.Decimal, 100);
                    SqlParameter xcoord = new SqlParameter("@xcoord", System.Data.SqlDbType.Text, 100);
                    SqlParameter ycoord = new SqlParameter("@ycoord", System.Data.SqlDbType.Text, 100);
                    SqlParameter leverancier = new SqlParameter("@leverancier", System.Data.SqlDbType.Text, 100);
                    SqlParameter productcode = new SqlParameter("@productcode", System.Data.SqlDbType.Text, 100);
                    SqlParameter rotatie = new SqlParameter("@rotatie", System.Data.SqlDbType.Int, 100);

                    plattegrondcodeParam.Value = plattegrondcode;
                    canvasItemcodeParam.Value = canvasItemcode;
                    imageNameTypeImage.Value = image_name_typeImage;
                    imageTagNaamMeubel.Value = image_tag_naamMeubel;
                    imageTagPrijs.Value = image_tag_prijs;
                    imageTagPrijs.Precision = 10;
                    imageTagPrijs.Scale = 2;
                    xcoord.Value = x_coord;
                    ycoord.Value = y_coord;
                    leverancier.Value = image_tag_leverancier;
                    productcode.Value = image_tag_productcode;
                    rotatie.Value = image_tag_rotatie;
                   

                    command.Parameters.Add(plattegrondcodeParam);
                    command.Parameters.Add(canvasItemcodeParam);
                    command.Parameters.Add(imageNameTypeImage);
                    command.Parameters.Add(imageTagNaamMeubel);
                    command.Parameters.Add(imageTagPrijs);
                    command.Parameters.Add(xcoord);
                    command.Parameters.Add(ycoord);
                    command.Parameters.Add(leverancier);
                    command.Parameters.Add(productcode);
                    command.Parameters.Add(rotatie);

                    command.Prepare();
                    command.ExecuteNonQuery();

                }
            }
            catch (SqlException e)
            {
                //MessageBox.Show("ToevoegenCanvasDataAanDatabase " + e.ToString());
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
            #endregion
        }
        public static List<Plattegrond> ZoekenNaamPlattegrondDatabase(string zoekbalk) 
        {
            List<Plattegrond> outputPlategrondSQL = new List<Plattegrond>();

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
                                /*   
                                listVaule.Add(reader.GetString(0));//project naam
                                listVaule.Add(reader.GetString(1));//plattegrond naam
                                listVaule.Add(reader.GetString(2));//datum
                                listVaule.Add(reader.GetString(3));//plattegrondcode
                                listVaule.Add(reader.GetString(4));//lengte
                                listVaule.Add(reader.GetString(5));//breedte
                                listVaule.Add(reader.GetString(6));//hoogte
                                */
                                var projectNaam = reader.GetString(0);//project naam
                                var plattegrondNaam = reader.GetString(1);//plattegrond naam
                                var datum = reader.GetString(2);//datum
                                var plattegrondcode = reader.GetString(3);//plattegrondcode
                                var lengte = reader.GetDecimal(4);//lengte
                                var breedte = reader.GetDecimal(5);//breedte
                                var hoogte = reader.GetDecimal(6);//hoogte

                                /*
                                listVaule.Add(reader.GetString(7));//image type(type image)
                                listVaule.Add(reader.GetString(8));//image name(naam meubel)
                                listVaule.Add(reader.GetString(9));//image tag(prijs)
                                listVaule.Add(reader.GetString(10));//x coord
                                listVaule.Add(reader.GetString(11));//y coord
                                */
                                var canvasItems = GetPlattegrondCanvasDataDatabase(plattegrondcode);
                                Plattegrond plattegrond = new Plattegrond(projectNaam, plattegrondNaam, datum, plattegrondcode, lengte, breedte, hoogte, canvasItems);
                                outputPlategrondSQL.Add(plattegrond);
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
        public static List<Plattegrond> ZoekenNaamProjectDatabase(string zoekbalk)
        {
            List<Plattegrond> outputPlategrondSQL = new List<Plattegrond>();

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
                                /*   
                                 listVaule.Add(reader.GetString(0));//project naam
                                 listVaule.Add(reader.GetString(1));//plattegrond naam
                                 listVaule.Add(reader.GetString(2));//datum
                                 listVaule.Add(reader.GetString(3));//plattegrondcode
                                 listVaule.Add(reader.GetString(4));//lengte
                                 listVaule.Add(reader.GetString(5));//breedte
                                 listVaule.Add(reader.GetString(6));//hoogte
                                 */
                                var projectNaam = reader.GetString(0);//project naam
                                var plattegrondNaam = reader.GetString(1);//plattegrond naam
                                var datum = reader.GetString(2);//datum
                                var plattegrondcode = reader.GetString(3);//plattegrondcode
                                var lengte = reader.GetDecimal(4);//lengte
                                var breedte = reader.GetDecimal(5);//breedte
                                var hoogte = reader.GetDecimal(6);//hoogte

                                /*
                                listVaule.Add(reader.GetString(7));//image type(type image)
                                listVaule.Add(reader.GetString(8));//image name(naam meubel)
                                listVaule.Add(reader.GetString(9));//image tag(prijs)
                                listVaule.Add(reader.GetString(10));//x coord
                                listVaule.Add(reader.GetString(11));//y coord
                                */
                                var canvasItems = GetPlattegrondCanvasDataDatabase(plattegrondcode);
                                Plattegrond plattegrond = new Plattegrond(projectNaam, plattegrondNaam, datum, plattegrondcode, lengte, breedte, hoogte, canvasItems);
                                outputPlategrondSQL.Add(plattegrond);
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
        public static void UpdateDatabase(string projectNaam, string plattegrondNaam, string datum, string plattegrondcode, decimal lengte, decimal breedte, decimal hoogte)
        {
           

            #region update plattegrondData sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "Inventaris";
                
                
                string lengteText = $"{lengte}";
                string breedteText = $"{breedte}";
                string hoogteText = $"{hoogte}";
               
                string TextCorrectLengte = lengteText.Replace(',', '.');
                string TextCorrectBreedte = breedteText.Replace(',', '.');
                string TextCorrectHoogte = hoogteText.Replace(',', '.');

                String sql = $"UPDATE plattegrond SET projectnaam = '{projectNaam}', plattegrondnaam = '{plattegrondNaam}', datum = '{datum}', plattegrondcode = '{plattegrondcode}', lengte = '{TextCorrectLengte}', breedte = '{TextCorrectBreedte}', hoogte = '{TextCorrectHoogte}' WHERE plattegrondcode LIKE " + $"'{plattegrondcode}'";

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
                //MessageBox.Show("UpdateDatabase " + e.ToString());
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
            #endregion

        }
        public static void UpdateCanvasDataDatabase(string plattegrondcode, string canvasItemcode, string image_name_typeImage, string image_tag_naamMeubel, decimal image_tag_prijs, string x_coord, string y_coord,string image_tag_leverancier, string image_tag_productcode)
        {
         
            #region update canvasData sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "Inventaris";
                string prijsText = $"{image_tag_prijs}";
                
                string TextCorrectPrijs = prijsText.Replace(',', '.');
                

                String sql = $"UPDATE canvasItem SET plattegrondcode = '{plattegrondcode}', canvasItemcode = '{canvasItemcode}', imageNameTypeImage = '{image_name_typeImage}', imageTagNaamMeubel = '{image_tag_naamMeubel}', imageTagPrijs  = '{TextCorrectPrijs}', xcoord= '{x_coord}', ycoord = '{y_coord}', leverancier = '{image_tag_leverancier}', productcode = '{image_tag_productcode}' WHERE plattegrondcode LIKE " + $"'{plattegrondcode}'";

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
                //MessageBox.Show("UpdateCanvasDataDatabase " + e.ToString());
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
