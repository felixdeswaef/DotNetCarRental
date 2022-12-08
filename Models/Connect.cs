using System;
using Oracle.ManagedDataAccess.Client;

namespace DotNet
{
	public class Connect
	{
		private static Connect _instance;

		public Connect ()
		{
		}

		public OracleConnection connect()
		{
			String oradb = "Data Source=" +
			               "(DESCRIPTION = " +
			               "(ADDRESS = (PROTOCOL = TCP)(HOST = laurel.local.thomasmore.be)(PORT = 1521))" +
			               "(CONNECT_DATA =" +
			               "(SERVER = DEDICATED)" +
			               "(SID = erp)));" + 
			               "User Id=e400;Password=e400;" ; 
			Oracle.ManagedDataAccess.Client.OracleConnection conn = new Oracle.ManagedDataAccess.Client.OracleConnection(oradb);

			conn.Open();
			return conn;
		}

		public static Connect instance
		{
			get 
			{
				if (_instance == null)
				{
					_instance = new Connect();
				}
				return _instance;
			}
		}


	}
}

