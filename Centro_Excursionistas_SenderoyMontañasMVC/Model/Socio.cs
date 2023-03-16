using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.Model
{
    internal abstract class Socio
    {
        private string num_socio;
        private string nombre;

        public string Num_socio { get => num_socio; set => num_socio = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return num_socio+"\t"+nombre; 
        }
    } 
} 
