using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;

namespace BLL
{
    public class BLLBaseMilitar
    {
        private Random _rand;
        public void DeterminarArma(int rowIndex, EEBaseMilitar baseMilitar, List<EEArma> estrategiasDisparo, BindingList<EEObjetivo> objetivos)
        {
            if (rowIndex == -1)
            {
                return;
            }

            var oObjetivo = objetivos[rowIndex];

            switch (oObjetivo.Distancia)
            {
                case < 10:
                    baseMilitar.CambiarEstrategia(estrategiasDisparo[0]); //Cañon Corto
                    break;
                case >= 10 and < 50:
                    baseMilitar.CambiarEstrategia(estrategiasDisparo[1]); //Cañon Ultrasonico
                    break;
                case >= 50 and < 200:
                    baseMilitar.CambiarEstrategia(estrategiasDisparo[2]); //Rayo Laser Destructor Bionico
                    break;
            }

        }

        public void DispararArma(EEObjetivo objetivo)
        {
            if (_rand.Next(1, 99) < objetivo.ProbabilidadAcierto)
            {
                MessageBox.Show(@"El enemigo fue destruido");
            }
            else
            {
                MessageBox.Show(@"El disparo ha errado");
            }
        }
    }
}
