using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.Model
{
    enum TipoSeguro
    {
        basico, completo
    }
    internal class Datos
    {
        private List<Seguro> seguros;
        private List<Socio> socios;
        private List<Excursion> excursiones;
        private List<Inscripcion> inscripciones;
        private List<Federacion> federaciones;

        public Datos()
        {
            seguros = new List<Seguro>();
            socios = new List<Socio>();
            excursiones = new List<Excursion>();
            inscripciones = new List<Inscripcion>();
            federaciones = new List<Federacion>();

            Seguro seguro = new Seguro();//creo objeto seguro 1
            seguro.Precio = 100;
            seguro.TipoSeguro = TipoSeguro.basico;
            seguros.Add(seguro);
            seguro = new Seguro(); //creo objeto seguro 2
            seguro.Precio = 200;
            seguro.TipoSeguro = TipoSeguro.completo;
            seguros.Add(seguro);

            Federacion federacion = new Federacion(); //creo objeto federación 1
            federacion.Nombre = "On";
            federacion.Codigo = "1";
            federaciones.Add(federacion);
            federacion = new Federacion(); //creo objeto federación 2
            federacion.Nombre = "In";
            federacion.Codigo = "2";
            federaciones.Add(federacion);
        }

        //excursiones

        public string getDescripcionExcursionByCodigo(int codigo)
        {
            foreach (Excursion excursion in excursiones)
            {
                if (excursion.Codigo.Equals(codigo))
                {
                    return excursion.Descripcion;
                }
            }
            return "";
        }

        public void addExcursion(Hashtable excursionHash)
        {
            Excursion excursion = new Excursion();
            excursion.Codigo = (int)excursionHash["Código"];
            excursion.Descripcion = (string)excursionHash["Descripción"];
            excursion.Fecha = (DateTime)excursionHash["Fecha"];
            excursion.Num_dias = (int)excursionHash["Num_dias"];
            excursion.Precio = (int)excursionHash["Precio"];

            excursiones.Add(excursion);
        }

        public List<string> getExcursionPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            List<string> listaExcursiones = new List<string>();

            foreach (Excursion excursion in excursiones)
            {
                if (excursion.Fecha >= fechaInicio && excursion.Fecha <= fechaFin)
                {
                    listaExcursiones.Add(excursion.ToString());
                }
            }
            return listaExcursiones;
        }

        //--------------------------------------------------------------------------------------------------------------------------------//

        //socios
        public string getNombreSocioByNum(string num)
        {
            foreach (Socio socio in socios)
            {
                if (socio.Num_socio.Equals(num))
                {
                    return socio.Nombre;
                }
            }
            return "";
        }

        public void addSocioEstandar(Hashtable estandarHash)
        {
            Estandar estandar = new Estandar();
            estandar.Num_socio = (string)estandarHash["Num_socio"];
            estandar.Nombre = (string)estandarHash["Nombre"];
            estandar.Nif = (string)estandarHash["Nif"];

            string opcionSeguro = (string)estandarHash["Tipo seguro"];//recibo 1/2
            Seguro seguro = getTipoSeguroByOpcion(opcionSeguro);//busco objeto en método
            estandar.Seguro = seguro;//guardo

            socios.Add(estandar);
        }

        public Seguro getTipoSeguroByOpcion(string opcion)
        {
            foreach (Seguro seguro in seguros)
            {
                switch (opcion)
                {
                    case "1":
                        if (seguro.TipoSeguro == TipoSeguro.basico)
                        {
                            return seguro;
                        }
                        break;
                    case "2":
                        if (seguro.TipoSeguro == TipoSeguro.completo)
                        {
                            return seguro;
                        }
                        break;
                }
            }
            return null;
        }

        public void addmodificarTipoSeguro(Hashtable estandarHash)
        {
            Seguro seguro = new Seguro();
            string opcionSeguro = (string)estandarHash["Tipo seguro"];
            seguro = getTipoSeguroByOpcion(opcionSeguro);

            string num = (string)estandarHash["Numero"];
            Socio socio = getSocioEstandarByNum(num);
            (socio as Estandar).Seguro = seguro;

        }

        public Socio getSocioEstandarByNum(string num)
        {
            foreach (Socio socio in socios)
            {
                if ((socio is Estandar) && socio.Num_socio.Equals(num))
                {
                    return socio;
                }

            }
            return null;
        }

        public void addSocioFederado(Hashtable federadoHash)
        {
            Federado federado = new Federado();
            federado.Num_socio = (string)federadoHash["Num_socio"];
            federado.Nombre = (string)federadoHash["Nombre"];
            federado.Nif = (string)federadoHash["Nif"];

            string nombreFederacion = (string)federadoHash["Federación"];
            Federacion federacion = getNombreFederacion(nombreFederacion);
            federado.Federacion = federacion;

            socios.Add(federado);

        }

        public Federacion getNombreFederacion(string nombre)
        {
            foreach (Federacion federacion in federaciones)
            {
                if (federacion.Nombre.Equals(nombre))
                {
                    return federacion;
                }
            }
            return null;

        } 

        public void addSocioInfantil(Hashtable infantilHash)
        {
            Infantil infantil = new Infantil();
            infantil.Num_socio = (string)infantilHash["Num_socio"];
            infantil.Nombre = (string)infantilHash["Nombre"];
            infantil.Num_socioTutor = (string)infantilHash["Num_socioTutor"];

            socios.Add(infantil); 
        }

        public void eliminarSocio(string num)
        {
            foreach(Socio socio in socios)
            {
                if(socio.Num_socio.Equals(num))
                {
                    socios.Remove(socio);
                    return; 
                }
            }

        }

        public List<string> listaSociosByTipo(int tipo)
        {
            List<string> socioEncontrado = new List<string>();
            switch (tipo)
            {
                case 1:
                    foreach (Socio socio in socios)
                    {
                        if (socio is Estandar)
                        {
                            socioEncontrado.Add((socio as Estandar).ToString());
                        }
                    }
                    break;
                case 2:
                    foreach (Socio socio in socios)
                    {
                        if (socio is Federado)
                        {
                            socioEncontrado.Add((socio as Federado).ToString());
                        }
                    }
                    break;
                case 3:
                    foreach (Socio socio in socios)
                    {
                        if (socio is Infantil)
                        {
                            socioEncontrado.Add((socio as Infantil).ToString());
                        }
                    }
                    break;


            }
            return socioEncontrado;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        //inscripciones

        public void addInscripcion(Hashtable inscripcionHash)
        {
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.Num_inscripcion = (string)inscripcionHash["Numero inscripcion"];
        }

















    }
}
