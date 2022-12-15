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
        private Connect connection = new Connect();

        public data()
        {

            this.locs = new ArrayList();
            locs.Add(new locatie(1, "berlin"));
            locs.Add(new locatie(2, "brussels"));
            locs.Add(new locatie(3, "paris"));
            this.wagens = new ArrayList();
            wagens.Add(new wagen(1, "golf", 23.5));
            wagens.Add(new wagen(2, "tiguan", 22.5));
            wagens.Add(new wagen(3, "sirocco", 21.5));
        }
        public void Reserveer(int uid,int sloc,int eloc,int vehi, string date, int days)
        {
            connection.connect();
        }
        public ArrayList reservaties(int UID)
        {
            ArrayList RET = new ArrayList();

            return RET;
        }
        public ArrayList Locs { get => locs; set => locs = value; }
        public ArrayList Wagens {get => wagens; set => wagens = value; }
    }
}