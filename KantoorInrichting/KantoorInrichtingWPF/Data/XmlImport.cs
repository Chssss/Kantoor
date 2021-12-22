using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Xml;
using System.Configuration;
using System.IO;
using System.Xml.Serialization;

namespace KantoorInrichtingWPF.Data
{
    public class XmlImport
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();

            xDoc.Load("test.xml");
            XmlNodeList name = xDoc.GetElementsByTagName("productcode");
            Console.ReadLine("Name: " + name[0].InnerText);
        }
    }
}



//         public Meubel_Database() 
//         {
           
//         }
//         #region nepDatabase

      
//         #endregion
//         #region TestSql 

//         /* try
//          {
//              SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
//              builder.DataSource = "<your_server>.database.windows.net";
//              builder.UserID = "<your_username>";
//              builder.Password = "<your_password>";
//              builder.InitialCatalog = "<your_database>";

//              using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
//              {
//                  Console.WriteLine("\nQuery data example:");
//                  Console.WriteLine("=========================================\n");

//                  String sql = "SELECT name, collation_name FROM sys.databases";

//                  using (SqlCommand command = new SqlCommand(sql, connection))
//                  {
//                      connection.Open();
//                      using (SqlDataReader reader = command.ExecuteReader())
//                      {
//                          while (reader.Read())
//                          {
//                              Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
//                          }
//                      }
//                  }
//              }
//          }
//          catch (SqlException e)
//          {
//              Console.WriteLine(e.ToString());
//          }
//          Console.ReadLine();*/
//         #endregion
     
//         public static Dictionary<int,List<string>> GetDatabase() 
//         {
//             Dictionary<int, List<string>> output = new Dictionary<int, List<string>>();
//             int count = 0;
//             #region test sql
//             try
//             {
//                 SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
//                 builder.DataSource = "127.0.0.1, 1433";
//                 builder.UserID = "sa";
//                 builder.Password = "Kantoorinrichting!";
//                 builder.InitialCatalog = "Inventaris";

//                 using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
//                 {
//                     Console.WriteLine("\nQuery data example:");
//                     Console.WriteLine("=========================================\n");

//                     String sql = "SELECT * FROM Inventaris ";

//                     using (SqlCommand command = new SqlCommand(sql, connection))
//                     {
//                         connection.Open();
//                         using (SqlDataReader reader = command.ExecuteReader())
//                         {

//                             while (reader.Read())
//                             {
//                                 List<string> listVaule = new List<string>();
//                                 listVaule.Add(reader.GetString(0));
//                                 listVaule.Add(reader.GetString(1));
//                                 listVaule.Add(reader.GetString(2));
//                                 listVaule.Add(reader.GetString(3));
//                                 listVaule.Add(reader.GetString(4));
//                                 listVaule.Add(reader.GetString(5));
//                                 listVaule.Add(reader.GetString(6));
//                                 listVaule.Add(reader.GetString(7));
//                                 output.Add(count, listVaule);
//                                 count++;
//                             }
//                         }
//                     }
//                 }
//             }
//             catch (SqlException e)
//             {
//                 Console.WriteLine(e.ToString());
//             }
//             Console.ReadLine();
//             #endregion
//             foreach (var item in output)
//             {
//                 item.Value[0] = GetImage(item.Value[5]);
//             }
//             return output;

//         }
//         private static string GetImage(string tag)
//         {
//             string image = "";
//             if (tag.Equals("stoel"))
//             {
//                 image = "🦼";
//             }
//             if (tag.Equals("tafel"))
//             {
//                 image = "|¯¯|";
//             }
//             if (tag.Equals("lamp"))
//             {
//                 image = "💡";
//             }
//             if (tag.Equals("kast"))
//             {
//                 image = "🗄";
//             }
//             if (tag.Equals("plant"))
//             {
//                 image = "🌲";
//             }
//             if (tag.Equals("apparaten"))
//             {
//                 image = "🖥";
//             }
//             if (tag.Equals("deur"))
//             {
//                 image = "🚪";
//             }
//             if (tag.Equals("raam"))
//             {
//                 image = "⬜";
//             }
//             if (tag.Equals("tapijt"))
//             {
//                 image = "🔴";
//             }
//             return image;
//         }
        
//        public static void ToevoegenAanDatabase(string naam, string prijs,string lengte, string breedte,string categorie, string tag, string image, string hoogte) 
//         {
            
           
//             #region test sql
//             try
//             {
//                 SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
//                 builder.DataSource = "127.0.0.1, 1433";
//                 builder.UserID = "sa";
//                 builder.Password = "Kantoorinrichting!";
//                 builder.InitialCatalog = "Inventaris";
                
//                 using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
//                 {
//                     connection.Open();
//                     SqlCommand command = new SqlCommand(null, connection);
//                     Console.WriteLine("\nQuery data example:");
//                     Console.WriteLine("=========================================\n");

//                     command.CommandText = $"INSERT INTO InventarisTest VALUES (@img, @name, @prijs, @lengte, @breedte, @tag, @categorie, @hoogte) ";

//                     SqlParameter imgParam = new SqlParameter("@img", System.Data.SqlDbType.Text,100);
//                     SqlParameter nameParam = new SqlParameter("@name", System.Data.SqlDbType.Text, 100);
//                     SqlParameter prijsParam = new SqlParameter("@prijs", System.Data.SqlDbType.Text, 100);
//                     SqlParameter lengteParam = new SqlParameter("@lengte", System.Data.SqlDbType.Text, 100);
//                     SqlParameter breedteParam = new SqlParameter("@breedte", System.Data.SqlDbType.Text, 100);
//                     SqlParameter tagParam = new SqlParameter("@tag", System.Data.SqlDbType.Text, 100);
//                     SqlParameter categorieParam = new SqlParameter("@categorie", System.Data.SqlDbType.Text, 100);
//                     SqlParameter hoogteParam = new SqlParameter("@hoogte", System.Data.SqlDbType.Text, 100);

//                     imgParam.Value = image;
//                     nameParam.Value = naam;
//                     prijsParam.Value = prijs;
//                     lengteParam.Value = lengte;
//                     breedteParam.Value = breedte;
//                     tagParam.Value = tag;
//                     categorieParam.Value = categorie;
//                     hoogteParam.Value = hoogte;

//                     command.Parameters.Add(imgParam);
//                     command.Parameters.Add(nameParam);
//                     command.Parameters.Add(prijsParam);
//                     command.Parameters.Add(lengteParam);
//                     command.Parameters.Add(breedteParam);
//                     command.Parameters.Add(tagParam);
//                     command.Parameters.Add(categorieParam);
//                     command.Parameters.Add(hoogteParam);

//                     command.Prepare();
//                     command.ExecuteNonQuery();
                   
//                 }
//             }
//             catch (SqlException e)
//             {
//                 Console.WriteLine(e.ToString());
//             }
//             Console.ReadLine();
//             #endregion
           

//         }
//     }
// }
