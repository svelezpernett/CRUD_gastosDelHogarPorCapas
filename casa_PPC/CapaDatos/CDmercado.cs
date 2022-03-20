using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class CDmercado
    {
        SqlCommand ocmd = new SqlCommand();
        CDconexion oconexion = new CDconexion();


        public bool guardar(CEmercado oemercado)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCASA");
                ocmd.CommandText = "guardar_mercado";
                ocmd.Parameters.Add("@num_facturaM", oemercado.Num_facturaM);
                ocmd.Parameters.Add("@valor_mercado", oemercado.Valor_mercado);
                ocmd.Parameters.Add("@valor_totalM", oemercado.Valor_totalM);
                ocmd.Parameters.Add("@fecha", oemercado.Fecha);
                ocmd.Parameters.Add("@activo", oemercado.Activo);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        

        public bool eliminar(CEmercado oemercado)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCASA");
                ocmd.CommandText = "eliminar_mercado";
                ocmd.Parameters.Add("@num_facturaM", oemercado.Num_facturaM);
                                
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }


        public DataSet consultar(CEmercado oemercado)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCASA");
                ocmd.CommandText = "consultar_mercado";
                ocmd.Parameters.Add("@fecha", oemercado.Fecha);

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
