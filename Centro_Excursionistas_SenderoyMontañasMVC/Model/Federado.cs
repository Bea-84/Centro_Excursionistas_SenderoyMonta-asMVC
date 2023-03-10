using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.Model
{
    internal class Federado: Socio
    {
        private string nif;
        private Federacion federacion;

        public string Nif { get => nif; set => nif = value; }
        public Federacion Federacion { get => federacion; set => federacion = value; }

        public override string ToString()
        {
            return base.ToString() +"\t"+ nif +"\t"+federacion; 
        }
    }
}  
