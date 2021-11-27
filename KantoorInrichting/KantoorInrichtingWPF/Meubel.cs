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
        public string img { get; set; }
        public string naam { get; set; }
        public decimal prijs { get; set; }
        public decimal lengte { get; set; }
        public decimal breedte { get; set; }
        public string tag { get; set; }
        public string categorie { get; set; }
       
        public Meubel(string afbeelding, string naam, decimal prijs, decimal lengte, decimal breedte, string tag, string categorie)
        {
            //this.afbeelding = CreateBitmapSourceFromGdiBitmap(new Bitmap(afbeelding));
           img= afbeelding;
            this.naam = naam;
            this.prijs = prijs;
            this.lengte = lengte;
            this.breedte = breedte;
            this.tag = tag;
            this.categorie = categorie;
        }
        
    }
}
