using PetShopBH.Models;

namespace PetShopBH.MetodosExtensao
{
    public static class CalculoTotalChowChawgas
    {
        public static decimal CalcularTotalChowChow(this PetShopChowChawgas petshop, DonoCachorros donoCachorros)
        {
            decimal somaCachorroPequeno = donoCachorros.QuantidadeDogPequeno * petshop.PrecoBanhoDogPequeno;
            decimal somaCachorroGrande = donoCachorros.QuantidadeDogGrande * petshop.PrecoBanhoDogGrande;

            return somaCachorroGrande + somaCachorroPequeno;

        }
    }
}
