using System;

namespace _6_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoFabio = new ContaCorrente();

            
            contaDoFabio.SetSaldo(-10);

            Console.WriteLine(contaDoFabio.GetSaldo());


            Console.ReadLine();
        }
    }
}
