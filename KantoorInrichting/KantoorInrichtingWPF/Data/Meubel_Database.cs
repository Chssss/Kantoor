using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace KantoorInrichtingWPF.Data
{
  public  class Meubel_Database
    {
       

       
        #region nepDatabase

      /*  public static void FillDatabase()
        {

            isGevuld = true;
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            List<string> list4 = new List<string>();
            List<string> list5 = new List<string>();
            List<string> list6 = new List<string>();
            List<string> list7 = new List<string>();
            List<string> list8 = new List<string>();
            List<string> list9 = new List<string>();
            //list.Add(@"afbeeldingen\stoel.jpg");//0
            *//*
           1 tafel |¯¯|
           2 stoel 🦽 
           3 lamp 💡
           4 kast 🗄
           5 plant 🌲
           6 apparaten 🖥
           7 deur 🚪
           8 raam ⬜
           9 tapijt 🔴
            *//*
            list1.Add("🦼");
            list1.Add("naam");//1
            list1.Add("5,8");//2
            list1.Add("10,6");//3
            list1.Add("8,9");//4
            list1.Add("stoel");//5
            list1.Add("categorie");//6
            list1.Add("2,5");
            nepDatabase.Add(0, list1);
            list2.Add("|¯¯|");
            list2.Add("naam");//1
            list2.Add("5,8");//2
            list2.Add("10,6");//3
            list2.Add("8,9");//4
            list2.Add("tafel");//5
            list2.Add("categorie");//6
            list2.Add("2,5");
            nepDatabase.Add(1, list2);
            list3.Add("💡");
            list3.Add("naam");//1
            list3.Add("5,8");//2
            list3.Add("10,6");//3
            list3.Add("8,9");//4
            list3.Add("lamp");//5
            list3.Add("categorie");//6
            list3.Add("2,5");
            nepDatabase.Add(2, list3);
            list4.Add("🗄");
            list4.Add("naam");//1
            list4.Add("5,8");//2
            list4.Add("10,6");//3
            list4.Add("8,9");//4
            list4.Add("kast");//5
            list4.Add("categorie");//6
            list4.Add("2,5");
            nepDatabase.Add(3, list4);
            list5.Add("🌲");
            list5.Add("naam");//1
            list5.Add("5,8");//2
            list5.Add("10,6");//3
            list5.Add("8,9");//4
            list5.Add("plant");//5
            list5.Add("categorie");//6
            list5.Add("2,5");
            nepDatabase.Add(4, list5);
            list6.Add("🖥");
            list6.Add("naam");//1
            list6.Add("5,8");//2
            list6.Add("10,6");//3
            list6.Add("8,9");//4
            list6.Add("apparaten");//5
            list6.Add("categorie");//6
            list6.Add("2,5");
            nepDatabase.Add(5, list6);
            list7.Add("🚪");
            list7.Add("naam");//1
            list7.Add("5,8");//2
            list7.Add("10,6");//3
            list7.Add("8,9");//4
            list7.Add("deur");//5
            list7.Add("categorie");//6
            list7.Add("2,5");
            nepDatabase.Add(6, list7);
            list8.Add("⬜");
            list8.Add("naam");//1
            list8.Add("5,8");//2
            list8.Add("10,6");//3
            list8.Add("8,9");//4
            list8.Add("raam");//5
            list8.Add("categorie");//6
            list8.Add("2,5");
            nepDatabase.Add(7, list8);
            list9.Add("🔴");
            list9.Add("naam");//1
            list9.Add("5,8");//2
            list9.Add("10,6");//3
            list9.Add("8,9");//4
            list9.Add("tapijt");//5
            list9.Add("categorie");//6
            list9.Add("2,5");
            nepDatabase.Add(8, list9);
        }*/
        #endregion
        #region TestSql 

        /* try
         {
             SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
             builder.DataSource = "<your_server>.database.windows.net";
             builder.UserID = "<your_username>";
             builder.Password = "<your_password>";
             builder.InitialCatalog = "<your_database>";

             using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
             {
                 Console.WriteLine("\nQuery data example:");
                 Console.WriteLine("=========================================\n");

                 String sql = "SELECT name, collation_name FROM sys.databases";

                 using (SqlCommand command = new SqlCommand(sql, connection))
                 {
                     connection.Open();
                     using (SqlDataReader reader = command.ExecuteReader())
                     {
                         while (reader.Read())
                         {
                             Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                         }
                     }
                 }
             }
         }
         catch (SqlException e)
         {
             Console.WriteLine(e.ToString());
         }
         Console.ReadLine();*/
        #endregion
        public static Dictionary<int,List<string>> GetDatabase() 
        {
            Dictionary<int, List<string>> output = new Dictionary<int, List<string>>();
            int count = 0;
            #region test sql
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

                    String sql = "SELECT * FROM Inventaris ";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                List<string> listVaule = new List<string>();
                                listVaule.Add(reader.GetString(0));
                                listVaule.Add(reader.GetString(1));
                                listVaule.Add(reader.GetString(2));
                                listVaule.Add(reader.GetString(3));
                                listVaule.Add(reader.GetString(4));
                                listVaule.Add(reader.GetString(5));
                                listVaule.Add(reader.GetString(6));
                                listVaule.Add(reader.GetString(7));
                                listVaule.Add(reader.GetString(8));
                                listVaule.Add(reader.GetString(9));
                                output.Add(count, listVaule);
                                count++;
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
            foreach (var item in output)
            {
                item.Value[2] = GetImage(item.Value[7].ToLower());
            }
            return output;
            //return nepDatabase;
        }
        private static string GetImage(string tag)
        {
            string image = "";
            if (tag.Equals("stoel"))
            {
                image = "🦼";
            }
            if (tag.Equals("tafel"))
            {
                image = "|¯¯|";
            }
            if (tag.Equals("lamp"))
            {
                image = "💡";
            }
            if (tag.Equals("kast"))
            {
                image = "🗄";
            }
            if (tag.Equals("plant"))
            {
                image = "🌲";
            }
            if (tag.Equals("apparaten"))
            {
                image = "🖥";
            }
            if (tag.Equals("deur"))
            {
                image = "🚪";
            }
            if (tag.Equals("raam"))
            {
                image = "⬜";
            }
            if (tag.Equals("tapijt"))
            {
                image = "🔴";
            }
            return image;
        }
        public static void DeleteFromDatabase(string productcode) 
        {
            #region test sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "Inventaris";

                String sql = $"DELETE FROM Inventaris WHERE productcode ="+ $"'{productcode}'";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                   
                     //command.CommandText = $"DELETE FROM Inventaris WHERE productcode =@productcode";
                    //SqlParameter nameParam = new SqlParameter("@productcode", System.Data.SqlDbType.Text, 100);
                    //nameParam.Value = naam;
                    //command.Parameters.Add(nameParam);
                    //command.Prepare();
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
       public static void ToevoegenAanDatabase(string naam, string prijs,string lengte, string breedte,string categorie, string tag, string image, string hoogte, string leverancier, string productCode)
        {
            
       
            #region test sql
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

                    //String sql = $"INSERT INTO Inventaris VALUES (@img, @name, @prijs, @lengte, @breedte, @tag, @categorie, @hoogte) ";//INSERT INTO Inventaris VALUES ('🌲', 'test2', '1,1', '1,1', '1,1', 'stoel', 'testcategorie', '1,1')    

                    //SqlCommand command = new SqlCommand(sql, connection);    
                    //{image}, {naam}, {prijs}, {lengte}, {breedte}, {tag}, {categorie}, {hoogte}
                    command.CommandText = $"INSERT INTO Inventaris VALUES (@productcode, @leverancier, @img, @name, @prijs, @lengte, @breedte, @tag, @categorie, @hoogte) ";

                    SqlParameter productcodeParam = new SqlParameter("@productcode", System.Data.SqlDbType.Text, 100);
                    SqlParameter leverancierParam = new SqlParameter("@leverancier", System.Data.SqlDbType.Text, 100);
                    SqlParameter imgParam = new SqlParameter("@img", System.Data.SqlDbType.Text,100);
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
        public static Dictionary<int, List<string>> ZoekenDatabase(string zoekbalk) 
        {

            Dictionary<int, List<string>> outputQurrey = new Dictionary<int, List<string>>();
            int count = 0;
        
           
            #region test sql
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

                    String sql = "SELECT * FROM Inventaris WHERE naam LIKE " + $"'%{zoekbalk}%'";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                       

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                List<string> listVaule = new List<string>();
                                listVaule.Add(reader.GetString(0));
                                listVaule.Add(reader.GetString(1));
                                listVaule.Add(reader.GetString(2));
                                listVaule.Add(reader.GetString(3));
                                listVaule.Add(reader.GetString(4));
                                listVaule.Add(reader.GetString(5));
                                listVaule.Add(reader.GetString(6));
                                listVaule.Add(reader.GetString(7));
                                listVaule.Add(reader.GetString(8));
                                listVaule.Add(reader.GetString(9));
                                outputQurrey.Add(count, listVaule);
                                count++;
                            }
                        }
                    }
                    //String sql = "SELECT * FROM Inventaris WHERE naam LIKE '*@name*' ";
                  /*  connection.Open();
                  SqlCommand command = new SqlCommand(null, connection);
                  command.CommandText = "SELECT * FROM Inventaris WHERE naam LIKE '*@name*' ";
                    SqlParameter nameParam = new SqlParameter("@name", System.Data.SqlDbType.Text, 100);
                    nameParam.Value = zoekbalk;
                    command.Parameters.Add(nameParam);
                    command.Prepare();
                    command.ExecuteNonQuery();*/
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
            #endregion
            foreach (var item in outputQurrey)
            {
                item.Value[2] = GetImage(item.Value[7].ToLower());
            }
            return outputQurrey;
           


        }

        public static Dictionary<int, List<string>> ZoekenDatabseCategorie(string zoekbalk)
        {
            Dictionary<int, List<string>> outputQurrey = new Dictionary<int, List<string>>();
            int count = 0;
            #region test sql
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

                     String sql = "SELECT * FROM Inventaris WHERE categorie LIKE " + $"'%{zoekbalk}%'";
                    //String sql = "SELECT * FROM Inventaris WHERE Categorie LIKE "+ $" '%{zoekbalk}%' ";//+ $"'%{zoekbalk}%'"
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                List<string> listVaule = new List<string>();
                                listVaule.Add(reader.GetString(0));
                                listVaule.Add(reader.GetString(1));
                                listVaule.Add(reader.GetString(2));
                                listVaule.Add(reader.GetString(3));
                                listVaule.Add(reader.GetString(4));
                                listVaule.Add(reader.GetString(5));
                                listVaule.Add(reader.GetString(6));
                                listVaule.Add(reader.GetString(7));
                                listVaule.Add(reader.GetString(8));
                                listVaule.Add(reader.GetString(9));
                                outputQurrey.Add(count, listVaule);
                                count++;
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
            foreach (var item in outputQurrey)
            {
                item.Value[2] = GetImage(item.Value[7].ToLower());
            }


            return outputQurrey;
        }
        public static int UpdateCheck(string productcode)
        {
            #region test sql
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "127.0.0.1, 1433";
                builder.UserID = "sa";
                builder.Password = "Kantoorinrichting!";
                builder.InitialCatalog = "Inventaris";
                String sql = $"SELECT COUNT(*) FROM Inventaris WHERE productcode =" + $"'{productcode}'";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    int rowsAffected = (int)command.ExecuteScalar();
                    return rowsAffected;
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            return 0;
            //Console.ReadLine();
            #endregion
        }
        public static void UpdateDatabase(string naam, string prijs, string lengte, string breedte, string categorie, string tag, string image, string hoogte, string leverancier, string productCode)
        {


            #region test sql
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

                    //String sql = $"INSERT INTO Inventaris VALUES (@img, @name, @prijs, @lengte, @breedte, @tag, @categorie, @hoogte) ";//INSERT INTO Inventaris VALUES ('🌲', 'test2', '1,1', '1,1', '1,1', 'stoel', 'testcategorie', '1,1')    

                    //SqlCommand command = new SqlCommand(sql, connection);    
                    //{image}, {naam}, {prijs}, {lengte}, {breedte}, {tag}, {categorie}, {hoogte}
                    command.CommandText = $"UPDATE Inventaris SET productcode = " + $"'{productCode}',leverancier = " + $"'{leverancier}',img = " + $"'{image}',naam = " + $"'{naam}',prijs = " + $"'{prijs}',lengte = " + $"'{lengte}',breedte = " + $"'{breedte}',tag = " + $"'{tag}',categorie = " + $"'{categorie}',hoogte = " + $"'{hoogte}' WHERE productcode =" + $"'{productCode}'";

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

                    command.Prepare();
                    command.ExecuteNonQuery();

                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            //Console.ReadLine();
            #endregion


        }
    }
}
