using Centro_Excursionistas_SenderoyMontañasMVC.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.View
{
    internal class ExcursionView
    {
        ExcursionController excursionController;

        public ExcursionView()
        {

        }

        public ExcursionView(ExcursionController pexcursionController)
        {
            excursionController = pexcursionController;
        }  
        
        public void añadirExcursion() 
        {
            Hashtable excursionHash=new Hashtable();

            Console.WriteLine("Por favor,introduzca el código de la excursión seleccionada");
            string codigo=Console.ReadLine();

            string descripcion = excursionController.getCodigo(codigo); 
            if(!descripcion.Equals("")) 
            {
                Console.WriteLine("La excursión con la siguiente descripción\t"+descripcion+"\t está completa"); 
            }
            else
            {
                
                Console.WriteLine("Indique la descripción de la excursión seleccionada");
                descripcion=Console.ReadLine();
                Console.WriteLine("Indique la fecha seleccionada");
                DateTime fecha=DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Indique el precio");
                int precio=int.Parse(Console.ReadLine());
                Console.WriteLine("Indique los dias de duración seleccionados");
                int num_dias=int.Parse(Console.ReadLine()); 

                excursionHash.Add("Código", codigo);
                excursionHash.Add("Descripción", descripcion);
                excursionHash.Add("Fecha",fecha);
                excursionHash.Add("Precio", precio);
                excursionHash.Add("Num_dias", num_dias);

                excursionController.añadirCliente(excursionHash); 
            } 

        } 

        public void mostrarExcursionComprendidasPorfecha() 
        {
           //pido por teclado fechas

           Console.WriteLine("Por favor indique la fecha de inicio:");
           DateTime fechaInicio=DateTime.Parse(Console.ReadLine());
           Console.WriteLine("Indique la fecha fin:");
           DateTime fechaFin=DateTime.Parse(Console.ReadLine());

            //voy controlador y allí método que vaya a datos 

            List<string> listaExcursiones = excursionController.getFecha(fechaInicio,fechaFin);

            //devolvera las excursiones que hay entre estas dos fechas

            Console.WriteLine("Precio\tCódigo excursión\tdescripción excursión\tfecha excursión\tduración excursión:"); 
            Console.WriteLine("==============================================================================================="); 
            foreach(string excursionstring in listaExcursiones)
            {
                Console.WriteLine(excursionstring);
            } 
        }  

        public void grabarFicheroExcursion()
        {
            Hashtable excursionHash = new Hashtable(); 

            Console.WriteLine("Por favor,introduzca el código de la excursión seleccionada");
            string codigo = Console.ReadLine();

            string descripcion = excursionController.getCodigo(codigo);
            if (!descripcion.Equals(""))
            {
                excursionController.grabarExcursion(excursionHash);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Los datos se han grabado en el fichero correctamente");
                Console.ForegroundColor = ConsoleColor.Gray; 
            }
            else
            {
                Console.WriteLine("Excursión inexistente");
            }
        }

        public void leerFicheroExcursion()
        {
            Hashtable excursionHash = new Hashtable();

            Console.WriteLine("Por favor,introduzca el código de la excursión seleccionada");
            string codigo = Console.ReadLine();

            string descripcion = excursionController.getCodigo(codigo);
            if (!descripcion.Equals(""))
            {
                excursionController.leerExcursion(excursionHash); 
            }
            else
            {
                Console.WriteLine("Excursión inexistente"); 
            }
        }

        public void eliminarFicheroExcursion()  
        {
            Hashtable excursionHash = new Hashtable();

            Console.WriteLine("Por favor,introduzca el código de la excursión seleccionada");
            string codigo = Console.ReadLine();

            string descripcion = excursionController.getCodigo(codigo);
            if (!descripcion.Equals(""))
            {
                excursionController.limpiarFichero(excursionHash);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fichero eliminado");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine("Excursión inexistente");  
            }
        }

        public void vaciarList() 
        {
            excursionController.limpiarList2();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Lista excursiones vaciada"); 
            Console.ForegroundColor=ConsoleColor.Gray;
        }

        public void llenarList() 
        {
            excursionController.llenarList2();  
        }
           
        
    }   
}  
