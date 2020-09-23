using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            string continuar;
            Calculadora calculadora;
            do
            {
                Console.Clear();
                calculadora = new Calculadora();
                calculadora.calcular();
                Console.Write("Realizar otra operacion? si/no:");
                continuar = Console.ReadLine();
            }
            while (continuar == "si");
        }
    }
}
