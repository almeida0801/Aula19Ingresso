using System;
namespace Aula19Ingresso
{
    public class Ingresso
    {
        public float IngressoPreco {get; set;}

        public void ImprimirValor(){
            
            Console.WriteLine("O valor do ingresso tradicional é $" + IngressoPreco);
        }

        //public bool AceitarDesconto

        public int Desconto = 15; 

        public void GerarDesconto(){
            Console.WriteLine( $"Pagando a vista, você terá R${Desconto} de desconto.");
        }
        

        
    }
}