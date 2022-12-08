using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace DotNet.Models
{
    public class data
    {
        private ArrayList locs;
        private ArrayList wagens;

        public data()
        {
            this.locs = new ArrayList();
            this.wagens = new ArrayList();
        }

        public ArrayList Locs { get => locs; set => locs = value; }
        public ArrayList Wagens { get => wagens; set => wagens = value; }
    }
}