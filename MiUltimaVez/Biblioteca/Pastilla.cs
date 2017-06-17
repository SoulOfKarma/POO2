using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pastilla : Preservativo, IPreservativo
    {

        int ciclo;
        DateTime caducidad;

     

        public int Ciclo
        {
            get
            {
                return ciclo;
            }

            set
            {
                ciclo = value;
            }
        }

        public DateTime Caducidad
        {
            get
            {
                return caducidad;
            }

            set
            {
                caducidad = value;
            }
        }

        private void Init()
        {
            ciclo = 0;
            caducidad = DateTime.Now;
        }

        

        public Pastilla(bool EsConsultorio,string nombre,Marca marca,int ciclo, DateTime caducidad):base
            (EsConsultorio,nombre,marca)
        {
            Ciclo = ciclo;
            Caducidad = caducidad;
        }

        public Pastilla() : base()
        {
            Init();
        }

        public int CalcularEfectividad()
        {
            return EsConsultorio ? 60 : 99;
        }

        public new string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacion());
            sb.AppendLine(string.Format("Ciclo {0}",Ciclo));
            sb.AppendLine(string.Format("Caducidad {0}", Caducidad));
            return sb.ToString();

        }

        public override string ToString()
        {
            return ObtenerInformacion();
        }
    }
}
