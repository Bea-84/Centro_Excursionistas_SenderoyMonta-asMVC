using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.Model
{
    internal class Excursion
    {
        private int precio;
        private int codigo;
        private string descripcion;
        private DateTime fecha;
        private int num_dias;

        public int Precio { get => precio; set => precio = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Num_dias { get => num_dias; set => num_dias = value; }

        public override string ToString()
        {
            return precio+"\t"+codigo+"\t"+descripcion+"\t"+fecha+"\t"+num_dias; 
        }
    }
} 
