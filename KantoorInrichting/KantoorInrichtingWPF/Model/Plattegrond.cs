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
        public decimal Lengte { get; set; }
        public decimal Breedte { get; set; }
        public decimal Hoogte { get; set; }
        public string Open { get; set; }
        public string Verwijder { get; set; }
        public  List<CanvasItem>  Canvas { get; set; }

        public Plattegrond(string projectNaam, string plattegrondNaam, string datum,string plategrondcode ,decimal lengte,decimal breedte, decimal hoogte, List<CanvasItem> canvas) 
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
