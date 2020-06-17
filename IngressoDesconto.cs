namespace Aula19Ingresso
{
    public class IngressoDesconto : Ingresso
    {
        
        public float ValorDoDesconto = 9.25f;
        
        public void ValorDesconto(){

            float newValor = IngressoPreco - ValorDoDesconto;

            System.Console.WriteLine("Caso você pague o ingresso a vista, o valor pago ficará R$" + newValor);
        }
    }
}