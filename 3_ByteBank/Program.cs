using System;

namespace _3_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.tiular = "Gabriela Silva";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.conta = 863452;
            contaDaGabriela.saldo = 30000;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.tiular = "Gabriela Silva Costa";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.conta = 863452;
            contaDaGabrielaCosta.saldo = 200;

            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);
            Console.WriteLine();

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);
            Console.WriteLine(contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
