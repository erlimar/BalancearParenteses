using BalanceadorDeParenteses;
using System;

namespace BalancearParenteses
{
    class Program
    {
        const string TEMPLATE = "\n\nVALOR:\n{0}\nRESULTADO: {1}";

        static void Main(string[] args)
        {
            var valor1 = "((1+1)*2) + (10+2) + (((2-1)-1)*1)";
            var valor2 = "O Fulano (aquele que fez aniversário hoje) perguntou por você.";
            var valor3 = "&:)";
            var valor4 = "#:)";
            var valor5 = "isso ) *(aqui também (1+2) é válido, mas é um BUG proposital pra ser resolvido em uma refatoração";

            Console.WriteLine("Balanceador de parenteses");
            Console.WriteLine("By Erlimar Silva Campos [http://github.com/erlimar]");

            Console.WriteLine(TEMPLATE, valor1, Balanceador.Balanceavel(valor1));
            Console.WriteLine(TEMPLATE, valor2, Balanceador.Balanceavel(valor2));
            Console.WriteLine(TEMPLATE, valor3, Balanceador.Balanceavel(valor3));
            Console.WriteLine(TEMPLATE, valor4, Balanceador.Balanceavel(valor4));
            Console.WriteLine(TEMPLATE, valor5, Balanceador.Balanceavel(valor5));
            
            Console.ReadKey();
        }
    }
}
