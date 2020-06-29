using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ManejoSQL
    {
        static SqlConnection serverConection; //server, a que base me conecto y las credenciales
        static SqlCommand commandConection;

        public static void ConectarALaBase(string conectionString)
        {
            try
            {
                serverConection = new SqlConnection(conectionString);
                commandConection = new SqlCommand();
                serverConection.Open();
                
                commandConection.Connection = serverConection;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
