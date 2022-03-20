using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaEntidades
{
    public class CEservicios
    {
        private int num_facturaS;
        private int valor_agua;
        private int valor_gas;
        private int valor_luz;
        private int valor_totalS;
        private SqlDateTime fecha;
        private byte activo;

        public int Num_facturaS { get => num_facturaS; set => num_facturaS = value; }
        public int Valor_agua { get => valor_agua; set => valor_agua = value; }
        public int Valor_gas { get => valor_gas; set => valor_gas = value; }
        public int Valor_luz { get => valor_luz; set => valor_luz = value; }
        public int Valor_totalS { get => valor_totalS; set => valor_totalS = value; }
        public SqlDateTime Fecha { get => fecha; set => fecha = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
