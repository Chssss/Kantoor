using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
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
            nepDatabase.Add(0, list1);
            list2.Add("|¯¯|");
            list2.Add("naam");//1
            list2.Add("5,8");//2
            list2.Add("10,6");//3
            list2.Add("8,9");//4
            list2.Add("tafel");//5
            list2.Add("categorie");//6
            nepDatabase.Add(1, list2);
            list3.Add("💡");
            list3.Add("naam");//1
            list3.Add("5,8");//2
            list3.Add("10,6");//3
            list3.Add("8,9");//4
            list3.Add("lamp");//5
            list3.Add("categorie");//6
            nepDatabase.Add(2, list3);
            list4.Add("🗄");
            list4.Add("naam");//1
            list4.Add("5,8");//2
            list4.Add("10,6");//3
            list4.Add("8,9");//4
            list4.Add("kast");//5
            list4.Add("categorie");//6
            nepDatabase.Add(3, list4);
            list5.Add("🌲");
            list5.Add("naam");//1
            list5.Add("5,8");//2
            list5.Add("10,6");//3
            list5.Add("8,9");//4
            list5.Add("plant");//5
            list5.Add("categorie");//6
            nepDatabase.Add(4, list5);
            list6.Add("🖥");
            list6.Add("naam");//1
            list6.Add("5,8");//2
            list6.Add("10,6");//3
            list6.Add("8,9");//4
            list6.Add("apparaten");//5
            list6.Add("categorie");//6
            nepDatabase.Add(5, list6);
            list7.Add("🚪");
            list7.Add("naam");//1
            list7.Add("5,8");//2
            list7.Add("10,6");//3
            list7.Add("8,9");//4
            list7.Add("deur");//5
            list7.Add("categorie");//6
            nepDatabase.Add(6, list7);
            list8.Add("⬜");
            list8.Add("naam");//1
            list8.Add("5,8");//2
            list8.Add("10,6");//3
            list8.Add("8,9");//4
            list8.Add("raam");//5
            list8.Add("categorie");//6
            nepDatabase.Add(7, list8);
            list9.Add("🔴");
            list9.Add("naam");//1
            list9.Add("5,8");//2
            list9.Add("10,6");//3
            list9.Add("8,9");//4
            list9.Add("tapijt");//5
            list9.Add("categorie");//6
            nepDatabase.Add(8, list9);
        }
        public static Dictionary<int,List<string>> GetDatabase() 
        {
            return nepDatabase;
        }
        public static void DeleteFromDatabase(string naam) 
        {
            foreach (var item in nepDatabase)
            {

                bool contains = LikeOperator.LikeString(item.Value[1], $"{naam}", Microsoft.VisualBasic.CompareMethod.Binary);
                if (contains == true)
                {
                    nepDatabase.Remove(item.Key);
                }



            }
        }
       public static void ToevoegenAanDatabase(string naam, string prijs,string lengte, string breedte,string categorie, string tag, string image) 
        {
            
            List<string> list= new List<string>();
            list.Add(image);
            list.Add(naam);//1
            list.Add(prijs);//2
            list.Add(lengte);//3
            list.Add(breedte);//4
            list.Add(tag);//5
            list.Add(" "+categorie);//6
            if (nepDatabase.Count==0)
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
            }
            
        }
        public static Dictionary<int, List<string>> ZoekenDatabase(string zoekbalk) 
        {
            Dictionary<int, List<string>> outputQurrey = new Dictionary<int, List<string>>();
            int count = 0;
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
