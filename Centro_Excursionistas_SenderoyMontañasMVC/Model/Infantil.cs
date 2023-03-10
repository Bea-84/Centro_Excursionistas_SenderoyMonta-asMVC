using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Excursionistas_SenderoyMontañasMVC.Model
{
    internal class Infantil:Socio
    {
        private string num_socioTutor; 

        public string Num_socioTutor { get => num_socioTutor; set => num_socioTutor = value; }

        public override string ToString()
        {
            return base.ToString() + "\t" +num_socioTutor;  
        }
    }
} 
