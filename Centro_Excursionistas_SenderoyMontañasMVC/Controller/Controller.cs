using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centro_Excursionistas_SenderoyMontañasMVC.View;
using Centro_Excursionistas_SenderoyMontañasMVC.Model;

namespace Centro_Excursionistas_SenderoyMontañasMVC.Controller
{
    internal class Controller
    {
        Datos datos;
        MenuView vista;
       
        public Controller(Datos datos, MenuView vista,ExcursionController excursionController,SocioController socioController,InscripcionController inscripcionController)
        {
            this.datos = datos;
            this.vista = vista;
         
        }
        public Controller()
        {
            datos = new Datos();
            vista = new MenuView(); 

        }

        public void gestionMenu() 
        {
            bool salir = false;
            string opcion;

            do
            {
                opcion = vista.vistaMenu();
                switch (opcion)
                {
                    case "1":
                        gestionMenuExcursiones();
                        break;
                    case "2":
                        gestionMenuSocios();
                        break;
                    case "3":
                        gestionMenuinscripciones();
                        break; 
                 
                    case "0":
                        salir = true;
                        break;
                }

            } while (!salir);
        }

        public void gestionMenuExcursiones()  //OK
        {
            ExcursionController excursionController=new ExcursionController(datos);

            ExcursionView excursionView=new ExcursionView(excursionController);

            excursionController.gestionMenuExcursiones();
        }

        public void gestionMenuSocios()
        {
            SocioController socioController=new SocioController(datos); 

            SocioView socioView=new SocioView(socioController); 

            socioController.gestionMenuSocios(); 
        }

        public void gestionMenuinscripciones()
        {
            InscripcionController inscripcionController = new InscripcionController(datos);

            InscripcionView inscripcionView = new InscripcionView(inscripcionController);

            inscripcionController.gestionMenuInscripciones();
        } 
      

       

      




    } 
}
