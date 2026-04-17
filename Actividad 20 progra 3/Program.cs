using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_20_progra_3
{
    internal class Program
    {
        class Paciente

        {

            private string nombre;

            public string Nombre

            {
                get

                {

                    return nombre;

                }

                set

                {

                    if(value.Length>=3)

                    {
                        nombre = value;


                    }

                    else

                    {

                        Console.WriteLine("El nombre debe tener al menos tres carácteres");

                    }



                }


            }







        }








        static void Main(string[] args)
        {
        }
    }
}
