using System;

namespace _4_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.tiular = "Bruno Carlos";
            contaDoBruno.saldo = 300;


            Console.WriteLine(contaDoBruno.saldo);


            bool resultadoSaque = contaDoBruno.Sacar(50);
            Console.WriteLine(resultadoSaque);

            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(250);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaJaine = new ContaCorrente();

            contaDaJaine.tiular = "Jaine Barbosa";
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Jaine: " + contaDaJaine.saldo);

            contaDoBruno.Transferir(100, contaDaJaine);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo do Jaine: " + contaDaJaine.saldo);

            Console.ReadLine();
        }
    }
}
