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
        private Socio socio;
        private Excursion excursion; 

        public int Num_inscripcion { get => num_inscripcion; set => num_inscripcion = value; }
        internal Socio Socio { get => socio; set => socio = value; }
        internal Excursion Excursion { get => excursion; set => excursion = value; }

        public override string ToString() 
        {
            if (socio is Federado)
            {
                Decimal total = excursion.Precio - excursion.Precio * 10 / 100;
                return "\t" + num_inscripcion + "\t" + Socio.Nombre + "\t" + Socio.Num_socio + "\t" + Excursion.Descripcion + "\t" + Excursion.Fecha + "\t" + total;
            }
            else
            {
                return "\t" + num_inscripcion + "\t" + Socio.Nombre + "\t" + Socio.Num_socio + "\t" + Excursion.Descripcion + "\t" + Excursion.Fecha + "\t" + Excursion.Precio;
            }
        } 
    }

} 
