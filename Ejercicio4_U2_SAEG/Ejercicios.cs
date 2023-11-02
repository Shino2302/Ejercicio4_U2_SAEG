using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_U2_SAEG
{
    public class Ejercicios
    {
        public void Ejercicio()
        {
            Random r = new Random();
            //Declaracion de matriz t:
            int[,] t = new int[2, 3];
            //Llenamos de forma aleatorea: 
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    t[i, j] = r.Next(100);
                }
            }
            Console.WriteLine($"La matriz tiene {t.GetLength(0)} filas y {t.GetLength(1)} columnas");
            //Expresiones de acceso de la fila 1:
            Console.WriteLine($"{t[1, 0]}");
            Console.WriteLine($"{t[1, 1]}");
            Console.WriteLine($"{t[1, 2]}");
            //Expresiones de acceso de la columna 2:
            Console.WriteLine($"{t[0, 2]}");
            Console.WriteLine($"{t[1, 2]}");
            //Expresion para cambiar el valor en 0,1:
            t[0, 1] = 0;
            //Instrucciones para poner en 0 todos los elemntos de t:
            t[0, 0] = 0;
            t[0, 1] = 0;
            t[0, 2] = 0;
            t[1, 0] = 0;
            t[1, 1] = 0;
            t[1, 2] = 0;
            //for anidado para inicializar en 0:
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    t[i, j] = 0;
                }
            }
            //for anidado para recibir datos por teclado:
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el valor de la posicion {i},{j}:  ");
                    t[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            //Mostrar el valor más pequeño de la matriz:
            int numeroMenor = t[0, 0];
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    if (t[i, j] < numeroMenor)
                    {
                        numeroMenor = t[i, j];
                    }
                }
            }
            Console.WriteLine($"El número más bajo en la matriz es: {numeroMenor}");
                //Mostrar la primera fila de t:
                Console.WriteLine($"|{t[0, 0]}|{t[0, 1]}|{t[0, 2]}|");
            //instruccion que totalice los elementos de la tercer columna:
            int sumaTercerColumna = t[0, 3] + t[1, 3];
            //Listar la matriz t con formato:
            for (int i = 0; i < 2; i++)
            {
                if(i == 0)
                    Console.WriteLine("    C1 C2 C3");
                for (int j = 0; j < 3; j++)
                {
                    if(j == 0)
                    {
                        Console.Write($"F{i}:|{t[i,j]}|");
                    }
                    else
                    {
                        Console.Write($"{t[i,j]}|");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
