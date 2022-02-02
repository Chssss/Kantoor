using System;
using System.Collections.Generic;
using System.Text;

namespace KantoorInrichtingWPF.Model
{
   public class CanvasItem
    {
        
        public string canvasItemcode { get; set; }
        public string plattegrondcode { get; set; }
        public string imageType { get; set; }
        public string naamMeubel { get; set; }
        public decimal imageTagPrijs { get; set; }
        public string xCoord { get; set; }
        public string yCoord { get; set; }
        public string leverancier { get; set; }
        public string productcode { get; set; }
        public int rotatie { get; set; }
        public CanvasItem(string canvasitemcode, string plattegrondcode, string imagetype,string naammeubel,decimal imagetagprijs,string xcoord, string ycoord,string leverancier, string productcode, int rotatie) 
        {
            this.canvasItemcode = canvasitemcode;
            this.plattegrondcode = plattegrondcode;
            this.imageType = imagetype;
            this.naamMeubel = naammeubel;
            this.imageTagPrijs = imagetagprijs;
            this.xCoord = xcoord;
            this.yCoord = ycoord;
            this.leverancier = leverancier;
            this.productcode = productcode;
            this.rotatie = rotatie;
        }
    }
}
