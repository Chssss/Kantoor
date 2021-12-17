using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace KantoorInrichtingWPF
{
   public class Meubel
    {
        //public BitmapSource afbeelding { get; set; }
        public string Img { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public decimal Lengte { get; set; }
        public decimal Breedte { get; set; }
        public decimal Hoogte { get; set; }

        public string Tag { get; set; }
        public string Categorie { get; set; }
        public string Leverancier { get; set; }
        public string Productcode { get; set; }
        public Meubel(string afbeelding, string naam, decimal prijs, decimal lengte, decimal breedte, string tag, string categorie, decimal hoogte, string leverancier,string productcode)
        {
            //this.afbeelding = CreateBitmapSourceFromGdiBitmap(new Bitmap(afbeelding));
            Img= afbeelding;
            this.Naam = naam;
            this.Prijs = prijs;
            this.Lengte = lengte;
            this.Breedte = breedte;
            this.Hoogte = hoogte;
            this.Tag = tag;
            this.Categorie = categorie;
            this.Leverancier = leverancier;
            this.Productcode = productcode;
        }
        
    }
}
