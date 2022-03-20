using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using System.Configuration;
using System.IO;

namespace CapaDatos
{
    public class CDservicios
    {
        CDconexion oconexion = new CDconexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardar(CEservicios oeservicios)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCASA");
                ocmd.CommandText = "guardar_servicios";
                ocmd.Parameters.Add("@num_facturaS", oeservicios.Num_facturaS);
                ocmd.Parameters.Add("@valor_agua", oeservicios.Valor_agua);
                ocmd.Parameters.Add("@valor_gas", oeservicios.Valor_gas);
                ocmd.Parameters.Add("@valor_luz", oeservicios.Valor_luz);
                ocmd.Parameters.Add("@valor_totalS", oeservicios.Valor_totalS);
                ocmd.Parameters.Add("@fecha", oeservicios.Fecha);
                ocmd.Parameters.Add("@activo", oeservicios.Activo);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }


        public bool eliminar (CEservicios oeservicios)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCASA");
                ocmd.CommandText = "eliminar_servicios";
                ocmd.Parameters.Add("@num_facturaS", oeservicios.Num_facturaS);

                ocmd.ExecuteNonQuery();
                return true;
                
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }


        public DataSet consultar (CEservicios oeservicios)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCASA");
                ocmd.CommandText = "consultar_servicios";
                ocmd.Parameters.Add("@fecha", oeservicios.Fecha);

                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        
    }
}
