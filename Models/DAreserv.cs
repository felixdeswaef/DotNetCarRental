using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DotNet.Models
{
    public class DAreserv
    {
		private static DAreserv _instance;
		OracleDataAdapter DA;
		OracleCommandBuilder CB;
		DataTable DT;

		private DAreserv()
		{
			DA = new OracleDataAdapter("select * from AA_customers", Connect.instance.connect());
			CB = new OracleCommandBuilder(DA);
			DT = new DataTable();
			DA.Fill(DT);
		}
		public void Reserveer(int uid, int sloc, int eloc, int vehi, string date, int days)
		{
			DataRow workRow = DT.NewRow();
			workRow["nr"] = DT.Rows.Count + 10;
			workRow["cnr"] = uid;
			workRow["pickuplocation "] = sloc;
			workRow["dropoffLocation "] = eloc;
			workRow["cartype"] = vehi;
			workRow["datefrom"] = new DateTime();//TODO
			workRow["days"] =days;
			workRow["resdate"] = new DateTime();//TODO

			DA.Update(DT);


		}


		public static DAreserv instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new DAreserv();
				}
				return _instance;
			}
		}
	}
}
