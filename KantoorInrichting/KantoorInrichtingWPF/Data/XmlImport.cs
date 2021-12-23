using System;
using System.Xml;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace xmlTestding
{
    class Program
    {

        static void Main(string[] args)
        {
            XmlDocument xdoc = new XmlDocument();
            //hier liever dus een selectiewindow
            xdoc.Load(@"C:\Users\Jelle\Documents\GitHub\Kantoor\KantoorInrichting\KantoorInrichtingWPF\Xml\XMLFile1.xml");

            XmlNodeList nodes = xdoc.SelectNodes("//meubels/meubel");

            foreach (XmlNode node in nodes)
            {
                string _productcode = "0";
                string _leverancier = "0";
                string _img = "0";
                string _naam = "0";
                string _prijs = "0";
                string _lengte = "0";
                string _breedte = "0";
                string _tag = "0";
                string _categorie = "0";
                string _hoogte = "0";


                Console.WriteLine("-------------------------------------------");

                XmlNode productcode = node.SelectSingleNode("productcode");

                if (productcode != null)
                {
                    Console.WriteLine(productcode.InnerText);
                    _productcode = $"{productcode.InnerText}";

                }


                XmlNode leverancier = node.SelectSingleNode("leverancier");
                if (leverancier != null)
                {
                    Console.WriteLine(leverancier.InnerText);
                    _leverancier = $"{leverancier.InnerText}";
                }

                XmlNode img = node.SelectSingleNode("img");
                if (img != null)
                {
                    Console.WriteLine(img.InnerText);
                    _img = $"{img.InnerText}";
                }

                XmlNode naam = node.SelectSingleNode("naam");
                if (naam != null)
                {
                    Console.WriteLine(naam.InnerText);
                    _naam = $"{naam.InnerText}";
                }

                XmlNode prijs = node.SelectSingleNode("prijs");
                if (prijs != null)
                {
                    Console.WriteLine(prijs.InnerText);
                    _prijs = $"{prijs.InnerText}";
                }

                XmlNode lengte = node.SelectSingleNode("lengte");
                if (lengte != null)
                {
                    Console.WriteLine(lengte.InnerText);
                    _lengte = $"{lengte.InnerText}";
                }

                XmlNode breedte = node.SelectSingleNode("breedte");
                if (breedte != null)
                {
                    Console.WriteLine(breedte.InnerText);
                    _breedte = $"{breedte.InnerText}";
                }

                XmlNode tag = node.SelectSingleNode("tag");
                if (tag != null)
                {
                    Console.WriteLine(tag.InnerText);
                    _tag = $"{tag.InnerText}";
                }

                XmlNode categorie = node.SelectSingleNode("categorie");
                if (categorie != null)
                {
                    Console.WriteLine(categorie.InnerText);
                    _categorie = $"{categorie.InnerText}";
                }

                XmlNode hoogte = node.SelectSingleNode("hoogte");
                if (hoogte != null)
                {
                    Console.WriteLine(hoogte.InnerText);
                    _hoogte = $"{hoogte.InnerText}";
                }

                MeubelDatabase.UpdateCheck(_productcode);

                MeubelDatabase.ToevoegenAanDatabase(_naam, _prijs, _lengte, _breedte, _categorie, _tag, _img, _hoogte, _leverancier,_productcode);

                MeubelDatabase.DeleteFromDatabase(_productcode);
            }


        }
    }
}
