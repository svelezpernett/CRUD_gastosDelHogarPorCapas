using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Llamo la capa negocios y capa entidades que tambien estan referenciadas
using CapaDatos;
using CapaEntidades;
//llamo system.Data
using System.Data;

namespace CapaNegocios
{
    public class CNtelecomunicaciones
    {
        CDtelecomunicaciones odtelecomunicaciones = new CDtelecomunicaciones();

        public bool guardar (CEtelecomunicaciones oetelecomunicaciones)
        {
            return odtelecomunicaciones.guardar(oetelecomunicaciones);
        }

        public bool eliminar (CEtelecomunicaciones oetelecomunicaciones)
        {
            return odtelecomunicaciones.eliminar(oetelecomunicaciones);
        }

        public DataSet consultar (CEtelecomunicaciones oetelecomunicaciones)
        {
            return odtelecomunicaciones.consultar(oetelecomunicaciones);
        }
    }
}
