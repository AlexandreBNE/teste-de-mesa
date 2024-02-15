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

    public double CalculateFutureIncome(int month, double withdraw)
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

        Investment investment = new Investment(initialValue, monthlyInterest);

        System.Console.WriteLine("\nMês | Valor Inicial | (%) |  Resgate  | Saldo Final");
        System.Console.WriteLine("----|---------------|-----|-----------|------------");

        for (int i = 1; i <= 8; i++)
        {
            double monthlyIncome = investment.CalculateFutureIncome(i, withdraw);
            System.Console.WriteLine($"{i,-4}| {initialValue:C2}   | {monthlyInterest * 100}%  | {(i == 5 ? withdraw.ToString("C") : "    -    ")} | {monthlyIncome:C}");
        }

        double totalIncome = investment.CalculateFutureIncome(8, withdraw);
        System.Console.WriteLine($"\nRendimento final: {totalIncome:C}");
    }
}