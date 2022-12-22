using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace DotNet.Models
{
	
	public class DAclients
    {
		private static DAclients _instance;
		OracleDataAdapter DA;
		OracleCommandBuilder CB;
		DataTable CT;

		public DAclients()
        {
            DA = new OracleDataAdapter("select * from AA_customers;", Connect.instance.connect());
            CB = new OracleCommandBuilder(DA);
			CT = new DataTable() ;
			DA.Fill(CT);
        }
		public string user(int uid)
        {
			return (string) CT.Rows.Find(uid).ItemArray[1];
        }


		public static DAclients instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new DAclients();
				}
				return _instance;
			}
		}

	}
}