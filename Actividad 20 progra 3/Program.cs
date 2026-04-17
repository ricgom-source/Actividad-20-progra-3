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

            private int dpi;

            public int Dpi

            {
                get

                {

                    return dpi;

                }

                set

                {

                    long dpi = value;
               
                    int cantidad = dpi.ToString().Length;

                    if (dpi.ToString().Length == 13)

                    {

                        dpi = value;


                    }

                    else

                    {

                        Console.WriteLine("El número de dpi debe tener 13 carácteres exactos");


                    }



                }


            }


            







        }








        static void Main(string[] args)
        {

          



        }
    }
}
