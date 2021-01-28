using System;

namespace consumoEnergia
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta(60);
            Cliente cli1 = new Cliente("Jonatas");
            c1.titular = cli1;
            c1.setValor(2.00);

            Console.WriteLine($"Bem vindo {c1.titular.nome}");
            Console.WriteLine($"Você consumiu {c1.kilowats} kilowats");         
            Console.WriteLine($"O valor da sua fatura é de R$: {c1.consumo()}");
        }
    }
}
