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
        
        //----------------------------------------------------------------------------------------------------------------------------

        //métodos programa 
        public void añadirCliente(Hashtable excursionHash)
        {
            datos.addExcursion(excursionHash);
        }

        public List<string> getFecha(DateTime fechaInicio,DateTime fechaFin)
        {
             return datos.getExcursionPorFecha(fechaInicio,fechaFin); 
        }

        public string getCodigo(string codigo)
        {
            string descripcionExcursion = datos.getDescripcionExcursionByCodigo(codigo);
            return descripcionExcursion;
        } 

    }  
} 
