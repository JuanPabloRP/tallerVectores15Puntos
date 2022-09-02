using System;


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
                            punto8();
                            break;
                        case 9:
                            punto9();
                            break;
                        case 10:
                            punto10();
                            break;
                        case 11:
                            punto11();
                            break;
                        case 12:
                            punto12();
                            break;
                        case 13:
                            punto13();
                            break;
                        case 14:
                            punto14();
                            break;
                        case 15:
                            punto15();
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
            int num = 0, i = 0;
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

            } while ((i < vector.Length) || !(int.TryParse(dato, out num)));

            return vector;
        }

        static void imprimirVector(int[] vector)
        {
            Console.WriteLine();
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "\t");
            }
            Console.WriteLine();
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
            for (int i = 2; i <= 200; i += 2)
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
            int[] vector = new int[20];
            vector = llenarVectorNumeroNoRepetidos(vector);
            (mayor, pos) = mayorValorYPosicion(vector);
            prom = PromedioVecEntero(vector);

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

        static double PromedioVecEntero(int[] vector)
        {
            double prom = 0;
            
            for (int i = 0; i < vector.Length; i++)
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


        /*8. Se  tiene  un  vector  con las  notas  de  un  grupo  de  30 estudiantes. Hallar y mostrar la nota
        más alta y la más baja, cuántas personas perdieron  y la nota promedio del grupo.  */
        
        static void punto8()
        {
            double[] notas = new double[30];
            double prom = 0;


            for (int i = 0; i < notas.Length; i++)
            {
                Random nota = new Random();
                notas[i] = (nota.Next(0,50) / 10.0);
            }

            notaAltaYNotaBaja(notas);

            prom = promedioVectorDouble(notas);

            imprimirVectorDouble(notas);

        }

        static void notaAltaYNotaBaja(double[] vector)
        {
            double notaAlta = 0, notaBaja = 0;
            int cantPersonasPerdieron = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > notaAlta) 
                {
                    notaAlta = vector[i];
                }

                if (vector[i] < notaBaja)
                {
                    notaBaja = vector[i];
                }

                if (vector[i] < 3)
                {
                    cantPersonasPerdieron++;    
                }

            }


            Console.WriteLine("La nota más alta es: " + notaAlta + "\nLa nota más baja es: " + notaBaja);
            Console.WriteLine("Cantidad de personas que perdieron: " + cantPersonasPerdieron);

        }

        static double promedioVectorDouble(double[] vector)
        {
            double prom = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                prom += vector[i];
            }
            prom /= vector.Length;

            return prom;
        }

        static void imprimirVectorDouble(double[] vector)
        {
            Console.WriteLine("Las notas fueron: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "\t");
            }
        }


        /*9. Crear 2 vectores de "N" posiciones cada uno. Con el resultado de la multiplicación de
        elemento por elemento entre cada  vector, formar otro arreglo; muestre posteriormente, los
        elementos  del vector resultante.*/

        //no se entiende si es v1[0] * v2[0]   v1[1] * v2[1] ó v1[0] * v2[0] + v1[0] * v2[1] + v1[0] * v2[2] etc.
        static void punto9()
        {
            int[] v1, v2, v3;
            int n = 0;

            n = elegirTam();
            v1 = new int[n];
            Console.WriteLine("\nLlenando v1: ");
            v1 = llenarVector(v1);
            v2 = new int[n];
            Console.WriteLine("\nLlenando v2: ");
            v2 = llenarVector(v2);
            v3 = new int[n];

            for(int i = 0; i < v3.Length; i++)
            {
                v3[i] = v1[i] * v2[i];
            }

            Console.WriteLine("\nv1: ");
            imprimirVector(v1);

            Console.WriteLine("\nv2: ");
            imprimirVector(v2);

            Console.WriteLine("\nVector resultante: ");
            imprimirVector(v3);


        }


        /*10. Cargar 2 vectores, uno con los códigos de los estudiantes que perdieron C, el segundo con los
        códigos de los estudiantes que perdieron  Java.   Se pide crear otro arreglo formado  por  los
        códigos   de  los  estudiantes  que  perdieron  ambas   materias.  Mostrar el arreglo resultante.*/

        static void punto10()
        {
            int[] v1;
            int[] v2;
            int[] v3;

            int tamV3 = 0, i = 0;

            Console.WriteLine("Creando y llenando el vector de los que perdieron C");
            v1 = crearVector();

            Console.WriteLine("Creando y llenando el vector de los que perdieron Java");
            v2 = crearVector();


            Console.WriteLine();
            for (i = 0; i < v1.Length; i++)
            {
                Console.WriteLine("Código de estudiante que perdió C: " + v1[i]);
            }

            Console.WriteLine("\n");

            for (i = 0; i < v2.Length; i++)
            {
                Console.WriteLine("Código de estudiante que perdió Java: " + v2[i]);
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

                Console.WriteLine("\nLa cantidad de estudiantes que perdieron C y Java son: " + v3.Length);
                Console.WriteLine("\n ");
                for (i = 0; i < v3.Length; i++)
                {
                    Console.WriteLine("El código del estudiante es: " + v3[i]);
                }
            }


        }

        static int[] crearVector()
        {

            int[] vector;

            int num = 0, aux = 0, i = 0, tam = 0;
            string datoTam = "", dato = "";
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


        /*
         11. Lea  un vector S de N elementos e inviértalo. Utilice  otro Vector. S 14 12 6 25 34 23 5      SI  5 23 34 25 6 12 14
         */
        static void punto11()
        {
            string[] vector;
            string[] vectorInv;
            string dato = "";
            int cont = 0, i = 0, tam = 0;

            tam = definirTam();

            vector = new string[tam];
            vectorInv = new string[tam];

            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese un dato en posicion " + (i + 1) + ": ");
                dato = Console.ReadLine();

                if ((dato.Length > 0 && dato != "" && dato != null) && (i < vector.Length))
                {

                    vector[i] = dato;
                    i++;
                }
                else
                {
                    Console.WriteLine("Ingrese un dato valido");
                }



            } while ((dato.Length > 0 || dato != "" || dato != null) && (i < vector.Length));



            cont = 0;
            for (i = (vector.Length - 1); i >= 0; i--)
            {
                vectorInv[cont] = vector[i];
                cont++;
            }

            Console.WriteLine("\nEl vector es: ");
            for (i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "\t");

            }
            Console.WriteLine();

            Console.WriteLine("\nEl vector invertido es: ");
            for (i = 0; i < vectorInv.Length; i++)
            {
                Console.Write(vectorInv[i] + "\t");

            }
            Console.WriteLine();
        }

        static int definirTam()
        {
            string dato;
            int tam = 0;

            Console.WriteLine();
            do
            {
                Console.WriteLine("Ingrese el tamaño del vector: ");
                dato = Console.ReadLine();

                if (!(int.TryParse(dato, out tam) && tam > 0))
                {
                    Console.WriteLine("Ingrese un dato valido");
                }


            } while (!(int.TryParse(dato, out tam) && tam > 0));

            return tam;
        }


        /*12. Se  tiene  un  vector  de  365  elementos,  cada   elemento corresponde a la estación para ese
        día (V ‐ Verano,  I‐ Invierno, O ‐ Otoño, P ‐ Primavera). Calcular el número de días de verano
        durante el año.*/

        static void punto12()
        {
            char[] posibilidades = {'V', 'I', 'O', 'P'};
            char[] estaciones = new char[365];
            int diasVerano = 0;

            for (int i = 0; i<estaciones.Length; i++)
            {
                Random opc = new Random();
                estaciones[i] = posibilidades[opc.Next(4)];
            }

            for (int i = 0; i < estaciones.Length; i++)
            {
                if (estaciones[i] == 'V')
                {
                    diasVerano++;
                }
            }

            Console.WriteLine("Los días que habrán de verano durante el año serán: " + diasVerano);

        }


        /*13. Elabore un algoritmo que lea un vector de N elementos. Si el número de elementos es par
        intercambiar el elemento i‐ésimo por el elemento i‐ésimo+1. Mostrar el vector final. Si el
        número de elementos es impar, indicarlo en un mensaje que no es posible hacer el
        intercambio y forzar al usuario hasta que digite un número de elementos par.  
        */

        static void punto13() {
            int tam = 0, aux;
            int[] vector;

            tam = verificarTam();

            vector = new int[tam];
            Console.WriteLine("Llenando vector: ");
            vector = llenarVector(vector);

            Console.WriteLine("\nVector antes: ");
            imprimirVector(vector);

            for (int i = 0; i < vector.Length; i+=2)
            {
                aux = vector[i];
                vector[i] = vector[i + 1];
                vector[i + 1] = aux;
            }

            Console.WriteLine("\nVector después: ");
            imprimirVector(vector);


        }

        static int verificarTam()
        {
            string dato = "";
            int n = 0;
            bool ok = false;

            do
            {
                Console.WriteLine("Ingrese el tamaño del vector: ");
                dato = Console.ReadLine();

                if (int.TryParse(dato, out n))
                {

                    if (n > 0 && (n % 2 == 0))
                    {
                        ok = true;
                    }
                    else
                    {
                        Console.WriteLine("Error, ingrese un número entero par, mayor a cero");
                    }

                }
                else
                {
                    Console.WriteLine("Error, ingrese un número entero par, mayor a cero");
                }


            } while (ok == false || !(int.TryParse(dato, out n))  );

            return n;
        }



        /*14. Teniendo un vector de 144  elementos numéricos enteros diferentes, realice lo siguiente:
        ‐ Buscar el elemento mayor y en qué posición lo encontró.  
        ‐ Sumar  los  elementos almacenados en las  posiciones  pares  y mostrar la suma.
        ‐ Buscar cuántos elementos del vector son mayores de 80 y menores de 120.
        ‐ Hallar cuántos  elementos  del vector son múltiplos de 7.  
        ‐ Mostrar los elementos del vector de forma inversa.
        */

        static void punto14()
        {
            int[] vector = new int[144];
            int mayor = 0, pos = 0, cantMultiplos7;

            vector = llenarVectorNumeroNoRepetidos(vector);
            (mayor, pos) = mayorValorYPosicion(vector);
            Console.WriteLine("Numero mayor: " + mayor + " \nEn posición: " + pos);
            sumaPosiPares(vector);
            ElementsM80Ym120(vector);
            cantMultiplos7 =  multiplos(vector, 7);
            Console.WriteLine("Cantidad de elementos multiplos de 7: " + cantMultiplos7);

            Console.WriteLine("\nVector normal: ");
            imprimirVector(vector);

            Console.WriteLine();
            imprimirVectorAlReves(vector);

        }

        static int[] llenarVectorNumeroNoRepetidos(int[] vector, int min = 0, int max = 500)
        {


            int i = 0, num = 0, aux = 0;
            bool numRepetido;

            /*
            if (min > max)
            {
                aux = min;
                min = max;
                max = aux;
            }else if (min == max)
            {
                return null;
            }
            */
            

            while (i < vector.Length)
            {
                numRepetido = false;
                Random n = new Random();
                num = n.Next(min, max);

                for (int j = 0; j < i; j++)
                {
                    if (vector[j] == num)
                    {
                        numRepetido = true;
                    }
                }


                if(numRepetido == false)
                {
                    vector[i] = num;
                    i++;
                }
                
            }

            return vector;

        }

        static void sumaPosiPares(int[] vector)
        {
            int i = 0, suma = 0;
            while (i < vector.Length)
            {
                suma += vector[i];
                i+=2;
            }
            Console.WriteLine("Suma de los elementos en posiciones pares: " + suma);
        }


        static void ElementsM80Ym120(int[] vector)
        {
            int cantElementsM80Ym120 = 0, i = 0;

            do
            {

                if (vector[i] > 80 && vector[i] < 120)
                {
                    cantElementsM80Ym120++;
                }

                i++;
            } while (i < vector.Length);

            Console.WriteLine("El total de elementos mayores a 80 y menores a 120 son: " + cantElementsM80Ym120);
        }

        static int multiplos(int[] vector, int num)
        {
            int cantMultiplos = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] % num == 0)
                {
                    cantMultiplos++;
                }
            }
            return cantMultiplos;
        }


        /*
         15. Se tiene un vector de 125 elementos con  valores  numéricos, realice lo siguiente:
        ‐ Hallar y mostrar el valor promedio del vector.
        ‐ Leer  un  valor x  y   buscar  en  que posición  del  vector  se encuentra.  
        ‐ Llene un vector con los elementos de las posiciones impares.
        ‐ Busque cuántos elementos del vector son múltiplos de 3 y positivos.
         */

        static void punto15()
        {
            int[] vector = new int[125];
            double prom = 0, cantMult3 = 0;

            vector = llenarVectorNumeroNoRepetidos(vector, 0, 150);

            Console.WriteLine("\nVector original");
            imprimirVector(vector);


            prom = PromedioVecEntero(vector);
            Console.WriteLine("\nEl promedio es: " + prom + "\n");
            encontrarElement(vector);
            llenarVectorConPosicionesImpares(vector);
            cantMult3 = multiplos(vector, 3);
            Console.WriteLine("\nCantidad de numeros multiplos de 3: " + cantMult3);
        }

        static void encontrarElement(int[] vector)
        {
            int num = 0, pos = 0;
            string dato = "";
            bool encontrado = false;
            do {
                Console.WriteLine("Ingrese el numero a buscar: ");
                dato = Console.ReadLine();

                if (int.TryParse(dato, out num))
                {
                    for (int i = 0; i < vector.Length; i++)
                    {
                        if (vector[i] == num)
                        {
                            encontrado = true;
                            pos = i;
                            break;
                        }
                        
                    }


                }
                else
                {
                    Console.WriteLine("Ingrese un numero entero a buscar");
                }

                if (encontrado == true)
                {
                    Console.WriteLine("Número: " + num + " encontrado en posicion: " + pos);
                }
                else
                {
                    Console.WriteLine("Número: " + num + " no encontrado");
                }


            } while (encontrado == false || !(int.TryParse(dato, out num)));

        }

        static void llenarVectorConPosicionesImpares(int[] vector)
        {
            
            for (int i = 0; i < (vector.Length- 1); i+=2)
            {
                vector[i] = vector[i + 1];
            }
            Console.WriteLine("\nVector llenado con los elementos de la posiciones impares: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "\t");
            }
            Console.WriteLine();

        }

    }
}


