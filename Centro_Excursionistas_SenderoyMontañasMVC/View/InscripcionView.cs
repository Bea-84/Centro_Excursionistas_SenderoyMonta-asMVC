using Centro_Excursionistas_SenderoyMontañasMVC.Controller;
using Centro_Excursionistas_SenderoyMontañasMVC.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            Hashtable inscripcionHash = new Hashtable();


            Console.WriteLine("Por favor,indique su numero de socio:");
            string num = Console.ReadLine();

            string nombre = inscripcionController.getNumeroSocio(num);
            if (!nombre.Equals(""))
            {
                Console.WriteLine("Socio ya registrado un saludo\t" + nombre);
                int num_inscripcion = inscripcionController.newInscripcion();
                Console.WriteLine("Su número de inscripción es"+"\t"+num_inscripcion+"\t"+"recuérdelo para posteriores consultas"); 
                Console.WriteLine("Seleccione código excursión:");
                string codExcursion = Console.ReadLine();

                inscripcionHash.Add("Numero inscripcion", num_inscripcion);
                inscripcionHash.Add("Socio", num);
                inscripcionHash.Add("Código excursion", codExcursion);

                inscripcionController.añadirInscripcion2(inscripcionHash);
            }
            else
            {

                Console.WriteLine("Bienvenido a centro excursionistas,siga las instrucciones para darse de alta");
                Console.WriteLine("Seleccione tipo de socio 1/Estandar 2/Federado 3/Infantil:");
                string tipo = Console.ReadLine();

                switch (tipo)
                {
                    case "1":
                        Hashtable estandarHash = new Hashtable();
                        Console.WriteLine("Indique su numero de socio");
                        string numEstandar=Console.ReadLine();
                        Console.WriteLine("Indique su nombre:");
                        string nomEstandar = Console.ReadLine();
                        Console.WriteLine("Indique su nif");
                        string nifEstandar = Console.ReadLine();
                        Console.WriteLine("Seleccione tipo de seguro 1/Básico 2/Completo");
                        string tipoSeguro = Console.ReadLine();

                        estandarHash.Add("Num_socio", numEstandar);
                        estandarHash.Add("Nombre", nomEstandar);
                        estandarHash.Add("Nif", nifEstandar);
                        estandarHash.Add("Tipo seguro", tipoSeguro);

                        inscripcionController.añadirSocioEstandar(estandarHash);

                        break;
                    case "2":
                        Hashtable federadoHash = new Hashtable();
                        Console.WriteLine("Indique su numero de socio");
                        string numFederado = Console.ReadLine();
                        Console.WriteLine("Indique su nombre:");
                        string nomFederado = Console.ReadLine();
                        Console.WriteLine("Indique su nif");
                        string nifFederado = Console.ReadLine();
                        Console.WriteLine("Indique nombre de su federación");
                        string nom_federacion = Console.ReadLine();

                        federadoHash.Add("Num_socio", num);
                        federadoHash.Add("Nombre", numFederado);
                        federadoHash.Add("Nif", nifFederado);
                        federadoHash.Add("Federación", nom_federacion);


                        inscripcionController.añadirSocioFederado(federadoHash);

                        break;
                    case "3":
                        Hashtable infantilHash = new Hashtable(); 
                        Console.WriteLine("Indique su numero de socio");
                        string numInfantil = Console.ReadLine();
                        Console.WriteLine("Indique su nombre:");
                        string nomInfantil = Console.ReadLine();
                        Console.WriteLine("Indique numero socio de su tutor");
                        string numTutor = Console.ReadLine();

                        infantilHash.Add("Num_socio", nomInfantil);
                        infantilHash.Add("Nombre", nomInfantil);
                        infantilHash.Add("Num_socioTutor", numTutor);

                        inscripcionController.añadirSocioInfantil(infantilHash);


                        break;
                }

                int num_inscripcion = inscripcionController.newInscripcion();
                Console.WriteLine("Su numero de inscripcion es"+"\t"+num_inscripcion + "\t"+"recuérdelo para posteriores consultas");  
                Console.WriteLine("Seleccione código excursión:");
                string codExcursion = Console.ReadLine();


                inscripcionHash.Add("Numero inscripcion", num_inscripcion);
                inscripcionHash.Add("Socio", num);
                inscripcionHash.Add("Código excursion", codExcursion);

                inscripcionController.añadirInscripcion2(inscripcionHash);

            } 

        }

        public void eliminarInscripcion()   
        {
            Console.WriteLine("Por favor,indique su numero de socio:");
            string num = Console.ReadLine();

            string nombre = inscripcionController.getNumeroSocio(num);
            if(!nombre.Equals(""))
            {
                Console.WriteLine("Para eliminar inscripción indique su numero de inscripción:");
                int num_inscripcion = int.Parse(Console.ReadLine()); 

                inscripcionController.eliminarInscripcion2(num_inscripcion);  
            }
            else
            {
                Console.WriteLine("Socio no registrado"); 
            }


        }

        public void mostrarInscripcion() 
        {
           
            Console.WriteLine("Por favor,indique su numero de socio:");  
            string num = Console.ReadLine();

            string nombre = inscripcionController.getNumeroSocio(num);
            if (!nombre.Equals(""))
            {
                Console.WriteLine("Socio ya registrado un saludo\t" + nombre); 

                List<string> listaInscripciones = inscripcionController.getInscripcion(num);

                Console.WriteLine("Numero inscripción\tNombre socio\tNumero socio\tDescripción excursión\tFecha inscripción\tPrecio excursión:");
                Console.WriteLine("=========================");
                foreach (string inscripcionString in listaInscripciones)
                {
                    Console.WriteLine(inscripcionString);
                }
            }
            else
            {
                Console.WriteLine("Socio no registrado");  
            }

            
        } 
}   } 
