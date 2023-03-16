using Centro_Excursionistas_SenderoyMontañasMVC.Model;
using Centro_Excursionistas_SenderoyMontañasMVC.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.Controller
{
    internal class SocioController
    {
        Datos Datos;
        MenuView menuView;

        public SocioController(Datos pdatos)
        {
            Datos = pdatos;
            menuView = new MenuView();
        }

        public void gestionMenuSocios()
        {
            bool salir = false;
            string opcion;

            do
            {
                opcion = menuView.vistaMenuGestionsocios();
                switch (opcion)
                {
                    case "1":
                        añadirSocioEstandar();
                        break;
                    case "2":
                        modificarTipoSeguro(); 
                        break;
                    case "3":
                        añadirSocioFederado();
                        break;
                    case "4":
                        añadirSocioInfantil();
                        break;
                    case "5":
                        eliminarSocio();
                        break;
                    case "6":
                        mostrarSociosPorTipo();
                        break;
                    case "7":
                        mostrarFacturaMensualSocio();
                        break ;


                    case "0":
                        salir = true;
                        break;
                }

            } while (!salir);
        }

        //métodos menú 

        public void añadirSocioEstandar() 
        {
            SocioController socioController = new SocioController(Datos); 

            SocioView socioView = new SocioView(socioController);

            socioView.añadirSocioEstandar();
        }

        public void modificarTipoSeguro() 
        {
            SocioController socioController = new SocioController(Datos);

            SocioView socioView =new SocioView(socioController);

            socioView.modificarTipoSeguro();
        }

        public void añadirSocioFederado()
        {
            SocioController socioController=new SocioController(Datos);

            SocioView socioView=new SocioView(socioController);

            socioView.añadirSocioFederado();
        }

        public void añadirSocioInfantil()
        {
            SocioController socioController = new SocioController(Datos);

            SocioView socioView=new SocioView(socioController);

            socioView.añadirSocioInfantil();
        }

        public void eliminarSocio() 
        {
            
            SocioController socioController = new SocioController(Datos);

            SocioView socioView = new SocioView(socioController);

            socioView.eliminarSocioByNum(); 

        } 

        public void mostrarSociosPorTipo() 
        {
            int tipoSocio;
            tipoSocio = SocioView.seleccionarTipoSocio();
            List<string> listaSocios = Datos.listaSociosByTipo(tipoSocio);
            SocioController socioController = new SocioController(Datos);
            SocioView socioView = new SocioView(socioController);
            socioView.mostrarSocioPorTipo(listaSocios, tipoSocio); 
        }

        public void mostrarFacturaMensualSocio() 
        {
            SocioController socioController = new SocioController(Datos);

            SocioView socioView = new SocioView(socioController);

            socioView.mostrarFacturaMensualSocio();

        }  
     
        //-------------------------------------------------------------------------------------------------------------------------

        //métodos programa 
        public string getNumeroSocio(string num)   
        {
            string nombre = Datos.getNombreSocioByNum(num);
            return nombre;
        }

        public void añadirSocioEstandar2(Hashtable estandarHash) 
        {
            Datos.addSocioEstandar(estandarHash);  
        }

        public void modificarTipoSeguro(Hashtable estandarHash)
        {
            Datos.addmodificarTipoSeguro(estandarHash);  
        }

        public void añadirSocioFederado2(Hashtable federadoHash)
        {
            Datos.addSocioFederado(federadoHash);
        }

        public void añadirSocioInfantil2(Hashtable infantilHash)
        {
            Datos.addSocioInfantil(infantilHash); 
        } 

        public void eliminarSocio(string num)
        {
            Datos.eliminarSocio(num);
        }

      

      

    }   
} 
