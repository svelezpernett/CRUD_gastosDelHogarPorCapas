using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CNservicios
    {
        CDservicios odservicios = new CDservicios();

        public bool guardar (CEservicios oeservicios)
        {
            return odservicios.guardar(oeservicios);
        }

        public bool eliminar (CEservicios oeservicios)
        {
            return odservicios.eliminar(oeservicios);
        }

        public DataSet consultar (CEservicios oeservicios)
        {
            return odservicios.consultar(oeservicios);
        }
    }
}
