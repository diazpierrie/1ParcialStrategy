using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection.Emit;
using EE;

namespace BLL
{
    public class BLLObjetivo
    {
        private Random _rand;
        private string[] _nombres =
        {
            "El rombo de Evangelion",
            "Hydralisk",
            "Siege Tank",
            "Zerg Queen",
            "Chrono Legionnaire"
        };


        public void EscanearObjetivos(BindingList<EEObjetivo> objetivos)
        {
            var cantidadObjetivos = _rand.Next(1, 4);
            
            for (int i = 0; i < cantidadObjetivos; i++)
                objetivos.Add(new EEObjetivo(
                        _nombres[_rand.Next(_nombres.Length)],
                        _rand.Next(1, 200),
                        _rand.Next(1, 100)
                    )
                );
        }

        public void DispararObjetivo(BindingList<EEObjetivo> objetivos)
        {
            var cantidadObjetivos = _rand.Next(1, 4);

            for (int i = 0; i < cantidadObjetivos; i++)
                objetivos.Add(new EEObjetivo(
                        _nombres[_rand.Next(_nombres.Length)],
                        _rand.Next(1, 200),
                        _rand.Next(1, 100)
                    )
                );
        }
    }
}
