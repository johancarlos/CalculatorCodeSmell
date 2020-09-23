using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculadora
    {
        public int numero1 { get; set; }
        public int numero2 { get; set; }
        public int respuesta { get; set; }
        public string eleccion { get; set; }

        public Calculadora()
        {
            respuesta = 0;
            Console.WriteLine("====== Calculadora ======");
            Console.WriteLine("+ sumar  - restar   * multiplicar  / dividir");
            Console.WriteLine("Elegir Operacion: ");
            eleccion =Console.ReadLine();
            Console.WriteLine("Ingrese 2 numeros");
            Console.WriteLine("numero 1: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("numero 2: ");
            numero2 = int.Parse(Console.ReadLine());

        }

        public void calcular()
        {
            switch (eleccion)
            {
                case "+":
                    Console.WriteLine("Suma:");
                    sumar();
                    break;
                case "-":
                    Console.WriteLine("Resta:");
                    restar();
                    break;
                case "*":
                    Console.WriteLine("Resta:");
                    multiplicar();
                    break;
                case "/":
                    Console.WriteLine("Resta:");
                    dividir();
                    break;
            }
            Console.WriteLine("La respuesta es: {0} {1} {2} = {3}", numero1, eleccion, numero2, respuesta);

        }
        public void sumar()
        {
            respuesta = numero1 + numero2;
        }
        public void restar()
        {
            respuesta = numero1 - numero2;
        }
        public void multiplicar()
        {
            respuesta = numero1 * numero2;
        }
        public void dividir()
        {
            respuesta = numero1 / numero2;
        }

    }
}
