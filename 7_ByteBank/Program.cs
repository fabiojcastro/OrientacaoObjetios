using System;

namespace _7_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            Console.WriteLine(conta.Saldo);
            conta.Saldo = 200;
            Console.WriteLine(conta.Saldo);


            cliente.nome = "Fábio Castro";
            cliente.cpf = "123.456.789";
            cliente.profissao = "Desenvolvedor";

            //conta.Titular = cliente;

            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Titular.cpf);
            Console.WriteLine(conta.Titular.profissao);

            Console.ReadLine();

        }
    }
}
