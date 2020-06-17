using System;
namespace Aula19Ingresso
{
    public class IngressoVIP : Ingresso
    {
       public float ValorAdicional = 50.0f;

       public void AdicionarValor(){
           float newValor = IngressoPreco + ValorAdicional;
          // Console.WriteLine("O valor VIP é: {0,c}",newValor); 
           System.Console.WriteLine("O valor para entrada VIP é de $"+newValor);
       } 
    }
}