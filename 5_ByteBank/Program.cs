using System;

namespace _5_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente Gordo = new Cliente();
            //Gordo.nome = "Lucas Gordo";
            //Gordo.profissao = "Estudante";
            //Gordo.cpf = "123.456.789-00";


            ContaCorrente conta = new ContaCorrente();

            conta.titular = new Cliente();
            conta.saldo = 1000.00;
            conta.conta = 123456;
            conta.agencia = 123;

            // Console.WriteLine(Gordo.nome);
            conta.titular.nome = "Lucas Gordinho";
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine();
            Console.WriteLine("Seu Saldo é: " + conta.saldo + "R$");
                       Console.ReadLine();
        }
    }
}
