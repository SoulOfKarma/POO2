using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CollecionPreservativo : List<Preservativo>
    {
        public string Imprimir()
        {
            string aux = " ";

            foreach (var item in this)
            {
                if (item.GetType().Equals(typeof(Condon)))
                {
                    aux = aux + ((Condon)item).ObtenerInformacion();

                }
                else if (item.GetType().Equals(typeof(Pastilla)))
                {
                    aux = aux + ((Pastilla)item).ObtenerInformacion();
                }
            }
            return aux;
        }

        public int SonConsultorio()
        {
            var contador = from p in this where p.EsConsultorio == true select p;

            return contador.Count();
        }

        public int MasdeTresCondones()
        {
            var condon = from c in this
                         where c.GetType().Equals(typeof(Condon))
                         select c;

            var cantidad = from ca in condon where ((Condon)ca).Cantidad >= 3
                           select ca;

            return cantidad.Count();
        }

        public List<Condon> ListaCon()
        {
            List<Condon> cond = new List<Condon>();
            foreach (var item in this)
            {
                if (item.GetType().Equals(typeof(Condon)))
                {
                    cond.Add((Condon)item);
                }

               
            }
            return cond;
        }

        public List<Pastilla> ListaPas()
        {
            List<Pastilla> past = new List<Pastilla>();
            foreach (var item in this)
            {
                if (item.GetType().Equals(typeof(Pastilla)))
                {
                    past.Add((Pastilla)item);
                }
            }
            return past;
            
        }

    }
}
