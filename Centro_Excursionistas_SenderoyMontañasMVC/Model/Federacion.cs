using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.Model
{
    internal class Federacion
    {
        private string codigo;
        private string nombre;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return nombre+"\t"+codigo; 
        }

    }
} 
