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


            private int telefono;

            public int Telefono

            {

                get

                {
                    return telefono;

                }


                set

                {
                    long telefono = value;

                    int digitos = telefono.ToString().Length;

                    if (telefono.ToString().Length == 13)

                    {

                        telefono = value;


                    }

                    else

                    {

                        Console.WriteLine("El número debe tener 8 dígitos");


                    }


                }

            }

            private int edad;

            public int Edad


            {
                get

                {
                    return edad;


                }

                set

                {
                    if(value>=0)

                    {

                        edad = value;


                    }

                    else

                    {

                        Console.WriteLine("La edad debe ser mayor a cero años");


                    }



                }



            }
            

            public Paciente(string nombre, int dpi, int telefono, int edad)

            {
                this.nombre = nombre;

                this.dpi = dpi;

                this.telefono = telefono;

                this.edad = edad;


            }

            public void Mostrarinfo()

            {
                Console.WriteLine();

                Console.WriteLine("DATOS DEL PACIENTE:");

                Console.WriteLine($"Nombre: {Nombre} ");

                Console.WriteLine();

                Console.WriteLine($"No. de dpi: {Dpi}");

                Console.WriteLine();

                Console.WriteLine($"No. de telefono: +502 {Telefono}");

                Console.WriteLine();

                Console.WriteLine($"Edad: {Edad} años");



            }





        }








        static void Main(string[] args)
        {

          



        }
    }
}
