using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNet.Models
{
    public class wagen
    {
        private int wnr;
        private String name;
        private double prijs;

        public wagen(int wnr, string name, double prijs)
        {
            this.wnr = wnr;
            this.name = name;
            this.prijs = prijs;
        }

        public double Prijs { get => prijs; set => prijs = value; }
        public int WNR { get => wnr; set => wnr = value; }
        public string Name { get => name; set => name = value; }
    }
}