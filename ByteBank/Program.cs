using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoFabio = new ContaCorrente();

            contaDoFabio.tiular = "Fábio Castro";
            contaDoFabio.conta = 16442;
            contaDoFabio.agencia = 3117;
            contaDoFabio.saldo = 2800;

            Console.WriteLine("O titular da conta é: " + contaDoFabio.tiular);
            Console.WriteLine("Agencia: " + contaDoFabio.agencia);
            Console.WriteLine("Conta: " + contaDoFabio.conta);
            Console.WriteLine("Saldo: " + contaDoFabio.saldo);

            Console.ReadLine();
        }
    }
}
