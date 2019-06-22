using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    public class carro 
    {
        public string Marca;
        public string PaisOrigem;
        public int QuantidadePortas;
        public double QuantidadeCombustivel;
        public bool Flex;
        public double KML;
        public double km;

        public carro(string marca, string paisOrigem, int quantidadePortas, double quantidadecombustivel, bool flex, double kml)
        {
            Marca = marca;
            PaisOrigem = paisOrigem;
            QuantidadePortas = quantidadePortas;
            QuantidadeCombustivel = quantidadecombustivel;
            Flex = flex;
            KML = kml;
            km = kml * quantidadecombustivel;
        }   
    }
}
