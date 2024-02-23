using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WPFPoslasticarnica
{
    class Konekcija
    {
        public SqlConnection KreirajKonekciju()
        {
            SqlConnectionStringBuilder ccnSb = new SqlConnectionStringBuilder();
            ccnSb.DataSource = @"Vuk\SQLEXPRESS";
            ccnSb.InitialCatalog = "Poslasticarnica";
            ccnSb.IntegratedSecurity = true;
            string con = ccnSb.ToString();
            SqlConnection konekcija = new SqlConnection(con);
            return konekcija;
        }
    }
}
