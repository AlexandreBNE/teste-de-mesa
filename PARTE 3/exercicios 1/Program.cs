using System;
class Program{
    static void Main(string[] args)    {
        double valorPresente, taxaJuros, meses, valorFinal;        
        string continuar;
        Console.WriteLine("Informe o valor inicial: ");
        valorPresente = ObterDoublePositivo();
        Console.WriteLine("Informe a taxa de juros:");        
        taxaJuros = ObterDoubleNaoNegativo();
        Console.WriteLine("Informe a quantidade de meses: ");
        meses = ObterDoublePositivo();
        Console.WriteLine("Deseja acrescentar dias? (s/n): ");        
        continuar = Console.ReadLine();
        if (continuar.ToLower() == "s" || continuar.ToLower() == "sim")
        {            Console.WriteLine("Quantos dias deseja acrescentar?: ");
            double dias = ObterDoubleNaoNegativo();            
            DateTime dataAtual = DateTime.Now;
            DateTime dataFutura = dataAtual.AddMonths((int)meses).AddDays(dias);           
             int totalDias = (int)(dataFutura - dataAtual).TotalDays;
            valorFinal = valorPresente * Math.Pow(1 + taxaJuros / 100, meses + totalDias / 30);        }
        else        {
            valorFinal = valorPresente * Math.Pow(1 + taxaJuros / 100, meses);        }
        Console.WriteLine($"Valor inicial: R$ {valorPresente:C2}");
        Console.WriteLine($"Taxa de juros mensal: {taxaJuros}%");       
         Console.WriteLine($"Período de tempo em meses: {meses} meses");
        Console.WriteLine($"Valor Final: R$ {valorFinal:C2}");    }
    static double ObterDoublePositivo()
    {        double valor;
        while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)        {
            Console.WriteLine("Valor inválido. Por favor, insira um número positivo.");        }
        return valor;    }
    static double ObterDoubleNaoNegativo()
    {        double valor;
        while (!double.TryParse(Console.ReadLine(), out valor) || valor < 0)        {
            Console.WriteLine("Valor inválido. Por favor, insira um número não-negativo.");        }
        return valor;    }
}