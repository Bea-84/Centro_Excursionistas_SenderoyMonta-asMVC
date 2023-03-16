using Centro_Excursionistas_SenderoyMontañasMVC.Controller;
using Centro_Excursionistas_SenderoyMontañasMVC.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.View
{
    internal class SocioView
    {
        
        SocioController socioController;

        public SocioView()
        {

        }

        public SocioView(SocioController psocioController)
        {
            socioController = psocioController;
        }

        public void añadirSocioEstandar() 
        {
            Hashtable estandarHash=new Hashtable();

            Console.WriteLine("Por favor,indique su numero de socio:");
            string num=Console.ReadLine();

            string nombre = socioController.getNumeroSocio(num); 
            if(!nombre.Equals(""))
            {
                Console.WriteLine("Socio ya registrado un saludo\t"+nombre); 
            }
            else
            {

                Console.WriteLine("Introduzca su nombre");
                string nombreSocio = Console.ReadLine();
                Console.WriteLine("Introduzca su nif");
                string nif = Console.ReadLine();
                Console.WriteLine("Indique tipo de seguro 1/Básico 2/Completo");  
                string seguro = Console.ReadLine(); 

                estandarHash.Add("Num_socio",num  );
                estandarHash.Add("Nombre", nombreSocio);
                estandarHash.Add("Nif",nif );
                estandarHash.Add("Tipo seguro",seguro); 

                socioController.añadirSocioEstandar2(estandarHash); 
            }
        } 

        public void modificarTipoSeguro()
        {
            Hashtable estandarHash=new Hashtable(); 

            Console.WriteLine("Por favor,indique su numero de socio:");
            string num = Console.ReadLine();

            string nombre = socioController.getNumeroSocio(num);
            if (!nombre.Equals(""))
            {
                Console.WriteLine("Bienvenido/a" + nombre);
                Console.WriteLine("¿Necesitas cambiar el tipo de seguro contratado?(s/n)"); 
                string ok=Console.ReadLine();
                if(ok.ToUpper().Equals("S"))
                {
                    Console.WriteLine("Indique tipo de seguro 1/Básico 2/Completo");
                    string seguro = Console.ReadLine();

                    estandarHash.Add("Tipo seguro",seguro );
                    estandarHash.Add("Numero",num);

                    socioController.modificarTipoSeguro(estandarHash); 

                }
            }
            else
            {
                Console.WriteLine("Socio inexistente");
            }



        }
        
        public void añadirSocioFederado() 
        {
            Hashtable federadoHash = new Hashtable();

            Console.WriteLine("Por favor,indique su numero de socio:");
            string num = Console.ReadLine();

            string nombre = socioController.getNumeroSocio(num);  
            if (!nombre.Equals(""))
            {
                Console.WriteLine("Socio ya registrado un saludo\t" + nombre);
            }
            else
            {
                Console.WriteLine("Introduzca su nombre");
                string nombreSocio = Console.ReadLine();
                Console.WriteLine("Introduzca su nif");
                string nif = Console.ReadLine();
                Console.WriteLine("Indique el nombre de su federación");
                string federacion=Console.ReadLine();
               

                federadoHash.Add("Num_socio", num);
                federadoHash.Add("Nombre", nombreSocio);
                federadoHash.Add("Nif",nif);
                federadoHash.Add("Federación",federacion);
               

                socioController.añadirSocioFederado2(federadoHash);  
            }
        } 

        public void añadirSocioInfantil()
        {
            Hashtable infantilHash=new Hashtable();

            Console.WriteLine("Por favor,indique el numero de socio de su tutor:");
            string num = Console.ReadLine();

            string nombre = socioController.getNumeroSocio(num);
            if (!nombre.Equals(""))
            {
                Console.WriteLine("Socio ya registrado un saludo\t" + nombre);
            }
            else
            {
                Console.WriteLine("Indique su numero socio:");
                string num_socio=Console.ReadLine();
                Console.WriteLine("Indique su nombre:");
                string nombreSocio=Console.ReadLine();

                infantilHash.Add("Num_socio", num_socio);
                infantilHash.Add("Nombre",nombreSocio);
                infantilHash.Add("Num_socioTutor", num);

                socioController.añadirSocioInfantil2(infantilHash); 
            }


        } 

        public void eliminarSocioByNum() 
        {
            
            Console.WriteLine("Por favor,indique su numero de socio:");
            string num = Console.ReadLine();

            string nombre = socioController.getNumeroSocio(num); 
            if (!nombre.Equals(""))
            {
                Console.WriteLine("Socio ya registrado un saludo\t" + nombre);
                Console.WriteLine("¿Seguro que deseas darte de baja?(s/n)");
                string ok=Console.ReadLine();
                if(ok.ToUpper().Equals("S"))
                {
                    socioController.eliminarSocio(num);      
                }
                else
                {
                    Console.WriteLine("Gracias por confiar en nosotros"); 
                }

            }
            else
            {
                Console.WriteLine("Socio inexistente"); 
            }

        }

        public void mostrarSocioPorTipo(List<string>listaSocios,int tipo)  
        {
            switch(tipo)
            {
                case 1:
                    Console.WriteLine("Numero socio\tNombre\tNif\tPrecio seguro\tTipo de seguro:");
                    Console.WriteLine("============\t======\t===\t=============\t===============");
                    break;
                case 2:
                    Console.WriteLine("Numero socio\tNombre\tNif\tNombre federación\tCódigo federación:");
                    Console.WriteLine("============\t======\t===\t====================================="); 
                    break;
                case 3:
                    Console.WriteLine("Numero socio\tNombre\tNumero socio tutor");
                    Console.WriteLine("============\t======\t==================");  
                    break;

            }
            foreach(string socioString in listaSocios)
            {
                Console.WriteLine(socioString);   
            } 

        }

        public void mostrarFacturaMensualSocio()  
        {
            //comprobar si existe 
            //busco objeto socio
            //identificar tipo socio
            //busco inscripciones
            //aplica descuento
            //mostrar 
            Console.WriteLine("Por favor,indique su numero de socio:");
            string num = Console.ReadLine();

            string nombre = socioController.getNumeroSocio(num);
            if (!nombre.Equals(""))
            {
                Console.WriteLine("Socio ya registrado un saludo\t" + nombre);
                Console.WriteLine("Indique que tipo de socio eres 1/Estandar 2/Federado 3/Infantil");
                string tipo=Console.ReadLine();
                switch(tipo)
                {
                    case "1":
                        Console.WriteLine("Indique el mes,para poder mostrar factura");
                        int mesEstandar = int.Parse(Console.ReadLine());  
                        break;
                    case "2":
                        Console.WriteLine("Indique el mes,para poder mostrar factura");
                        int mesfederado=int.Parse(Console.ReadLine());  
                        break;
                    case "3":
                        Console.WriteLine("Indique el mes,para poder mostrar factura");
                        int mesInfantil=int.Parse(Console.ReadLine());  
                        break;  
                }
            }
            else
            {
                Console.WriteLine("Socio inexistente");
            }
        } 
        public static int seleccionarTipoSocio() 
        { 
            int opcion;

                do
                {
                   
                    Console.WriteLine("Seleccione tipo de socio : 1) Estandar 2) Federado 3) Infantil 0) Salir");
                    opcion = int.Parse(Console.ReadLine());

                } while (opcion < 0 || opcion > 3);
                return opcion;
            
        } 

       
    } 
}
