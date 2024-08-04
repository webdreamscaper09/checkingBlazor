using PetShopBH.Models;

namespace PetShopBH.MetodosExtensao
{
    public static class PrecoTotalCanilFeliz
    {
        public static decimal CalcularTotalSemanaCaninoFeliz(this PetShopFeliz petshop, DonoCachorros donoCachorros)
        {
            decimal somaCachorroPequeno = donoCachorros.QuantidadeDogPequeno * petshop.PrecoBanhoDogPequeno;
            decimal somaCachorroGrande = donoCachorros.QuantidadeDogGrande * petshop.PrecoBanhoDogGrande;

            return somaCachorroGrande + somaCachorroPequeno;

        }
        public static decimal CalcularTotalFinalDeSemanaFeliz(this PetShopFeliz petshop, DonoCachorros donoCachorros)
        {
            decimal precoPorcentagemPequeno = 20m * 1.20m;
            decimal precoPorcentagemGrande = 40m * 1.20m;

            petshop.PrecoBanhoDogPequeno = precoPorcentagemPequeno;
            petshop.PrecoBanhoDogGrande = precoPorcentagemGrande;

            decimal somaCachorroPequeno = donoCachorros.QuantidadeDogPequeno * petshop.PrecoBanhoDogPequeno;
            decimal somaCachorroGrande = donoCachorros.QuantidadeDogGrande * petshop.PrecoBanhoDogGrande;
            
            return somaCachorroGrande + somaCachorroPequeno;

        }
    }
}
