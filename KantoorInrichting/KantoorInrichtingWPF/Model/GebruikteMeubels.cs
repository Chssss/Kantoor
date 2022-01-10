using System;
using System.Collections.Generic;
using System.Text;

namespace KantoorInrichtingWPF.Model
{
   public class GebruikteMeubels
    {
       public string Naam { get; set; }
       public int Aantal { get; set; }
        public decimal Prijs { get; set; }
        public decimal Totaalprijs { get; set; }
        public string Leverancier{ get; set; }
        public string Productcode { get; set; }
        public GebruikteMeubels(string naamMeubel,int aantalMeubels,decimal prijsEnkelMeubel,decimal totaalprijsMeubels,string leverancier,string productcode) 
        {
            this.Naam = naamMeubel;
            this.Aantal = aantalMeubels;
            this.Prijs = prijsEnkelMeubel;
            this.Totaalprijs = totaalprijsMeubels;
            this.Leverancier = leverancier;
            this.Productcode = productcode; ;
        }
    }
}
