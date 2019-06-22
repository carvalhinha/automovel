using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("digite a marca do carro: ");
            string Marca = Console.ReadLine();
            Console.WriteLine("digite o pais de origem do carro: ");
            string PaisOrigem = Console.ReadLine();
            Console.WriteLine("digite a quantidade de portas do veiculo: ");
            int QuantidadePortas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a capacidade de combustivel do seu carro: ");
            double QuantidadeCombustivel = double.Parse(Console.ReadLine());
            Console.WriteLine("digite se seu carro é flex com true ou false: ");
            bool Flex = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("digite quantos quilometros seu carro faz por litro: ");
            double KML = Convert.ToDouble(Console.ReadLine());
            carro veiculo = new carro(Marca, PaisOrigem, QuantidadePortas, QuantidadeCombustivel, Flex, KML);
            Console.WriteLine($"marca: {veiculo.Marca}  Pais de origem: {veiculo.PaisOrigem}   Quantidade de portas: {veiculo.QuantidadePortas}  capacidade de combustivel:  {veiculo.QuantidadeCombustivel}  carro flex:  {veiculo.Flex} \n fara: {veiculo.KML} por litro. sua autonomia sera de {veiculo.km} quilomestros com o tanque cheio");
           
        }
    }
}
