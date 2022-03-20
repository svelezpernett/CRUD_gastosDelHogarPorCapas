using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaEntidades
{
    public class CEtelecomunicaciones
    {
        private int num_facturaT;
        private int valor_tv;
        private int valor_int;
        private int valor_tel;
        private int valor_totalT;
        private SqlDateTime fecha;
        private byte activo;

        public int Num_facturaT { get => num_facturaT; set => num_facturaT = value; }
        public int Valor_tv { get => valor_tv; set => valor_tv = value; }
        public int Valor_int { get => valor_int; set => valor_int = value; }
        public int Valor_tel { get => valor_tel; set => valor_tel = value; }
        public int Valor_totalT { get => valor_totalT; set => valor_totalT = value; }
        public SqlDateTime Fecha { get => fecha; set => fecha = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
