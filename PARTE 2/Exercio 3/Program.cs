int valorpresente, periodo;
double taxajuros,rendimento;

Console.WriteLine(" Informe o valor inicial:");
valorpresente =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe a taxa de juros:");
taxajuros =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o periodo dos meses:");
periodo = Convert.ToInt32(Console.ReadLine());

rendimento = valorpresente * Math.Pow((1+taxajuros),periodo);

Console.WriteLine(rendimento);