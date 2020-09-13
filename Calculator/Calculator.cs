using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator - CodeSmell";
            string res = "";
            do
            {
                int num1 = 0;
                int num2 = 0;
                int r = 0;

                Console.WriteLine("====== Calculadora ======");
                Console.WriteLine("+ sumar");
                Console.WriteLine("- restar");
                Console.WriteLine("* multiplicar");
                Console.WriteLine("- dividir");
                Console.WriteLine("Elegir Operacion: ");

                res = Console.ReadLine();
                string eleccion = Convert.ToString(res);

                Console.WriteLine("Ingrese 2 numeros");
                Console.WriteLine("num1: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("num2: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (eleccion)
                {
                    case "+":
                        Console.WriteLine("Suma:");
                        r = num1 + num2;
                        Console.WriteLine("{0} + {1} = {2}", num1, num2, r);
                        break;
                    case "-":
                        Console.WriteLine("Resta:");
                        r = num1 - num2;
                        Console.WriteLine("{0} - {1} = {2}", num1, num2, r);
                        break;
                    case "*":
                        Console.WriteLine("Resta:");
                        r = num1 * num2;
                        Console.WriteLine("{0} * {1} = {2}", num1, num2, r);
                        break;
                    case "/":
                        Console.WriteLine("Resta:");
                        r = num1 / num2;
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, r);
                        break;
                }
                Console.Write("Realizar otra operacion? si/no:");
                res = Console.ReadLine();
            }
            while (res == "si");
            Console.WriteLine("Calculo finalizado");
        }
    }
}
