using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.Model
{
    internal class Estandar: Socio
    {
        private string nif;
        private Seguro seguro;

        public string Nif { get => nif; set => nif = value; }
        internal Seguro Seguro { get => seguro; set => seguro = value; }

        public override string ToString()
        {
            return base.ToString()+"\t" + nif + "\t" +seguro; 
        }
    } 
} 
