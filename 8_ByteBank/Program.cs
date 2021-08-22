using System;

namespace _8_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.ContasCriadas);
            
            ContaCorrente conta = new ContaCorrente(867,86712540);
            Console.WriteLine(ContaCorrente.ContasCriadas);

            ContaCorrente fabio = new ContaCorrente(867, 7105180);
            Console.WriteLine(ContaCorrente.ContasCriadas);

            //ContaCorrente.ContasCriadas = 5;

            //conta.Numero = 86712540;
            //conta.Agencia = 867;
            //Console.WriteLine(conta.Agencia);

            conta.Agencia = -10;
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
