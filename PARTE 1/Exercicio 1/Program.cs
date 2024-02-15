double vf = 7390.61;
double vp;
double i;

Console.WriteLine("Informe a taxa de juros:");
i = Convert.ToDouble(Console.ReadLine());

vp = vf/(1+i)*2;

Console.WriteLine(vp);