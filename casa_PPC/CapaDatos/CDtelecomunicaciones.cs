using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Llamo a la capa entidades
using CapaEntidades;
//importo las siguientes librerias
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace CapaDatos
{
    public class CDtelecomunicaciones
    {
        CDconexion oconexion = new CDconexion();     //<- Instancion la clase CDconexion por medio del objeto para conectar con la BD a traves de la funcion conectar de CDconexion
        SqlCommand ocmd = new SqlCommand();          //<- Instancio la clase sqlcommand por medio de un objeto para usar los comandos de sql 


        //CREO LAS FUNCIONES DE CRUD
        public bool guardar(CEtelecomunicaciones otelecomunicaciones)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure; //<- Tipo de procedimineto
                ocmd.Connection = oconexion.conectar("BDCASA"); //<- Se hacela conexon por medio de oconexion.conectar
                ocmd.CommandText = "guardar_telecom"; //<- El nombre del proc almacenado como esta en SQL
                ocmd.Parameters.Add("@num_facturaT", otelecomunicaciones.Num_facturaT); //<- En esta funcion se añdaen los parametros que asigna el usuario a las varibles temporales del proc. almacenado de SQL
                ocmd.Parameters.Add("@valor_tv", otelecomunicaciones.Valor_tv);
                ocmd.Parameters.Add("@valor_int", otelecomunicaciones.Valor_int);
                ocmd.Parameters.Add("@valor_tel", otelecomunicaciones.Valor_tel);
                ocmd.Parameters.Add("@fecha", otelecomunicaciones.Fecha);
                ocmd.Parameters.Add("@activo", otelecomunicaciones.Activo);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }


        public bool eliminar(CEtelecomunicaciones otelecomunicaciones)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCASA");
                ocmd.CommandText = "eliminar_telecom";
                ocmd.Parameters.Add("@num_facturaT", otelecomunicaciones.Num_facturaT);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
         
        }


        public DataSet consultar(CEtelecomunicaciones otelecomunicaciones)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCASA");
                ocmd.CommandText = "consultar";
                ocmd.Parameters.Add("@fecha", otelecomunicaciones.Fecha);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
