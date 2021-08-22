using System;

namespace _2_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.tiular = "Gabriela do Carmo";
            contaDaGabriela.agencia = 3117;
            contaDaGabriela.conta = 16443;
            contaDaGabriela.saldo = 2500;

            Console.WriteLine(contaDaGabriela.tiular);
            Console.ReadLine();
        }

    }
}
