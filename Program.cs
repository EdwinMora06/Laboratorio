using System;

namespace Laboratorio_Practica
{
    class Programa
    {
        static void Main(string[] args)
        {
            int S = 0;
            int opciones = 5;
            byte op = 0;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            Console.WriteLine("\nBienvenidos al Programa Menu \n");


            while (op != opciones)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-------------------Menu Principal------------------\n");
                Console.WriteLine("1- Captura de Valor\n2- Generar Tabla de Multiplicacion\n3- Determinar SI es Primo o No primo\n4- Desplegar una matriz 4x4: Diagonal Principal y Secuandaria\n5- Salir del Programa\n");
                Console.WriteLine("Elegir una de las opciones del 1-5");

                Console.ForegroundColor = ConsoleColor.Red;
                op = Convert.ToByte(Console.ReadLine());
                switch (op)
                {

                    case 1:
                        Console.WriteLine("Introduzca un valor entero");
                        S = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nPresione cualquier tecla para volver al Menu Principal\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        ProcedimientoTablaMultiplicar(S);
                        break;
                    case 3:
                        ProcedimientoMostrarEvaluacionPrimo(S);
                        break;
                    case 4:
                        ProcedimientoDiagonalesMatriz(S);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Fin del Programa\n\n");
                        break;
                    default:
                        Console.WriteLine("La opcion introducida no es valida\n");
                        Console.WriteLine("Presione cualquier tecla para volver al Menu Principal");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            }
        }
        static void ProcedimientoTablaMultiplicar(int S)
        {
            int V = 0;
            for (V = 1; V <= 12; V++)
            {
                Console.WriteLine(V + " x " + S + " = " + (S * V));
            }
            Console.WriteLine("\nPresione cualquier tecla para volver al Menu Principal\n");
            Console.ReadKey();
            Console.Clear();
        }
        static void ProcedimientoMostrarEvaluacionPrimo(int S)
        {
            int R = 0;
            for (int V = 1; V <= S; V++)
            {
                if (S % V == 0)
                {
                    R = R + 1;
                }
            }
            if (R > 2)
            {
                Console.WriteLine();
                Console.WriteLine("\n" + S + " No es un numero Primo");
            }
            else
            {
                Console.Write("");
                Console.WriteLine("\n" + S + " Es un numero Primo");
            }
            Console.WriteLine("\nPresione cualquier tecla para volver al Menu Principal\n");
            Console.ReadKey();
            Console.Clear();
        }
        static void ProcedimientoDiagonalesMatriz(int S)
        {
            int[,] MatrizNumeros = new int[4, 4];
            int columna;
            int fila;
            for (fila = 0; fila < 4; fila++)
            {
                for (columna = 0; columna < 4; columna++)
                {
                    Console.WriteLine("Ingresa la celda[" + fila + " , " + columna + "]:");
                    MatrizNumeros[fila, columna] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine("\nLa matriz 4x4 es la siguiente:\n");
            for (fila = 0; fila < 4; fila++)
            {
                for (columna = 0; columna < 4; columna++)
                {
                    Console.Write("  " + MatrizNumeros[fila, columna] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n Diagonal Principal\n");
            Console.WriteLine(" " + MatrizNumeros[0, 0]);
            Console.WriteLine("   " + MatrizNumeros[1, 1]);
            Console.WriteLine("     " + MatrizNumeros[2, 2]);
            Console.WriteLine("        " + MatrizNumeros[3, 3]);
            Console.WriteLine();
            Console.WriteLine("Diagonal Secuandaria\n");
            Console.WriteLine("        " + MatrizNumeros[0, 3]);
            Console.WriteLine("      " + MatrizNumeros[1, 2]);
            Console.WriteLine("   " + MatrizNumeros[2, 1]);
            Console.WriteLine(" " + MatrizNumeros[3, 0]);

            Console.WriteLine("\n\nPresione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
