 decimal valor,taxa,rv,saldo,rendimento=1,resgate,sacar;
        Console.WriteLine("Digite o valor:");
        valor=Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Digite a taxa:");
        taxa=Convert.ToDecimal(Console.ReadLine());
      taxa=taxa/100;
        Console.WriteLine("| Mês | Saldo       | Lucro |");
        saldo = valor;
        for (int mes=1;mes<7;mes++)
        {
          if(mes==6){
            rendimento=rendimento+(saldo*taxa);
            saldo+=rendimento;
            Console.WriteLine($"\n|  {mes}  | {saldo:N2}    | {rendimento:N2} |");
          }else{
            rendimento=rendimento+(saldo*taxa);
            saldo+=rendimento;
            Console.WriteLine($"\n|  {mes}  | {saldo:N2}    | {rendimento:N2} |");
          Console.WriteLine("Deseja sacar? SIM:1  NAO:2");
          sacar=Convert.ToDecimal(Console.ReadLine());
            if (sacar==1){
              Console.WriteLine("Quanto deseja sacar?");
              rv=Convert.ToDecimal(Console.ReadLine());
                resgate=saldo-rv;
                saldo=(saldo+rendimento)-rv;
              }
} 
}