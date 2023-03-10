using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.Model
{
    internal class Seguro
    {
        private int precio;
        private TipoSeguro tipoSeguro;

        public int Precio { get => precio; set => precio = value; }

        internal TipoSeguro TipoSeguro { get => tipoSeguro; set => tipoSeguro = value; }

        public override string ToString()
        {
            return precio+"\t"+TipoSeguro; 
        }
    } 
} 
