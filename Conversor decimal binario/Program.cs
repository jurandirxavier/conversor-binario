using System;

namespace Conversor_decimal_binario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite um número POSITIVO!");

            int dividendo; // valor digitado (informado)

            dividendo = Convert.ToInt32(Console.ReadLine());
            
            string binario = "";

            while (dividendo > 0)
            {
                if (dividendo % 2 == 0) // módulo (resto) da divisão do dividendo p/ 2
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }
                dividendo = (int)dividendo / 2;
            }
            Console.WriteLine(" O valor binário do número informado é igual a " + binario);
            Console.ReadLine();
        }
    }
}