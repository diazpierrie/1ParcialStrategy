using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EELogDisparo
    {
        public EELogDisparo(int id, int id_Objetivo, string arma, bool fueAcierto)
        {
            Id = id;
            Id_Objetivo = id_Objetivo;
            Arma = arma;
            FueAcierto = fueAcierto;
        }

        public int Id { get; set; }
        public int Id_Objetivo { get; set; }
        public string Arma { get; set; }
        public bool FueAcierto { get; set; }


        

    }
}
