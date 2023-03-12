using Centro_Excursionistas_SenderoyMontañasMVC.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.View
{
    internal class InscripcionView
    {
        InscripcionController inscripcionController;

        public InscripcionView()
        {

        }

        public InscripcionView(InscripcionController pinscripcionController)
        {
            inscripcionController = pinscripcionController;
        }

        public void añadirInscripcion()
        {
            Hashtable inscripcionHash=new Hashtable();


            Console.WriteLine("Por favor,indique su numero de socio:");
            string num = Console.ReadLine();

            string nombre = inscripcionController.getNumeroSocio(num);
            if (!nombre.Equals(""))
            {
                Console.WriteLine("Socio ya registrado un saludo\t" + nombre);
                Console.WriteLine("A continuación indique su numero de inscripción");
                string num_inscripcion=Console.ReadLine();
                Console.WriteLine("Seleccione la excursion 1/Playa 2/Montaña ");
                string excursion=Console.ReadLine();

                inscripcionHash.Add("Numero inscripcion", num_inscripcion);
                inscripcionHash.Add("Socio", num);
                inscripcionHash.Add("Excursion",excursion);

                inscripcionController.añadirInscripcion2(inscripcionHash); 
            }
            else
            {
                Console.WriteLine("Bienvenido a centro excursionistas");
                Console.WriteLine();
            }

        }
    }
}
