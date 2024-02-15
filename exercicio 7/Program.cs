﻿using System;

class Investment
{
    private double initialValue;
    private double monthlyInterest;

    public Investment(double initialValue, double monthlyInterest)
    {
        this.initialValue = initialValue;
        this.monthlyInterest = monthlyInterest;
    }

    public double calculateFutureIncome(int month, double withdraw)
    {
        double futureIncome = initialValue;

        for (int i = 1; i <= month; i++)
        {
            if (i == 5)
            {
                futureIncome -= withdraw;
            }
            else
            {
                futureIncome *= (1 + monthlyInterest);
            }
        }

        return futureIncome;
    }
}


class Program
{
    static void Main()
    {
        System.Console.Write("Digite o valor inicial: ");
        double initialValue = double.Parse(Console.ReadLine());

        System.Console.Write("Digite a taxa de juros mensal (%): ");
        double monthlyInterest = double.Parse(Console.ReadLine()) / 100;

        System.Console.Write("No 5º mês terá um resgate, digite o valor do resgate: ");
        double withdraw = double.Parse(Console.ReadLine());

        Investment Investment = new Investment(initialValue, monthlyInterest);

        System.Console.WriteLine("Mês| Rendimento");
        System.Console.WriteLine("---|---------------");

        for (int i = 1; i <= 8; i++)
        {
            double rendimentoMensal = Investment.calculateFutureIncome(i, withdraw);
            System.Console.WriteLine($"{i}  | {rendimentoMensal:C}");
        }

        double totalIncome = Investment.calculateFutureIncome(8, withdraw);
        System.Console.WriteLine($"Rendimento total: {totalIncome:C}");
    }
}