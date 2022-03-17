using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");

                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Convertir de F a C");
                Console.WriteLine("[8] Convertir de C a F");

                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int s1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int s2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", s1, s2, Suma(s1, s2));
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int r1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int r2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", r1, r2, Resta(r1, r2));
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int m1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int m2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", m1, m2, Multiplicacion(m1, m2));
                        Console.ReadKey();
                        break;
                        

                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        double d1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        double d2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2:N2}", d1, d2, Division(d1, d2));
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Calculando...");
                        nprimos();
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.WriteLine("Ingrese la temperatura en °F");
                        double f1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0} grados °F son {1:N2} grados °C", f1, ftoc(f1));
                        Console.ReadKey();
                        break;

                    case "8":
                        Console.WriteLine("Ingrese la temperatura en °C");
                        double c1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0} grados °C son {1} grados °F", c1, ctof(c1));
                        Console.ReadKey();
                        break;

                }
            } while (!opcion.Equals("0"));
        }


        //Función para calcular la suma de 2 números enteros
        static int Suma(int s1, int s2)
        {
            return s1 + s2;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static int Resta(int r1, int r2)
        {
            return r1 - r2;
        }

        static int Multiplicacion(int m1, int m2)
        {
            return m1 * m2;
        }

        static double Division(double d1, double d2)
        {
            if (d2 == 0) { 
                return 0;
            }
            return d1 / d2;
        }
        static void nprimos()
        {
            int num = 1, resto, divisor, salirWhile, contador = 0;

            while (contador < 10)
            {
                divisor = 2; salirWhile = 0;

                while ((divisor < num) & (salirWhile == 0))
                {

                    resto = num % divisor;

                    if (resto == 0)
                    {
                        salirWhile = 1;
                    }
                    else
                    {
                        divisor = divisor + 1;
                    }
                }

                if (salirWhile == 0)
                {
                    Console.Write(num + "\n");
                    contador = contador + 1;
                }

                num = num + 1;
            }
        }

        static double ftoc(double f1)
        {
            return (5 * (f1 - 32)) / 9;
        }

        static double ctof(double c1)
        {
            return ((9 * c1) / 5) + 32;
        }

    }
}
