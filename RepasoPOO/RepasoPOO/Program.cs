using System;
namespace RepasoFundamentos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            string[] listaCanciones1 = ListaCanciones();
            MostrarLista(listaCanciones1);
        }

        static void Menu()
        {
            int numeroPunto = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el número del punto que desea ver");
                Console.WriteLine("Ingrese 1 para acceder al primer punto"); //LISTO COMPLETO
                Console.WriteLine("Ingrese 2 para acceder al segundo punto");//PROBAR
                Console.WriteLine("Ingrese 3 para acceder al tercer punto");//LISTO
                Console.WriteLine("Ingrese 4 para acceder al cuarto punto");//LISTO
                Console.WriteLine("Ingrese 5 para acceder al quinto punto"); //SEGUNDO ENUNCIADO SIN HACER
                Console.WriteLine("Ingrese 6 para acceder al sexto punto (NO ENTRAR, NO COMPLETO)"); //1/2
                numeroPunto = Int32.Parse(Console.ReadLine());
                switch (numeroPunto)
                {
                    //Funciones con cada punto
                    case 1:
                        Fibonacci();
                        break;
                    case 2:
                        Llamadas();
                        break;
                    case 3:
                        VectoresPunto3();
                        break;
                    case 4:
                        MenuEnunciados4();
                        break;
                    case 5:
                        MenuPuntosMatrices();
                        break;
                    case 6:
                        ListaCanciones();
                        break;
                    default:
                        Console.WriteLine("Ingrese un número correcto");
                        break;
                }
            }
            while (numeroPunto <= 0 || numeroPunto > 6);
        }

        static void Fibonacci() //case 1
        {
            Console.Clear();
            //Variables 
            int tamañoFibonacciArray = 0;
            int[] fibonacciArray;
            int acumulador = 0;
            Console.WriteLine("Ingrese el tamaño en el que desea su lista de Fibonacci");
            tamañoFibonacciArray = Int32.Parse(Console.ReadLine());
            Console.Clear();
            //Inicializando el array de Fibonacci
            fibonacciArray = new int[tamañoFibonacciArray];
            for (int i = 0; i < fibonacciArray.Length;i++)
            {
                acumulador = i;
                acumulador += i;
                Console.WriteLine(acumulador);
            }

        }

        static void Llamadas() //case 2
        {
            Console.Clear();
            //Pseudocódigo
            //1: Preguntarle al usuario la cantidad de minutos de su llamada
            //Condicional
            //Menor o igual a 3 minutos = Precio igual a 0.50
            //Mayor a 3 minutos = condicional
            //Variable int cantidadMinutosExtra = cantidadMinutos - 3
            //Variable int precio = cantidadMinutosExtra * 0.50

            //Código
            //Variables
            int cantidadMinutos = 0;
            Console.WriteLine("Ingrese la cantidad de minutos que fueron su llamada");
            cantidadMinutos = Int32.Parse(Console.ReadLine());
            if (cantidadMinutos <= 3)
            {

                Console.WriteLine("El precio de su llamada es de 0.50");
            }
            else
            {
                int cantidadMinutosExtra = cantidadMinutos - 3;
                double precio = cantidadMinutosExtra * 0.50;
                double finalPrecio = precio + 0.50;
                Console.WriteLine($"El precio de su llamada es {finalPrecio}");
            }
        }

        static void VectoresPunto3() //case 3
        {
            Console.Clear();
            //Declaración de variables
            int[] vectorcito; //El array usado para que el usuario ingrese la cantidad 
            int cantidadNumeros = 0; //Tamaño del vector asignado por el usuario
            int numeros = 0; //Numeros puestos en cada posición del vector, que pueden solo ser positivos
            string verArray = ""; //Variable para preguntarle al usuario si desea ver el array después de haberlo ingresado
            Console.WriteLine("Ingrese la cantidad de casillas para el vector");
            cantidadNumeros = Int32.Parse(Console.ReadLine());
            vectorcito = new int[cantidadNumeros]; //Inicializando el vector
            for (int i = 0; i < vectorcito.Length;)
            {
                //Creando los datos del vector
                Console.WriteLine($"Ingrese un numero positivo y entero para la posición {i + 1}");
                numeros = Int32.Parse(Console.ReadLine());
                vectorcito[i] = numeros;
                if (numeros < 0)
                {
                    Console.WriteLine("El número debe ser positivo");
                    Console.Clear();
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("¿Desea ver los datos del array?");
            Console.WriteLine("En el caso de que sí, seleccione 1");
            Console.WriteLine("Ingrese otro número para volver al menú");
            verArray = Console.ReadLine();
            if (verArray == "1")
            {
                for (int i = 0; i < vectorcito.Length; i++)
                {
                    Console.WriteLine($"El vector en la posición {i+1} es {vectorcito[i]}");
                }
            }
            else
            {
                Menu();
            }
        }
        static void MenuEnunciados4 () //Case 4
        {
            Console.Clear();
            //Variables
            string opcionesPunto4 = "";
            Console.Clear();
            Console.WriteLine("Ingrese 1 para ver el primer enunciado del punto 4");
            Console.WriteLine("Ingrese 2 para ver el segundo enunciado del punto 4");
            Console.WriteLine("Ingrese otra letra si desea volver al menú principal");
            opcionesPunto4 = Console.ReadLine();
            if (opcionesPunto4 == "1")
            {
                Ciclos();
            }
            else if (opcionesPunto4 == "2")
            {
                CiclosSegundoEnunciado();
            }
            else
            {
                Menu();
            }
        }

        static void Ciclos() //Case 4.1
        {
            Console.Clear();
            //Ciclos Anidados
            int[] numerosFila1 = new int[9];
            int[] numerosFila2 = new int [9];
            int[] numerosFila3 = new int [9];
            int num = 1;
            int numFila3 = 1;
            for (int i = 0; i < numerosFila1.Length; i++)
            {
                numerosFila1[i] = i+1;
                for (int j = 0; j < numerosFila2.Length; j++)
                {
                    //numerosFila2[j] = j;
                    if (j < 3)
                    {
                        num = 1;
                    } else if (j >= 3 && j < 6)
                    {
                        num = 2;
                    }
                    else
                    {
                        num = 3;
                    }
                        numerosFila2[j] = num;
                    for (int k = 0; k < numerosFila3.Length;k++)
                    {
                        //numerosFila3[k] = k+1;
                        //if (numerosFila3[k] == 3)
                        //{
                        //    numerosFila3[k] = 1;
                        //}
                        numerosFila3[k] = numFila3;
                        numFila3++;
                        if (numerosFila3[k] >= 3)
                        {
                            numFila3 = 1;
                        }
                    }
                }
            }
            //Mostrando los ciclos
            for (int i = 0; i < numerosFila1.Length; i++)
            {
                Console.WriteLine($"{numerosFila1[i]},{numerosFila2[i]},{numerosFila3[i]}");
            }
        }
        static void CiclosSegundoEnunciado() //Case 4.2
        {
            Console.Clear();
            //Declarando variables
            int numero = 25;
            Console.WriteLine("Numeros terminados en 6 desde el 25 hasta el 205");
            do
            {
                if (numero % 10 == 6)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }
            while (numero < 205) ;
        }
        static void MenuPuntosMatrices() //Case 5
        {
            Console.Clear();
            //Variables locales para asignar los números en el submenú
            string opcionesMenuCase5 = "";
            Console.WriteLine("Ingrese 1 para ir al primer enunciado de matrices(PROBAR)");
            Console.WriteLine("Ingrese 2 para ir al segundo enunciado de matrices (PROBAR, IMPORTANTE)");
            Console.WriteLine("Ingrese 3 para volver al menú principal");
            opcionesMenuCase5 = Console.ReadLine();
            if (opcionesMenuCase5 == "1")
            {
                OperacionesMatrices1();
            }
            else if(opcionesMenuCase5 == "2")
            {
                OperacionesMatrices2();
            }
            else
            {
                Menu();
            }
        }

        static void OperacionesMatrices1() //Case 5.1
        {
            Console.Clear();
            Console.WriteLine("Implementar un programa que sume dos matrices y multiplique dos matrices");
            //Declarando matrices 
            int[,] matriz1;
            int[,] matriz2;
            //Variable que se preguntan al usuario
            int tamañoMatriz = 0;
            int numeros1 = 0;
            int numeros2 = 0;
            Console.WriteLine("Ingrese el tamaño como desee la matriz");
            tamañoMatriz = Int32.Parse(Console.ReadLine());
            matriz1 = new int[tamañoMatriz,tamañoMatriz];
            matriz2 = new int[tamañoMatriz,tamañoMatriz];
            Console.Clear();
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el número para la posición {i},{j} de la primera matriz");
                    numeros1 = Int32.Parse(Console.ReadLine());
                    matriz1[i,j] = numeros1;
                    Console.WriteLine($"Ingrese el número para la posición {i},{j} de la segunda matriz");
                    numeros2 = Int32.Parse(Console.ReadLine());
                    matriz2[i,j] = numeros2;
                }
            }
            //Suma de las matrices
            int[,] sumaMatrices = new int[tamañoMatriz, tamañoMatriz];
            int[,] multiplicacionMatrices = new int[tamañoMatriz, tamañoMatriz];
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    sumaMatrices[i,j] = matriz1[i,j] + matriz2[i,j];
                    Console.WriteLine("La suma de las matrices es:");
                    Console.WriteLine(sumaMatrices[i,j]);
                    //Multiplicaciones matrices
                    multiplicacionMatrices[i, j] = matriz1[i, j] * matriz2[i, j];
                    Console.WriteLine("La multiplicación de las matrices es:");
                    Console.WriteLine(multiplicacionMatrices[i,j]);
                }
            }
        }

        static void OperacionesMatrices2() //Case 5.2
        {
            Console.Clear();
            //Segundo Punto de matrices
            //Variables 
            string vendedores; //Variable que se usa para ingresar la columna de los vendedores
            string totalVentasPrecio; //Dato que llenas en la matriz
            string[] filasVendedores; //Columna de los vendedores
            string[] columnasAños; 
            string[,] matrizVentas; //Matriz donde están las ventas
            string[,] matrizInfoTotal; //Matriz donde en la primera columna se muestren los vendedores, y en la primera fila se muestren los años
            int añoInicial = 0;
            int añoActual = 0;
            int cantidadVendedores;
            Console.WriteLine("Ingrese el año inicial de las ventas");
            añoInicial = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año actual de las ventas");
            añoActual = Int32.Parse(Console.ReadLine());
            int cantidadAñosVentas = añoActual - añoInicial;
            columnasAños = new string[cantidadAñosVentas];
            Console.WriteLine("Ingrese la cantidad de vendedores");
            cantidadVendedores = Int32.Parse(Console.ReadLine());
            filasVendedores = new string[cantidadVendedores];
            matrizVentas = new string[cantidadVendedores, cantidadAñosVentas];
            //Array que llena los vendedores
            for (int i = 0; i < filasVendedores.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Ingrese el vendedor {i+1}");
                vendedores = Console.ReadLine();
                filasVendedores[i] = vendedores;
            }
            //Array años
            for (int i = 0; i < columnasAños.Length; i++)
            {
                columnasAños[i] = añoInicial.ToString();
                añoInicial++;
            }
            //Matriz con la cantidad de ventas
            for (int i = 0; i < matrizVentas.GetLength(0); i++)
            {
                for (int j = 0; j < matrizVentas.GetLength(1); j++)
                {
                    Console.Clear();
                    Console.WriteLine($"Ingrese la cantidad de ventas hechas por el vendedor {filasVendedores[i]} en el año {columnasAños[j]}");
                    totalVentasPrecio = Console.ReadLine();
                    matrizVentas[i, j] = totalVentasPrecio;
                }
            }
            matrizInfoTotal = new string[cantidadVendedores+1, cantidadAñosVentas + 1];
            for (int i = 1; i < matrizInfoTotal.GetLength(0); i++)
            {
                for (int j = 1; j < matrizInfoTotal.GetLength(1); j++)
                {
                    matrizInfoTotal[0, 0] = "";
                    matrizInfoTotal[i, 0] = filasVendedores[i - 1];
                    matrizInfoTotal[0, j] = columnasAños[j - 1];
                    matrizInfoTotal[i, j] = matrizVentas[i-1, j-1];

                }
            }
            //ARRAY CON SUMA DE VENTAS IMPORTANTE
            int verInfoVentas = 0;
            Console.WriteLine("¿Desea ver la información de las ventas?");
            Console.WriteLine("Ingrese 1 para ver la información");
            verInfoVentas = Int32.Parse(Console.ReadLine());
            if (verInfoVentas == 1)
            {
                Console.Clear();
                Console.WriteLine("La información total de las ventas es:");

                int filas = matrizInfoTotal.GetLength(0);
                int columnas = matrizInfoTotal.GetLength(1);

                // 1️⃣ Encontrar el texto más largo (para ajustar columnas)
                int ancho = 0;
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (matrizInfoTotal[i, j] != null && matrizInfoTotal[i, j].Length > ancho)
                        {
                            ancho = matrizInfoTotal[i, j].Length;
                        }
                    }
                }

                ancho += 4; // Espacio extra entre columnas

                // 2️⃣ Imprimir matriz alineada
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write(matrizInfoTotal[i, j].PadRight(ancho));
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            else 
            {

            }
        }
        static string[] ListaCanciones() //Case 6
        {
            Console.Clear();
            //A través de un array
            //Declaración de variables
            int cantidadCanciones = 0; //Tamaño del array
            string canciones; //Información del array
            int seguirIngresando = 0;
            //1. Ingresar canciones
            Console.WriteLine("Ingrese la cantidad de canciones que desea agregar a esta lista");
            cantidadCanciones = Int32.Parse(Console.ReadLine());
            //Declarando e inicializando el vector 
            string[] listaCanciones = new string [cantidadCanciones];
            Console.Clear();
            for (int i = 0; i < listaCanciones.Length;)
            {
                Console.WriteLine($"Ingrese la canción {i+1}");
                canciones = Console.ReadLine().ToUpper();
                listaCanciones[i] = canciones;
                if (listaCanciones [i] == listaCanciones[i])
                {
                    //Condicional para identificar canciones repetidas antes de preguntar por más canciones
                    Console.WriteLine("La canción ingresada ya se encuentra en la lista");
                }
                else
                {
                    //Se sabe que la canción no es repetida, y que el array no se ha llenado, entonces se suma el contador
                    i++;
                }
                Console.Clear();
                Console.WriteLine("¿Desea ingresar otra canción?");
                Console.WriteLine("Si desea seguir colocando canciones, ingrese el número 0");
                Console.WriteLine("Si no desea seguir ingresando canciones, ingrese el número 1");
                seguirIngresando = Int32.Parse (Console.ReadLine());
                if (seguirIngresando == 0 && i>listaCanciones.Length)
                {
                    Console.WriteLine("Haz llegado a la capacidad máxima de canciones");
                    Console.WriteLine("Entonces serás redirigido al menú de  las canciones");
                    MenucitoCanciones(listaCanciones);
                }
                if (seguirIngresando == 0)
                {
                    //Se continua el ciclo, y el proceso del for
                }
                else
                {
                    MenucitoCanciones(listaCanciones);
                    
                }
            }
            //Modificar lista de canciones
            //Eliminar canciones de lista
            //Mostrar la lista canciones
            //Ascendentemente
            //Descentemente
            //Escribir la lista en un texto plano
            //Cargar una lista de canciones de un archivo de texto plano
            return listaCanciones;
        }
        //Menucito para opciones de modificación de lista
        static void MenucitoCanciones(string[] listacanciones) //Case 6.1 - Menú donde estarán todas las opciones que se le pueden aplicar a la lista
        {
            Console.Clear();
            //Variables que controlan el submenú
            string opcionesLista = "";
            Console.WriteLine("Ingrese el número 1 para eliminar las canciones de la lista");
            Console.WriteLine("Ingrese el número 2 para mostrar la lista de canciones");
            Console.WriteLine("Ingrese el número 3 para actualizar un nombre de la lista de canciones");
            Console.WriteLine("Ingrese otra opción para volver al número inicial");
            opcionesLista = Console.ReadLine();
            switch (opcionesLista)
            {
                case "1":
                    EliminarCanciones();
                    break;
                case "2":
                    MostrarLista(listacanciones);
                    break;
                case "3":
                    ActualizarCanciones();
                    break;
                default:
                    Menu();
                    break;
            }
        }
        static void EliminarCanciones()
        {
            Console.Clear();
            //Variables
            string cancionEliminar = "";
            int posicionPorCambiar = 0;
            Console.WriteLine("Ingrese el nombre de la canción que desea eliminar");
            cancionEliminar = Console.ReadLine();
        }
        static void MostrarLista(string[] listaCanciones1)
        {
            Console.Clear();

            
        }
        static void ActualizarCanciones()
        {
            Console.Clear();
        }
    }
}