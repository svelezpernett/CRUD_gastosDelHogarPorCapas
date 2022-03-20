using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class CNmercado
    {
        CDmercado odmercado = new CDmercado();

        public bool guardar(CEmercado oemercado)
        {
            return odmercado.guardar(oemercado);
        }


        public bool eliminar(CEmercado oemercado)
        {
            return odmercado.eliminar(oemercado);
        }


        public DataSet consultar(CEmercado oemercado)
        {
            return odmercado.consultar(oemercado);
        }
    }
}
