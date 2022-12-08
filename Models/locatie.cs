using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNet.Models
{
    
    public class locatie
    {
        private int lnr;
        private String lnaam;

        public locatie(int lnr, string lnaam)
        {
            this.lnr = lnr;
            this.lnaam = lnaam;
        }

        public int LNR { get => lnr; set => lnr = value; }
        public string Lnaam { get => lnaam; set => lnaam = value; }
    }
}