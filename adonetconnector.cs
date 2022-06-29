using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WebAPIClient
{
    class adonetconnector
    {
        static void Main(string[] args)
        {
            new adonetconnector().CreateTable();
        }

        private void CreateTable()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("data source=; database=todoitems; integrated security = SSPI");

            } catch
            {
                
            }
            throw new NotImplementedException();
        }

        
    }
}
