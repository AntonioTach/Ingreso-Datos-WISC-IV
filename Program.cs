using System;
using static System.Console;

namespace Automatizacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el rango del arreglo");
            string rango = ReadLine();
            
            int.TryParse(rango, out int numberRange);
            numberRange = numberRange + 1;
            int[] valores;
            valores = new int[numberRange];

            Console.WriteLine("Ingrese el ultimo rango con valor 1");
            int rango1 = int.Parse(Console.ReadLine());
            rango1 = rango1 + 1;

            for (int i=0; i<rango1; i++){
                valores[i] = 1;
            }
            
            Console.WriteLine("Ingrese el ultimo rango con valor 2");
            int rango2 = int.Parse(Console.ReadLine());
            rango2 = rango2 + 1;
            for (int i=rango1; i<rango2; i++){
                valores[i] = 2;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 3");
            int rango3 = int.Parse(Console.ReadLine());
            rango3 = rango3 + 1;
            for (int i=rango2; i<rango3; i++){
                valores[i] = 3;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 4");
            int rango4 = int.Parse(Console.ReadLine());
            rango4 = rango4 + 1;
            for (int i=rango3; i<rango4; i++){
                valores[i] = 4;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 5");
            int rango5 = int.Parse(Console.ReadLine());
            rango5 = rango5 + 1;
            for (int i=rango4; i<rango5; i++){
                valores[i] = 5;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 6");
            int rango6 = int.Parse(Console.ReadLine());
            rango6 = rango6 + 1;
            for (int i=rango5; i<rango6; i++){
                valores[i] = 6;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 7");
            int rango7 = int.Parse(Console.ReadLine());
            rango7 = rango7 + 1;
            for (int i=rango6; i<rango7; i++){
                valores[i] = 7;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 8");
            int rango8 = int.Parse(Console.ReadLine());
            rango8 = rango8 + 1;
            for (int i=rango7; i<rango8; i++){
                valores[i] = 8;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 9");
            int rango9 = int.Parse(Console.ReadLine());
            rango9 = rango9 + 1;
            for (int i=rango8; i<rango9; i++){
                valores[i] = 9;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 10");
            int rango10 = int.Parse(Console.ReadLine());
            rango10 = rango10 + 1;
            for (int i=rango9; i<rango10; i++){
                valores[i] = 10;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 11");
            int rango11 = int.Parse(Console.ReadLine());
            rango11 = rango11 + 1;
            for (int i=rango10; i<rango11; i++){
                valores[i] = 11;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 12");
            int rango12 = int.Parse(Console.ReadLine());
            rango12 = rango12 + 1;
            for (int i=rango11; i<rango12; i++){
                valores[i] = 12;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 13");
            int rango13 = int.Parse(Console.ReadLine());
            rango13 = rango13 + 1;
            for (int i=rango12; i<rango13; i++){
                valores[i] = 13;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 14");
            int rango14 = int.Parse(Console.ReadLine());
            rango14 = rango14 + 1;
            for (int i=rango13; i<rango14; i++){
                valores[i] = 14;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 15");
            int rango15 = int.Parse(Console.ReadLine());
            rango15 = rango15 + 1;
            for (int i=rango14; i<rango15; i++){
                valores[i] = 15;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 16");
            int rango16 = int.Parse(Console.ReadLine());
            rango16 = rango16 + 1;
            for (int i=rango15; i<rango16; i++){
                valores[i] = 16;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 17");
            int rango17 = int.Parse(Console.ReadLine());
            rango17 = rango17 + 1;
            for (int i=rango16; i<rango17; i++){
                valores[i] = 17;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 18");
            int rango18 = int.Parse(Console.ReadLine());
            rango18 = rango18 + 1;
            for (int i=rango17; i<rango18; i++){
                valores[i] = 18;
            }

            Console.WriteLine("Ingrese el ultimo rango con valor 19");
            int rango19 = int.Parse(Console.ReadLine());
            rango19 = rango19 + 1;
            for (int i=rango18; i<rango19; i++){
                valores[i] = 19;
            }
            // Muestra de arreglo con los datos
            Console.WriteLine("Datos");
            for (int i=0; i<numberRange; i++){
                Console.Write($"{valores[i]}, ");
            }
            
        }
    }
}
