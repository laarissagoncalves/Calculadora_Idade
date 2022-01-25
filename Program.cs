namespace Calculadora_Idade {
    class Program {

       public static void Main (string[] args){

            int anoNasc, mesNasc, diaNasc, anoHoje, mesHoje, diaHoje, ttAnos, ttMeses, ttDias, tAnos, tMeses, tDias;

            Console.WriteLine("");
            Console.WriteLine("Informe sua data de nascimento");
            Console.WriteLine("");
            //Verificando validade do dia
            do {
                Console.Write("Dia: ");
                diaNasc = int.Parse(Console.ReadLine());
                if (diaNasc < 1 || diaNasc > 31)
                    Console.WriteLine ("Dia Inválido!");
            } while (diaNasc < 1 || diaNasc > 31);
            //Verificando validade do mês
            do {
                Console.Write("Mês: ");
                mesNasc = int.Parse(Console.ReadLine());
                if (mesNasc < 1 || mesNasc > 12)
                    Console.WriteLine("Mês Inválido!");
            } while(mesNasc < 1 || mesNasc > 12);
            Console.Write("Ano: ");
            anoNasc = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Informe a data atual");
            Console.WriteLine("");
            //Verificando validade do dia
            do {
                Console.Write("Dia: ");
                diaHoje = int.Parse(Console.ReadLine());
                if (diaNasc < 1 || diaNasc > 31)
                    Console.WriteLine ("Dia Inválido!");
            } while (diaNasc < 1 || diaNasc > 31);
            //Verificando validade do mês
            do {
                Console.Write("Mês: ");
                mesHoje = int.Parse(Console.ReadLine());
                if (mesNasc < 1 || mesNasc > 12)
                    Console.WriteLine("Mês Inválido!");
            } while (mesNasc < 1 || mesNasc > 12);
            Console.Write("Ano: ");
            anoHoje = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            ttDias = diaHoje - diaNasc;
            ttMeses = mesHoje - mesNasc;
            ttAnos = anoHoje - anoNasc;

            //Cálculo dos dias e meses
            if (ttDias < 0 && ttMeses < 0){
                tDias = ttDias + 30;
                tMeses = ttMeses + 11;
                tAnos = ttAnos - 1;
                Console.WriteLine("Você tem {0} anos, {1} meses e {2} dias.", tAnos, tMeses, tDias);
            }
            else
                if (ttDias < 0){
                    tDias = ttDias + 30;
                    tMeses = ttMeses - 1;
                    Console.WriteLine("Você tem {0} anos, {1} meses e {2} dias.", ttAnos, tMeses, tDias);
                }
                else
                    if (ttMeses < 0){
                        tMeses = ttMeses + 12;
                        tAnos = ttAnos - 1;
                        Console.WriteLine("Você tem {0} anos, {1} meses e {2} dias.",tAnos,tMeses,ttDias);
                    }
                    else
                        Console.WriteLine("Você tem {0} anos, {1} meses e {2} dias.",ttAnos,ttMeses,ttDias);
       }
    }
}
