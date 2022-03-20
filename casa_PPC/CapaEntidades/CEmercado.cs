using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaEntidades
{
    public class CEmercado
    {
        private int num_facturaM;
        private int valor_mercado;
        private SqlDateTime fecha;
        private int valor_totalM;
        private byte activo;

        public int Num_facturaM { get => num_facturaM; set => num_facturaM = value; }
        public int Valor_mercado { get => valor_mercado; set => valor_mercado = value; }
        public SqlDateTime Fecha { get => fecha; set => fecha = value; }
        public int Valor_totalM { get => valor_totalM; set => valor_totalM = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
