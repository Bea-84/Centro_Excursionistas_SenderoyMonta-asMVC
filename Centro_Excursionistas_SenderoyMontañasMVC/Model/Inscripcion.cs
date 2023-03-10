using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.Model
{
    internal class Inscripcion
    {
        private int num_inscripcion;
        private Socio Socio;
        private Excursion Excursion;

        public int Num_inscripcion { get => num_inscripcion; set => num_inscripcion = value; }
        internal Socio Socio1 { get => Socio; set => Socio = value; }
        internal Excursion Excursion1 { get => Excursion; set => Excursion = value; }

        public override string ToString()
        {
            return "\t"+num_inscripcion ; 
        } 
    }

} 
