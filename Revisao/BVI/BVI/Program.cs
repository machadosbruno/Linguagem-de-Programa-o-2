using System;

namespace BVI;

public class BVI
{
    public static void Main()
    {
        Salario ContaSalario = new Salario();
        ContaSalario.ValorAtual = 1000.0;

        ContaSalario.AplicarRendimentoMensal();

        Console.Write("Conta Salario com rendimento mensal aplicado: ");
        Console.WriteLine(ContaSalario.ValorAtual);
        
        ContaSalario.RetirarDinheiro(30.0);
        
        Console.Write("Conta Salario com valor de R$30.0 retirado: ");
        Console.WriteLine(ContaSalario.ValorAtual);
        
        Console.WriteLine("-----------------------------------------------------------");

        Poupanca ContaPoupanca = new Poupanca();
        ContaPoupanca.ValorAtual = 1000.0;

        ContaPoupanca.AplicarRendimentoMensal();

        Console.Write("Conta Poupanca com rendimento mensal aplicado: ");
        Console.WriteLine(ContaPoupanca.ValorAtual);

        ContaPoupanca.RetirarDinheiro(30.0);

        Console.Write("Conta Poupanca com valor de R$30.0 retirado: ");
        Console.WriteLine(ContaPoupanca.ValorAtual);

        Console.ReadKey();
    }
}