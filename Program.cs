using System;

namespace Aula19Ingresso
{
    class Program
    { 
        static void Main(string[] args)
        {
            IngressoVIP cinema = new IngressoVIP();
            System.Console.WriteLine("Valor Ingresso Tradicional:");
            System.Console.WriteLine("");
            cinema.IngressoPreco = 40.5f;
            //show.Desconto();
            cinema.ImprimirValor();
            cinema.GerarDesconto();
            cinema.AdicionarValor();
            System.Console.WriteLine("A diferença de valores é de R$"+cinema.ValorAdicional);
            System.Console.WriteLine("");


            IngressoVIP show = new IngressoVIP();
            System.Console.WriteLine("Os valores dos ingressos para o Show:");
            System.Console.WriteLine("");
            show.IngressoPreco = 99.90f;
            //show.Desconto();
            show.ImprimirValor();
            show.GerarDesconto();
            show.AdicionarValor();
            System.Console.WriteLine("A diferença de valores é de R$"+show.ValorAdicional);
            System.Console.WriteLine("");

            IngressoVIP StandUp = new IngressoVIP();
            System.Console.WriteLine("Os valores dos ingressos para o Stand Up:");
            System.Console.WriteLine("");
            StandUp.IngressoPreco = 60;
            //StandUp.Desconto = 5;
            StandUp.ImprimirValor();
            StandUp.GerarDesconto();
            StandUp.AdicionarValor();
            System.Console.WriteLine("A diferença de valores é de R$"+StandUp.ValorAdicional);
            System.Console.WriteLine("");

            IngressoVIP Jogo = new IngressoVIP();
            System.Console.WriteLine("Os valores dos ingressos para o Jogo:");
            System.Console.WriteLine("");
            Jogo.IngressoPreco = 40f;
            //Jogo.Desconto = 5;
            Jogo.ImprimirValor();
            Jogo.GerarDesconto();
            Jogo.AdicionarValor();
            System.Console.WriteLine("A diferença de valores é de R$"+Jogo.ValorAdicional);

        }
    }
}
