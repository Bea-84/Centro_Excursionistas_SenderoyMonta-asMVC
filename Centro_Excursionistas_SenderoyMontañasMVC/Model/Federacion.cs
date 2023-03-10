using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.Model
{
    internal class Federacion
    {
        private int codigo;
        private string nombre;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return codigo+"\t"+nombre; 
        }

    }
} 
