using System;

namespace AMS_Ex8_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1 = 130;
            double v2 = 13;
            double resultado = v1 - v2;

            Console.WriteLine("");
            Console.WriteLine("         ***CÁLCULO DE SUBTRAÇÃO ENTRE DOIS VALORES***      ");

            if( resultado < 0)
            {
               Console.WriteLine($"O resultado dessa subtração é negativo! O número resultante é: {resultado}");
            }
            else if(resultado > 0)
            {
               Console.WriteLine($"O resultado dessa subtração é positivo! O número resultante é: {resultado}");
            }
            else 
            {
               Console.WriteLine("O resultado dessa subtração é zero!");
            }

            Console.WriteLine("");

        }
    }
}
