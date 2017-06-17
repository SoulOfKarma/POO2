using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Preservativo
    {
        bool esConsultorio;
        string nombre;
        Marca marca;

        

        public bool EsConsultorio
        {
            get
            {
                return esConsultorio;
            }

            set
            {
                esConsultorio = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public Marca Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        private void Init()
        {
            this.esConsultorio = false;
            this.nombre = string.Empty;
            this.marca = Marca.NoInformado;
        }

        public Preservativo() { Init(); }


        public Preservativo(bool esConsultorio, string nombre, Marca marca)
        {
            this.esConsultorio = esConsultorio;
            this.nombre = nombre;
            this.marca = marca;
        }

        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Nombre {0}", Nombre));
            sb.AppendLine(string.Format("Marca {0}", Marca));
            sb.AppendLine(string.Format("Es de Consultorio {0}", EsConsultorio?"Si":"No"));
            return sb.ToString();
        }

        public override string ToString()
        {
            return ObtenerInformacion();
        }

    }
}
