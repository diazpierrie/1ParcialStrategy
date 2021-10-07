using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EEObjetivo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Distancia { get; set; }
        [DisplayName("% de Acierto")]
        public int ProbabilidadAcierto { get; set; }

        public bool Activo { get; set; }

        public EEObjetivo(int id, string nombre, int distancia, int probabilidadDeHit, bool activo)
        {
            Id = id;
            Nombre = nombre;
            Distancia = distancia;
            ProbabilidadAcierto = probabilidadDeHit;
            Activo = activo;
        }

    }
}
