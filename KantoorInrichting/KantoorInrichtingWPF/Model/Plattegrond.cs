using System;
using System.Collections.Generic;
using System.Text;

namespace KantoorInrichtingWPF.Model
{
   public class Plattegrond
    {
        public string ProjectNaam { get; set; }
        public string PlattegrondNaam { get; set; }
        public string LaastAangepast { get; set; }
        public string Plattegrondcode { get; set; }
        public string Lengte { get; set; }
        public string Breedte { get; set; }
        public string Hoogte { get; set; }
        public string Open { get; set; }
        public string Verwijder { get; set; }
        public List<string> Canvas { get; set; }

        public Plattegrond(string projectNaam, string plattegrondNaam, string datum,string plategrondcode ,string lengte,string breedte, string hoogte,List<string> canvas) 
        {
            this.ProjectNaam = projectNaam;
            this.PlattegrondNaam = plattegrondNaam;
            this.LaastAangepast = datum;
            this.Plattegrondcode = plategrondcode;
            this.Lengte = lengte;
            this.Breedte = breedte;
            this.Hoogte = hoogte;

            this.Open = "Open Plattegrond";
            this.Verwijder = "     🗑";
            this.Canvas = canvas;
        }
    }
}
