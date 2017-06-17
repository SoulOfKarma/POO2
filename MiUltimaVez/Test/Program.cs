using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CollecionPreservativo preservativos = new CollecionPreservativo();

                Condon condonsito = new Condon("Condorito",Marca.AFierroPelao,false,1,DateTime.Now);
                Pastilla pastillita = new Pastilla();
                pastillita.Nombre = "No fake";
                pastillita.Marca = Marca.ACotol;
                pastillita.EsConsultorio = true;
                pastillita.Caducidad = new DateTime(2018,5,4);
                pastillita.Ciclo = 28;

                preservativos.Add(condonsito);
                preservativos.Add(pastillita);

                Console.WriteLine(preservativos.Imprimir());

                Console.WriteLine("Son de consultorio "+preservativos.SonConsultorio());

                

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error ",ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error ", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error ", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
