using System;
using System.Collections.Generic;
using System.Text;

namespace KantoorInrichtingWPF.Model
{
   public class Leverancier
    {
        public string Naam { get; set; }
        public string Email { get; set; }
        public string TelefoonNR { get; set; }
        public Leverancier(string naam, string email,string telefoonNR) 
        {
            Naam = naam;
            Email = email;
            TelefoonNR = telefoonNR;
        }
    }
}
