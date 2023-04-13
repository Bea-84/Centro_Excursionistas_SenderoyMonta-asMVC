using Centro_Excursionistas_SenderoyMontañasMVC.Model;
using Centro_Excursionistas_SenderoyMontañasMVC.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.Controller
{
    internal class ExcursionController
    {
        Datos datos;
        MenuView menuView;

        public ExcursionController(Datos pdatos)
        {
            datos = pdatos;
            menuView = new MenuView();

        }

        public void gestionMenuExcursiones()
        {
            bool salir = false;
            string opcion;

            do
            {
                opcion = menuView.vistaMenuGestionExcursione();
                switch (opcion)
                {
                    case "1":
                        añadirExcursion();
                        break;
                    case "2":
                        mostrarExcursionComprendidasPorfecha();
                        break;
                    case "3":
                        grabarExcursionesFicheroCSV();
                        break;
                    case "4":
                        leerExcursionesFicheroCSV();
                        break;
                    case "5":
                        eliminarDatosExcursionesFicheroCSV(); 
                        break;
                    case "6":
                        limpiarList();
                        break;
                    case "7":
                        llenarList(); 
                        break; 
                    case "0":
                        salir = true;
                        break;
                }

            } while (!salir);  
        }

        //métodos menú 

        public void añadirExcursion()
        {
            ExcursionController excursionController = new ExcursionController(datos);

            ExcursionView excursionView = new ExcursionView(excursionController);

            excursionView.añadirExcursion();
        }

        public void mostrarExcursionComprendidasPorfecha()
        {
            ExcursionController excursionController = new ExcursionController(datos);

            ExcursionView excursionView = new ExcursionView(excursionController);

            excursionView.mostrarExcursionComprendidasPorfecha();

        }

        public void grabarExcursionesFicheroCSV()
        {
            ExcursionController excursionController = new ExcursionController(datos);

            ExcursionView excursionView = new ExcursionView(excursionController);

            excursionView.grabarFicheroExcursion();
        }

        public void leerExcursionesFicheroCSV()
        {
            ExcursionController excursionController = new ExcursionController(datos);

            ExcursionView excursionView = new ExcursionView(excursionController);

            excursionView.leerFicheroExcursion();
        }

        public void eliminarDatosExcursionesFicheroCSV()
        {
            ExcursionController excursionController = new ExcursionController(datos);

            ExcursionView excursionView = new ExcursionView(excursionController);

            excursionView.eliminarFicheroExcursion(); 
        }

        public void limpiarList()
        {
            ExcursionController excursionController = new ExcursionController(datos);

            ExcursionView excursionView = new ExcursionView(excursionController);

            excursionView.vaciarList(); 
        }

        public void llenarList()
        {
            ExcursionController excursionController = new ExcursionController(datos);

            ExcursionView excursionView = new ExcursionView(excursionController);

            excursionView.llenarList(); 
        }

        //----------------------------------------------------------------------------------------------------------------------------

        //métodos programa 
        public void añadirCliente(Hashtable excursionHash)
        {
            datos.addExcursion(excursionHash);
        }

        public List<string> getFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return datos.getExcursionPorFecha(fechaInicio, fechaFin);
        }

        public string getCodigo(string codigo)
        {
            string descripcionExcursion = datos.getDescripcionExcursionByCodigo(codigo);
            return descripcionExcursion;
        }

        public void grabarExcursion(Hashtable excursionHash)
        {
            datos.grabarExcursionFicheroCSV(excursionHash);
        }

        public void leerExcursion(Hashtable excursionHash)
        {
            datos.leerExcursionFicheroCSV(excursionHash);
        }

        public void limpiarFichero(Hashtable excursionHash)
        {
            datos.eliminarFicheroCSV(excursionHash); 
        }

        public void limpiarList2() 
        {
            datos.clearList();   
        }

        public void llenarList2()
        {
            datos.fillList(); 
        }
            


    }  
} 
