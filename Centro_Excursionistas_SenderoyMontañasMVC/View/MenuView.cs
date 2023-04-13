using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.View
{
    internal class MenuView 
    {

        public string vistaMenu()
        {
            string opcion;
            Console.WriteLine("1. Gestión excursiones");
            Console.WriteLine("2. Gestión socios");
            Console.WriteLine("3. Gestión inscripciones");
            Console.WriteLine("0. Salir");
            opcion = pedirOpcionMenu();
            return opcion;
        }

        public string vistaMenuGestionExcursione()   
        {
            string opcion;
            Console.WriteLine("1. Añadir excursión");
            Console.WriteLine("2. Mostrar excursiones con filro entre fechas");
            Console.WriteLine("3. Grabar excursiones a fichero CSV");
            Console.WriteLine("4. Leer excursiones fichero CSV");
            Console.WriteLine("5. Eliminar fichero excursiones CSV"); 
            Console.WriteLine("6. Limpiar List excursiones");  
            Console.WriteLine("7. Llenar List excursiones"); 
            Console.WriteLine("0. Salir");
            opcion = pedirOpcionMenu();
            return opcion;
        }

        public string vistaMenuGestionsocios() 
        {
            string opcion;
            Console.WriteLine("1. Añadir socio estándar");
            Console.WriteLine("2. Modificar tipo de seguro de un socio estándar");
            Console.WriteLine("3. Añadir socio federado");
            Console.WriteLine("4. Añadir socio infantil");
            Console.WriteLine("5. Eliminar socio");
            Console.WriteLine("6. Mostrar socio por tipo");
            Console.WriteLine("7. Mostrar factura mensual por socio");
            Console.WriteLine("0. Salir");
            opcion = pedirOpcionMenu();
            return opcion;
        }

        public string vistaMenuGestionInscripciones()
        {
            string opcion;
            Console.WriteLine("1. Añadir inscripción");
            Console.WriteLine("2. Eliminar inscripción");
            Console.WriteLine("3. Mostrar inscripciones con la opción de filtrar por socio y/o fecha");
            Console.WriteLine("0. Salir");
            opcion = pedirOpcionMenu();
            return opcion;
        }

        private string pedirOpcionMenu() 
        {
            string opcion;
            do
            {
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();
            } while (!"0123456789".Contains(opcion));

            return opcion;

        }
    } 
} 
