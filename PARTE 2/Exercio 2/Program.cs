
        int tamanhoDaTabela;        double valorInicial, valorFinal, taxaJuros, rendimentoTotal, rendimentoLiquido;
        Console.WriteLine("Passe o valor inicial: ");
        valorInicial = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a taxa de juros (utilize vírgula para casas decimais): ");        taxaJuros = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Passe periodo em Meses: ");
        tamanhoDaTabela = Convert.ToInt32(Console.ReadLine());
        rendimentoTotal = valorInicial;        Console.WriteLine("|Calculo|Rendimento Do Mes| Rendimento Acumulado");
        Console.WriteLine(" ");        for(int i = 1; i<=tamanhoDaTabela; i++) {
            valorFinal = valorInicial * Math.Pow(1 + (taxaJuros/100.0), i);            
            Console.Write("|" + Math.Round(valorFinal, 2) + "|");            rendimentoLiquido =  valorFinal - valorInicial;
            rendimentoTotal = rendimentoTotal + rendimentoLiquido;            Console.Write(Math.Round(rendimentoLiquido, 2) + "|");
            Console.Write(Math.Round(rendimentoTotal, 2) + "|");            Console.WriteLine(" ");
            Console.WriteLine(" ");        }
    