using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importar las librerias de sql y de web config
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class CDconexion
    {
        public SqlConnection conectar (string cnx) //aca se genera una funcion con sqlconnection conectar con parametro string cnx
        {
            try
            {
                SqlConnection oconectar = new SqlConnection(ConfigurationSettings.AppSettings[cnx].ToString());
                oconectar.Open();
                return oconectar;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
            
          
    }
}
