
//Práctica 1: Escoge cual de las siete opciones del menú deseas
//Estudiante: José Pablo Muñoz Zúñiga
//Carrera: Ingeniería Informática
//Materia: Prográmacion II 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Programácion_2_Práctica_1_Menú
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionSeleccionada = 0;
            int x;

            string cedula, nombre, promedio, condicion;
            string[] personaTemporal;

            List<string[]> personas = new List<string[]>();

            while (opcionSeleccionada !=8)
            {

                //En esta parte puedes elegir la opcion que deseas

                Console.WriteLine("1. Inicializar vectores");
                Console.WriteLine("2. Incluir Estudiantes");
                Console.WriteLine("3. Consultar Estudiantes");
                Console.WriteLine("4. Modificar Estudiantes");
                Console.WriteLine("5. Eliminar Estudiantes");
                Console.WriteLine("6. Reporte estudiantes por condicion");
                Console.WriteLine("7. Selecciono reporte de todos los datos");
                Console.WriteLine("8. Salir");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Ingrese una opción que deseas: ");

                string opcionSeleccionadaTemporal = Console.ReadLine();

                if (int.TryParse(opcionSeleccionadaTemporal, out x))
                {
                    opcionSeleccionada = int.Parse(opcionSeleccionadaTemporal);

                    switch (opcionSeleccionada)
                    {
                        case 1:
                            {
                                //Declarar vector
                                double[] notasdelosestudiantes;
                                int n;
                                Console.WriteLine("Cuantos alumnos tiene su seccion?");
                                n = int.Parse(Console.ReadLine());
                                //Asignar longitud del vector
                                notasdelosestudiantes = new double[n];
                                //Llenado de vector
                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine("Ingrese nota para la posicion #" + i);
                                    notasdelosestudiantes[i] = double.Parse(Console.ReadLine());
                                }
                                //Mostrar valores del vector
                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine("  [" + notasdelosestudiantes[i] + "]");
                                }
                                Console.ReadKey();

                            }

                            break;

                        case 2:
                            //En esta parte ingrese la cedula de un estudiante
                            Console.WriteLine("Ingrese la cedula de un estudiante: ");
                            cedula = Console.ReadLine();
                            //En esta parte ingrese el nombre de un estudiante
                            Console.WriteLine("Ingrese el nombre de un estudiante: ");
                            nombre = Console.ReadLine();
                            //En esta parte ingrese el promedio de un estudiante
                            Console.WriteLine("Ingrese el promedio de un estudiante: ");
                            promedio = Console.ReadLine();
                            //En esta árte ingrese la condicion de un estudiante 
                            Console.WriteLine("Ingrese la condicion de un estudiante: ");
                            condicion = Console.ReadLine();

                            if (cedula.Trim() == string.Empty || nombre.Trim() == string.Empty || promedio.Trim() == string.Empty || condicion.Trim() == string.Empty)
                            {

                                Console.WriteLine("Los campos son obligatorios.");
                            }
                            //En esta parte se agrega informacion de cada estudiante
                            else
                            {
                                personaTemporal = new string[4];

                                personaTemporal[0] = cedula;
                                personaTemporal[1] = nombre;
                                personaTemporal[2] = promedio;
                                personaTemporal[3] = condicion;

                                personas.Add(personaTemporal);
                            }



                            break;

                        case 3:
                            Console.WriteLine("----------------Lista de estudiantes----------------");

                            //En esta parte se ve las consultas de los estudiantes

                            foreach (string[] item in personas)
                            {
                                Console.WriteLine(item[0] + " " + item[1] + " " + item[2] + " " + item[3]);
                            }
                            break;

                        case 4:
                            Console.WriteLine("----------------Lista de estudiantes----------------");

                            for (int i = 0; i < personas.Count; i++)
                            {
                                Console.WriteLine(i + " . " + personas[i][0] + " " + personas[i][1] + " " + personas[i][2] + " " + personas[i][3]);
                            }

                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("");

                            //En esta parte se edita la informacion de un estudiante

                            Console.WriteLine("Ingrese al estudiante que quiere editar:");

                            string posicionPersonaTemporal = Console.ReadLine();

                            if (int.TryParse(posicionPersonaTemporal, out x))
                            {
                                int posicionPersona = int.Parse(posicionPersonaTemporal);

                                //En esta parte la persona digitada no existe

                                if (personas.Count <= posicionPersona || posicionPersona < 0 || posicionPersona < 0 || posicionPersona < 0)
                                {
                                    Console.WriteLine("La persona no existe.");
                                }
                                else
                                {
                                    //En esta parte se ingresa una nueva cedula de un estudiante
                                    Console.WriteLine("Ingrese la nueva cedula de un estudiante: ");
                                    cedula = Console.ReadLine();
                                    //En esta parte se ingresa un nuevo nombre de un estudiante
                                    Console.WriteLine("Ingrese el nuevo de un estudiante: ");
                                    nombre = Console.ReadLine();
                                    //En esta parte se ingresa un promedio de un estudiante
                                    promedio = Console.ReadLine();
                                    Console.WriteLine("Ingrese el nuevo promedio de un estudiante: ");
                                    //En esta parte se ingresa la nueva condicion de un estudiante
                                    Console.WriteLine("Ingrese la nueva condicion de un estudiante: ");
                                    condicion = Console.ReadLine();

                                    if (cedula.Trim() == string.Empty || nombre.Trim() == string.Empty || promedio.Trim() == string.Empty || condicion.Trim() == string.Empty)
                                    {
                                        Console.WriteLine("Los campos son obligatorios");
                                    }

                                    //En esta parte la informacion es correcta

                                    else
                                    {
                                        personas[posicionPersona][0] = cedula;
                                        personas[posicionPersona][1] = nombre;
                                        personas[posicionPersona][2] = promedio;
                                        personas[posicionPersona][3] = condicion;

                                        Console.WriteLine("Informacion actualizada correctamente");
                                    }
                                }
                            }

                            //En esta parte se digito un dato incorrecto de un estudiante
                            else
                            {
                                Console.WriteLine("Dato incorrecto");
                            }


                            break;

                        case 5:
                            Console.WriteLine("-------------Lista de Estudiantes--------------");

                            for (int i = 0; i < personas.Count; i++)
                            {
                                Console.WriteLine(i + " . " + personas[i][0] + " " + personas[i][1] + " " + personas[i][2] + " " + personas[i][3]);
                            }

                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("");

                            //En esta parte se elimina permanentemente los datos de un estudiante

                            Console.WriteLine("Ingrese al estudiante que quiere eliminar: ");

                            string posicionPersonaTemporalParaEliminar = Console.ReadLine();

                            if (int.TryParse(posicionPersonaTemporalParaEliminar, out x))
                            {
                                int posicionPersona = int.Parse(posicionPersonaTemporalParaEliminar);

                                if (personas.Count <= posicionPersona || posicionPersona < 0 || posicionPersona < 0 || posicionPersona < 0)
                                {

                                    //En esta parte el estudiante digitado no existe

                                    Console.WriteLine("La persona no existe.");
                                }
                                else
                                {
                                    personas.RemoveAt(posicionPersona);

                                    //En esta parte el estudiante digitado se elimino permanentemente 

                                    Console.WriteLine("Persona eliminada correctamente");
                                }
                            }
                            else
                            {

                                //En esta parte se digito un dato incorrecto de un estudiante

                                Console.WriteLine("Dato incorrecto");
                            }

                            Console.ReadKey();

                            break;

                        case 6:
                            {
                                {
                                    //En esta parte se ingresa la cedula de un estudiante
                                    string cedulasdelosestudiantes = Console.ReadLine();

                                    ceduladelestudiante(cedulasdelosestudiantes);

                                    Console.ReadLine();

                                    //En esta parte se ingresa el nombre de un estudiante
                                    string nombresdelosestudiantes = Console.ReadLine();

                                    nombredelestudiante(nombresdelosestudiantes);

                                    Console.ReadLine();

                                    //En esta parte se ingresa el promedio de un estudiante
                                    string promediosdelosestudiantes = Console.ReadLine();

                                    promediodelestudiante(promediosdelosestudiantes);

                                    Console.ReadLine();

                                    //En esta parte se ingresa la condicion de un estudiante
                                    string condiciondelosestudiantes = Console.ReadLine();

                                    condiciondelestudiante(condiciondelosestudiantes);

                                    Console.ReadLine();
                                }
                                //Metodo: tipo de dato retorno + nombre + parametros

                                //En esta parte se ingreso la cedula de un estudiante
                                void ceduladelestudiante(string cedulasdelosestudiantes)
                                {
                                    Console.WriteLine("La cedula del estudiante es: " + cedulasdelosestudiantes);
                                }

                                //En esta parte se ingreso el nombre de un estudiante
                                void nombredelestudiante(string nombresdelosestudiantes)
                                {
                                    Console.WriteLine("El nombre del estudiante es: " + nombresdelosestudiantes);
                                }

                                //En esta parte se ingreso el promedio de un estudiante
                                void promediodelestudiante(string promediosdelosestudiantes)
                                {
                                    Console.WriteLine("El promedio del estudiante es: " + promediosdelosestudiantes);
                                }

                                //En esta parte se ingreso la condicion de un estudiante
                                void condiciondelestudiante(string condiciondelosestudiantes)
                                {
                                    Console.WriteLine("La condidion del estudiante es: " + condiciondelosestudiantes);
                                }

                                Console.ReadLine();


                            }

                            Console.ReadLine();

                            break;

                        case 7:
                             Console.WriteLine("Selecciono reporte de todos los datos");

                             //Solicite el nombre y las notas de los estudiantes, calcular el promedio de las notas de los estudiantes
                             string[] cedulas = new string[4];
                             string[] estudiantes = new string[4];
                             float[] promedios = new float[4];
                             float condiciones = 0;

                             for (int i = 0; i < estudiantes.Length; i++)
                             {
                                //En esta parte se solicita todos los datos de un estudiante
                                //Ingrese la cedula de un estudiante
                                Console.WriteLine("Digite la cedula de un estudiante: ");
                                //Ingrese el nombre de un estudiante
                                cedulas[i] = Console.ReadLine();
                                Console.WriteLine("Digite el nombre de un estudiante: ");
                                estudiantes[i] = Console.ReadLine();
                                //Ingrese el promedio de un estudiante
                                Console.WriteLine("Digite el promedio de un estudiante: ");
                                promedios[i] = int.Parse(Console.ReadLine());
                                condiciones += promedios[i]; // sumatoria de las notas
                             }

                             condiciones /= promedios.Length; // promedio de las notas
                             Console.WriteLine("El promedio de las notas es: {0}", condiciones);

                             // Averiguar cuantos estudiantes tienen unas notas superior al promedio
                             int contador = 0;

                             //En esta parte se descubre cual es la informacion de cada estudiante y su promedio final
                             for (int i = 0; i < promedios.Length; i++)
                             {
                                 if (promedios[i] > condiciones)
                                 {
                                    contador++;
                                    Console.WriteLine($"Cedulas: {cedulas[i]} Estudiantes: {estudiantes[i]}");
                                 }
                             }

                            //En esta parte se descubre cual estudiante tiene el mayor promedio
                            Console.WriteLine($"{contador} estudiantes con mayor al promedio");
                            Console.Read();

                            Console.ReadLine();

                            break;

                        default:
                            Console.WriteLine("El programa ha finalizado");
                            break;
                    }
                    

                }


                Console.ReadLine();
            }
        }
    }
}
