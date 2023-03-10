using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centro_Excursionistas_SenderoyMontañasMVC.View;
using Centro_Excursionistas_SenderoyMontañasMVC.Model;


namespace Centro_Excursionistas_SenderoyMontañasMVC.Controller 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controlador = new Controller();
            controlador.gestionMenu(); 
        }
    }
} 
