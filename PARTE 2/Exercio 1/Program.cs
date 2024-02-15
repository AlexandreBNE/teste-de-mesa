int vp = 1000;
double taxajuros = 5.30;
int periodomes = 10;
double  valorF = 0;

valorF =vp * Math.Pow((1+taxajuros),periodomes);

Console.WriteLine(valorF);

