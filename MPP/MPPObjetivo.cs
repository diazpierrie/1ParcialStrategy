using EE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EE;

namespace MPP
{
    public class MPPObjetivo
    {
        public bool Alta_Objetivo(EEObjetivo objetivo)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_Objetivo_Alta";

            Hdatos.Add("@Nombre", objetivo.Nombre);
            Hdatos.Add("@Distancia", objetivo.Distancia);
            Hdatos.Add("@ProbabilidadAcierto", objetivo.ProbabilidadAcierto);

            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }

        public bool BajaObjetivo(EEObjetivo objetivo)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            Hdatos.Add("@Cod_Objetivo", objetivo.Id);
            string consulta = "SP_Objetivo_Baja";
            return Resultado = Datos.Escribir(consulta, Hdatos);
        }

        public List<EEObjetivo> ListarObjetivo()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EEObjetivo> LObjetivos = new List<EEObjetivo>();

            ds = Datos.Leer("SP_Objetivo_Leer", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                EEObjetivo eObjetivo;
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    eObjetivo = new(
                        Convert.ToInt16(fila["Id"]),
                        fila["Nombre"]
                            .ToString(),
                        Convert.ToInt16(fila["Distancia"]),
                        Convert.ToInt16(fila["ProbabilidadAcierto"]));
                    LObjetivos.Add(eObjetivo);

                }
            }

            return LObjetivos;
        }
    }
}
