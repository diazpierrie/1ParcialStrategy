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
    public class MPPLogDisparo
    {
        public bool Alta_LogDisparo(EELogDisparo LogDisparo)
        {
            Acceso Datos = new Acceso();
            Hashtable Hdatos = new Hashtable();
            bool Resultado;
            string consulta = "SP_LogDisparo_Alta";

            Hdatos.Add("@Id_Objetivo", LogDisparo.Id_Objetivo);
            Hdatos.Add("@Arma", LogDisparo.Arma);
            Hdatos.Add("@FueAcierto", LogDisparo.FueAcierto);

            Resultado = Datos.Escribir(consulta, Hdatos);
            return Resultado;
        }

        public List<EELogDisparo> ListarLogDisparo()
        {
            Acceso Datos = new Acceso();
            DataSet ds = new DataSet();

            List<EELogDisparo> LLogDisparos = new List<EELogDisparo>();

            ds = Datos.Leer("SP_LogDisparo_Leer", null);

            if (ds.Tables[0].Rows.Count > 0)
            {
                EELogDisparo eLogDisparo;
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    eLogDisparo = new(
                        Convert.ToInt16(fila["Id"]),
                        Convert.ToInt16(fila["Id_Objetivo"]),
                        fila["Arma"].ToString(),
                        Convert.ToBoolean(fila["FueAcierto"]));
                    LLogDisparos.Add(eLogDisparo);
                }
            }
            return LLogDisparos;
        }
    }
}
