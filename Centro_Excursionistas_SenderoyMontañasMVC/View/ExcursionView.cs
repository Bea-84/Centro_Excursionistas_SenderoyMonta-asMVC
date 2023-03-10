using Centro_Excursionistas_SenderoyMontañasMVC.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
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
            int codigo=int.Parse(Console.ReadLine());

            string descripcion = excursionController.getCodigo(codigo); 
            if(!descripcion.Equals("")) 
            {
                Console.WriteLine("La excursión con la siguiente descripción"+descripcion+"\t esta completa"); 
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
                excursionHash.Add("Num_dias",num_dias);
                excursionHash.Add("Precio", precio);

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

            Console.WriteLine("A continuación podrás ver las siguientes excursiones:");
            Console.WriteLine("=====================================================");
            foreach(string excursionstring in listaExcursiones)
            {
                Console.WriteLine(excursionstring);
            } 
        }  
    }   
}
