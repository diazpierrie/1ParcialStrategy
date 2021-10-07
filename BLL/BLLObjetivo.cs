using System;
using System.Collections.Generic;
using System.ComponentModel;
using EE;
using MPP;

namespace BLL
{
    public class BLLObjetivo
    {
        private Random _rand = new Random();
        private MPPObjetivo _mppObjetivo = new MPPObjetivo();
        private List<EEObjetivo> _objetivos = new List<EEObjetivo>();
        private string[] _nombres =
        {
            "El rombo de Evangelion",
            "Hydralisk",
            "Siege Tank",
            "Zerg Queen",
            "Chrono Legionnaire"
        };

        public BindingList<EEObjetivo> EscanearObjetivos()
        {
            var cantidadObjetivos = _rand.Next(1, 4);

            for (int i = 0; i < cantidadObjetivos; i++)
            {
                EEObjetivo bObjetivo;
                bObjetivo = new EEObjetivo(
                    0, //No va a ser usado
                    _nombres[_rand.Next(_nombres.Length)],
                    _rand.Next(1, 200),
                    _rand.Next(1, 100),
                    true
                );
                _mppObjetivo.Alta_Objetivo(bObjetivo);
            }

            return _mppObjetivo.ListarObjetivo();
        }

        public void DispararObjetivo(BindingList<EEObjetivo> objetivos)
        {
            var cantidadObjetivos = _rand.Next(1, 4);

        }
    }
}
