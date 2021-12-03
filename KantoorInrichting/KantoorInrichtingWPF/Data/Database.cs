using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace KantoorInrichtingWPF.Data
{
  public  class Database
    {
       private static Dictionary<int, List<string>> nepDatabase = new Dictionary<int, List<string>>();

        public static bool isGevuld = false;

        public Database() 
        {
           
        }

        public static void FillDatabase()
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
            /*
           1 tafel |¯¯|
           2 stoel 🦽 
           3 lamp 💡
           4 kast 🗄
           5 plant 🌲
           6 apparaten 🖥
           7 deur 🚪
           8 raam ⬜
           9 tapijt 🔴
            */
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
        }
        public static void TestSql() 
        {
            try
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
            Console.ReadLine(); 
        }
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
                item.Value[0] = GetImage(item.Value[5]);
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
        public static void DeleteFromDatabase(string naam) 
        {
            #region test sql
            /*try
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
            foreach (var item in nepDatabase)
            {

                bool contains = LikeOperator.LikeString(item.Value[1], $"{naam}", Microsoft.VisualBasic.CompareMethod.Binary);
                if (contains == true)
                {
                    nepDatabase.Remove(item.Key);
                }



            }
        }
       public static void ToevoegenAanDatabase(string naam, string prijs,string lengte, string breedte,string categorie, string tag, string image, string hoogte) 
        {
            
            /*List<string> list= new List<string>();
            list.Add(image);
            list.Add(naam);//1
            list.Add(prijs);//2
            list.Add(lengte);//3
            list.Add(breedte);//4
            list.Add(tag);//5
            list.Add(" "+categorie);//6
            list.Add(hoogte);*/
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
                    command.CommandText = $"INSERT INTO Inventaris VALUES (@img, @name, @prijs, @lengte, @breedte, @tag, @categorie, @hoogte) ";

                    SqlParameter imgParam = new SqlParameter("@img", System.Data.SqlDbType.Text,100);
                    SqlParameter nameParam = new SqlParameter("@name", System.Data.SqlDbType.Text, 100);
                    SqlParameter prijsParam = new SqlParameter("@prijs", System.Data.SqlDbType.Text, 100);
                    SqlParameter lengteParam = new SqlParameter("@lengte", System.Data.SqlDbType.Text, 100);
                    SqlParameter breedteParam = new SqlParameter("@breedte", System.Data.SqlDbType.Text, 100);
                    SqlParameter tagParam = new SqlParameter("@tag", System.Data.SqlDbType.Text, 100);
                    SqlParameter categorieParam = new SqlParameter("@categorie", System.Data.SqlDbType.Text, 100);
                    SqlParameter hoogteParam = new SqlParameter("@hoogte", System.Data.SqlDbType.Text, 100);

                    imgParam.Value = image;
                    nameParam.Value = naam;
                    prijsParam.Value = prijs;
                    lengteParam.Value = lengte;
                    breedteParam.Value = breedte;
                    tagParam.Value = tag;
                    categorieParam.Value = categorie;
                    hoogteParam.Value = hoogte;

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
            /*if (nepDatabase.Count==0)
            {
                nepDatabase.Add(nepDatabase.Count, list);
            }
            if (!nepDatabase.ContainsKey(nepDatabase.Count))
            {
                nepDatabase.Add(nepDatabase.Count, list);
            }
            else
            {
                nepDatabase.Add(nepDatabase.Count + 1, list);
            }*/

        }
        public static Dictionary<int, List<string>> ZoekenDatabase(string zoekbalk) 
        {

            Dictionary<int, List<string>> outputQurrey = new Dictionary<int, List<string>>();
            int count = 0;
            #region test sql
            /*try
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
            foreach (var item in nepDatabase)
            {
              
                    bool contains = LikeOperator.LikeString(item.Value[1], $"*{zoekbalk}*", Microsoft.VisualBasic.CompareMethod.Binary);
                    if (contains == true)
                    {
                        outputQurrey.Add(count, item.Value);
                        count++;
                    }
                
               

            }
            
            
            return outputQurrey;

        }

        public static Dictionary<int, List<string>> ZoekenDatabseCategorie(string zoekbalk)
        {
            Dictionary<int, List<string>> outputQurrey = new Dictionary<int, List<string>>();
            int count = 0;
            #region test sql
            /*try
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
            foreach (var item in nepDatabase)
            {

                bool contains = LikeOperator.LikeString(item.Value[6], $"*{zoekbalk}*", Microsoft.VisualBasic.CompareMethod.Binary);
                if (contains == true)
                {
                    outputQurrey.Add(count, item.Value);
                    count++;
                }



            }


            return outputQurrey;
        }
    }
}
