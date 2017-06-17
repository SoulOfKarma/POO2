using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Condon : Preservativo , IPreservativo
    {
        int cantidad;
        DateTime caducidad;

       
        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
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
            cantidad = 0;
            caducidad = DateTime.Now;
        }

       

        public Condon(string nombre,Marca marca,bool EsConsultorio,int cantidad, DateTime caducidad)
            :base(EsConsultorio,nombre,marca)
        {
            Cantidad = cantidad;
            Caducidad = caducidad;
        }

        public Condon() : base() { Init(); }


        public int CalcularEfectividad()
        {
            return EsConsultorio ? 10 : 95;
        }

        public new string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacion());
            sb.AppendLine(string.Format("Cantidad {0}",Cantidad));
            sb.AppendLine(string.Format("Caducidad {0}", Caducidad));
            return sb.ToString();
        }

        public override string ToString()
        {
            return ObtenerInformacion();
        }
    }
}
