using System;

namespace EE
{
    public class EEBaseMilitar
    {
        EEArma _estrategia;

        public void CambiarEstrategia(EEArma estrategia)
        {
            _estrategia = estrategia ?? throw new Exception("La estrategia de disparo no puede ser null");
        }

        public EEArma RetornarEstrategia()
        {
            return _estrategia;
        }
    }
}
