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
    internal class InscripcionController
    {

        Datos Datos;
        MenuView menuView;

        public InscripcionController(Datos pdatos)
        {
            Datos = pdatos;
            menuView = new MenuView();
        }

        public void gestionMenuInscripciones()
        {
            bool salir = false;
            string opcion;

            do
            {
                opcion = menuView.vistaMenuGestionInscripciones();
                switch (opcion)
                {
                    case "1":
                        añadirInscripcion();
                        break;
                    case "2":
                        eliminarInscripcion();
                        break;
                    case "3":
                        mostrarInscripcion();
                        break;
                    case "0":
                        salir = true;
                        break;
                }

            } while (!salir);
        }

        //métodos menú

        public void añadirInscripcion() 
        {
            InscripcionController inscripcionController = new InscripcionController(Datos);

            InscripcionView inscripcionView = new InscripcionView(inscripcionController);

            inscripcionView.añadirInscripcion();
        }

        public void eliminarInscripcion()
        {

        }

        public void mostrarInscripcion()
        {

        }

        //--------------------------------------------------------------------------------------------------------------

        //métodos programa

        public string getNumeroSocio(string num)
        {
            string nombre = Datos.getNombreSocioByNum(num);
            return nombre;
        } 

        public void añadirInscripcion2(Hashtable incripcionHash)
        {
            Datos.addInscripcion(incripcionHash); 
        }

    }

  
}
