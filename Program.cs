using System;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace tallerVector15Puntos
{
    class TallerVectores15Puntos
    {
        
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {

            int op = 0;
            string dato = "";


            //Console.WriteLine("\nMenu de opciones: ");
            do
            {
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Ingrese el numero de la opción a la cual desea ir (1 al 15): ");

                Console.WriteLine("-------------------------------------------------------------");
                dato = Console.ReadLine();

                if (int.TryParse(dato, out op))
                {
                    switch (op)
                    {
                        case 1:
                            punto1();
                            break;
                        case 2:
                            punto2();
                            break;
                        case 3:
                            punto3();
                            break;
                        case 4:
                            punto4();
                            break;
                        case 5:
                            punto5();
                            break;
                        case 6:
                            punto6();
                            break;
                        case 7:
                            punto7();
                            break;
                        case 8:
                            //punto3();
                            break;
                        case 9:
                            //punto4();
                            break;
                        case 10:
                            //punto5();
                            break;
                        case 11:
                            //punto1();
                            break;
                        case 12:
                            //punto2();
                            break;
                        case 13:
                            //punto3();
                            break;
                        case 14:
                            //punto4();
                            break;
                        case 15:
                            //punto5();
                            break;

                        default:
                            Console.WriteLine("Error, valor fuera de rango");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error, valor invalido");
                }




            } while ((!(int.TryParse(dato, out op))) || (op < 1 || op > 15));

        }

        /*1. Leer 5 números, crear un vector con ellos y luego mostrar el vector.*/
        static void punto1()
        {
            int[] vector = new int[5];
            Console.WriteLine();
            vector = llenarVector(vector);
            imprimirVector(vector);
            
        }

        static int[] llenarVector(int[] vector)
        {
            int num = 0,  i = 0;
            string dato = "";
            bool ok = false;

            do
            {
                Console.WriteLine("Ingrese num: ");
                dato = Console.ReadLine();

                //se trata de parsear a int
                if (int.TryParse(dato, out num))
                {
                    ok = true;
                    vector[i] = num;
                    
                    i++;
                }
                else
                {
                    Console.WriteLine("Error, Ingrese un numero entero.");
                }

            } while ( (i < vector.Length) || !(int.TryParse(dato, out num) ) );

            return vector;
        }

        static void imprimirVector(int[] vector)
        {
            Console.WriteLine();
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "\t");
            }
        }


        /*2. Realizar un algoritmo que genere los números pares de 2 a  200, llenar un vector con ellos y
        mostrar el vector.*/
        static void punto2()
        {
            int[] vector = new int[100];

            vector = llenarVectorConPares(vector);

            //metodo hecho en el punto 1
            imprimirVector(vector);
        }

        static int[] llenarVectorConPares(int[] vector)
        {
            int j = 0;
            for (int i = 2; i <= 200; i+=2)
            {
                vector[j] = i;
                j++;
            }
            return vector;
        }


        /*3. Llenar un vector con los 10 primeros múltiplos de 3 y luego sume los elementos  del vector.
        Mostrar la suma de los elementos.*/
        static void punto3()
        {
            int[] vector = new int[10];
            //por ahi derecho tambien imprimo el resultado xd
            llenarVectorMult3ySumar(vector);
        }

        static void llenarVectorMult3ySumar(int[] vector)
        {
            int i = 0, suma = 0;
            while (i < vector.Length)
            {
                vector[i] = 3 * (i + 1);
                suma += vector[i];
                i++;
            }
            
            Console.WriteLine("La suma de los 10 primeros multiplos de 3 es: " + suma);
        }

        /*4. Crear un vector de 20 elementos con  valores  numéricos diferentes. Hallar el mayor valor y su
        posición y el valor promedio.*/
        static void punto4()
        {
            int mayor = 0, pos = 0;
            double prom = 0;
            int[] vector = {1,15,84,654,12,67,153,879,156,753,17,51,98,25, 777,456,812,3,58,4};
            (mayor, pos) = mayorValorYPosicion(vector);
            prom = Promedio(vector);

            Console.WriteLine("Vector: ");
            //uso de metodo del punto 1
            imprimirVector(vector);
            Console.WriteLine("\n\nElemento mayor: " + mayor + " en posicion: " + pos + "\nPromedio: " + prom);
        }

        static (int, int) mayorValorYPosicion(int[] vector)
        {
            int i = 0, mayor = -99999999, pos = 0;
            do
            {
                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                    pos = i;
                }
                i++;
            } while (i < vector.Length);
            
            return (mayor, pos);
        }

        static double Promedio(int[] vector)
        {
            double prom = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                prom += vector[i];
            }
            prom /= vector.Length;
            return prom;
        }

        /*5. Leer un vector de N elementos numéricos enteros y posteriormente:
             Mostrar cuántas  veces  se repite el número 10.  
             Sume los elementos de las posiciones pares.
             Muestre los elementos del vector empezando por el último elemento.
        */

        static void punto5()
        {
            int[] vector;
            int n = 0, cantRep10 = 0, sumaPosiPares = 0, i = 0;

            n = elegirTam();
            vector = new int[n];

            vector = llenarVector(vector);

            while(i < vector.Length){
                if (vector[i] == 10)
                {
                    cantRep10++;
                }

                if(i % 2 == 0)
                {
                    sumaPosiPares += vector[i];
                }

                i++;
            }

            Console.WriteLine("Cantidad que se repite el número 10: " + cantRep10 + "\nSuma de elementos en posiciones pares: " + sumaPosiPares);

            imprimirVectorAlReves(vector);
            
        }

        static int elegirTam()
        {
            int num = 0, i = 0, n = 0;
            string dato = "";
            bool ok = false;

            do
            {
                Console.WriteLine("Ingrese el tamaño del vector: ");
                dato = Console.ReadLine();

                //se trata de parsear a int
                if (int.TryParse(dato, out num))
                {
                    n = num;
                }
                else
                {
                    Console.WriteLine("Error, Ingrese un numero entero positivo.");
                }

            } while ((i < 0) || !(int.TryParse(dato, out num)));

            return n;
        }

        static void imprimirVectorAlReves(int[] vector)
        {
            Console.WriteLine("Vector al reves: ");
            for (int i = vector.Length -1; i >= 0; i--)
            {
                Console.Write(vector[i] + "\t");
            }
        }


        /*6. De los 50 elementos de un vector, muestre cuántos son: pares, impares, negativos y positivos*/

        static void punto6()
        {
            int[] vector = {74, -61, 28,-33,49,68,12,-26,-66,-35,-68,-96,-9,-34,-60,96,-31,-78,-49,-18,79,12,-17,12,88,81,65,-63,-85,96,-32,7,-24,-51,-3,-8,94,92,-28,49,-88,25,-82,34,-24,3,9,-28,-57,52};

            elementosParesEImpares(vector);
            elementosNegativosYPositivos(vector);
        
        
        }

        static void elementosParesEImpares(int[] vector)
        {
            int pares = 0, impares = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] % 2 == 0) 
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine("Cantidad de numeros pares: " + pares + "\nCantidad numeros impares: " + impares);
        }

        static void elementosNegativosYPositivos(int[] vector)
        {
            int neg = 0, pos = 0, ceros = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > 0)
                {
                    pos++;
                }
                else if (vector[i] < 0)
                {
                    neg++;
                }
                else
                {
                    ceros++;
                }
            }
            Console.WriteLine("Cantidad de numeros negativos: " + neg + "\nCantidad numeros positivos: " + pos + "\nCantidad de ceros: " + ceros);
        }


        /*7. En vector de 40 elementos numéricos llamado totales, se requiere ir sumando y mostrando
        cada elemento,  siempre  y cuando sea mayor al primer elemento y menor al elemento 25.
        Finalmente, muestre el total de los elementos que fueron sumados.*/
        
        //profe tengo una duda por si ve esto xd: primer elem es 0? y 25 es 25 o 24?

        static void punto7()
        {
            int[] totales = new int[40];
            int suma = 0, cantNSumados = 0;

            for (int i = 0; i < totales.Length; i++)
            {
                Random num = new Random();
                totales[i] = num.Next(1, 50);
            }

            for(int i = 0; i < totales.Length; i++)
            {
                if (totales[i] > totales[0] && totales[i] < totales[25])
                {
                    Console.WriteLine("Elemento: " + totales[i]);
                    suma += totales[i];
                    Console.WriteLine("La suma va en: " + suma);
                    cantNSumados++;
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\nTotal suma: " + suma + "\nY Cantidad de numeros sumados: " + cantNSumados);

            Console.WriteLine("\nEl vector: ");
            imprimirVector(totales);
        }






























        static void interseccionVectores()
        {
            int[] v1;
            int[] v2;
            int[] v3;

            int tamV3 = 0, i = 0;

            Console.WriteLine("Creando y llenando el vector de los que perdieron c");
            v1 = crearVector();
            Console.WriteLine("Creando y llenando el vector de los que perdieron java");
            v2 = crearVector();


            for (i = 0; i < v1.Length; i++)
            {
                Console.WriteLine("Perdió C: " + v1[i]);
            }

            Console.WriteLine("\n");

            for (i = 0; i < v2.Length; i++)
            {
                Console.WriteLine("Perdió Java: " + v2[i]);
            }



            for (i = 0; i < v1.Length; i++)
            {
                for (int j = 0; j < v2.Length; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        tamV3++;
                    }
                }
            }

            v3 = new int[tamV3];
            int k = 0;

            if (tamV3 == 0)
            {
                Console.WriteLine("No existen estudiantes que hayan perdido C y Java");
            }
            else if (tamV3 > 0)
            {
                for (i = 0; i < v1.Length; i++)
                {
                    for (int j = 0; j < v2.Length; j++)
                    {
                        if (v1[i] == v2[j])
                        {
                            v3[k] = v1[i];
                            k++;
                        }
                    }
                }
                
                Console.WriteLine("\nla cantidad de estudiantes que perdieron C y Java son: " + v3.Length);
                Console.WriteLine("\nY los codigos de los estudiantes que perdieron son: \n");
                for (i = 0; i < v3.Length; i++)
                {
                    Console.WriteLine("Código " + v3[i]);
                }
            }


        }

        static int[] crearVector()
        {

            int[] vector;

            int num = 0, aux = 0, i = 0, tam = 0;
            string datoTam = "", dato;
            bool ok = false;
            do
            {
                Console.WriteLine("Ingrese la cantidad de estudiantes que perdieron: ");
                datoTam = Console.ReadLine();

                //se trata de parsear a int
                if (int.TryParse(datoTam, out tam))
                {
                    if (tam > 0)
                    {
                        ok = true;

                    }
                    else

                    {
                        Console.WriteLine("Error, valor fuera de rango");
                    }
                }
                else
                {
                    Console.WriteLine("Error, tipo de dato incorrecto.");

                }
            } while ((tam <= 0) || (!(int.TryParse(datoTam, out tam))));

            vector = new int[tam];

            do
            {

                Console.WriteLine("Ingrese codigo: ");
                dato = Console.ReadLine();

                //se trata de parsear a int
                if (int.TryParse(dato, out num))
                {
                    vector[i] = num;
                    i++;

                }
                else
                {
                    Console.WriteLine("Error, valor ingresado no es un entero.");
                }

            } while (i != vector.Length);

            return vector;

        }



    }
}


