using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;

namespace BLL
{
    public class BLLBaseMilitar
    {
        private Random _rand = new Random();
        private MPPObjetivo _mppObjetivo = new MPPObjetivo();
        private MPPLogDisparo _mppLogDisparo = new MPPLogDisparo();
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

        public bool DispararArma(EEObjetivo objetivo, EEArma arma)
        {
            if (_rand.Next(1, 100) <= objetivo.ProbabilidadAcierto)
            {
                _mppObjetivo.BajaObjetivo(objetivo);
                EELogDisparo oLogDisparo = new EELogDisparo(0, objetivo.Id, arma.ToString(), true);
                _mppLogDisparo.Alta_LogDisparo(oLogDisparo);

                return true;
            }
            else
            {
                EELogDisparo oLogDisparo = new EELogDisparo(0, objetivo.Id, arma.ToString(), false);
                _mppLogDisparo.Alta_LogDisparo(oLogDisparo);
                return false;
            }
        }
    }
}
