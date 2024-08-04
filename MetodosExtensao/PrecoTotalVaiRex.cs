using PetShopBH.Models;

namespace PetShopBH.MetodosExtensao
{
    public static class PrecoTotalVaiRex
    {
        public static decimal CalcularTotalSemanaVaiRex(this PetShopRex petshop, DonoCachorros donoCachorros)
        {
            petshop.PrecoBanhoDogPequeno = 15.00M;
            petshop.PrecoBanhoDogGrande = 50.00M;

            decimal somaCachorroP = donoCachorros.QuantidadeDogPequeno * petshop.PrecoBanhoDogPequeno;
            decimal somaCachorroG = donoCachorros.QuantidadeDogGrande * petshop.PrecoBanhoDogGrande;

            return somaCachorroG + somaCachorroP;

        }
        public static decimal CalcularTotalFinalSemanaVaiRex(this PetShopRex petshop, DonoCachorros donoCachorros)
        {
            petshop.PrecoBanhoDogPequeno = 20.00M;
            petshop.PrecoBanhoDogGrande = 55.00M;

            decimal somaCachorroP = donoCachorros.QuantidadeDogPequeno * petshop.PrecoBanhoDogPequeno;
            decimal somaCachorroG = donoCachorros.QuantidadeDogGrande * petshop.PrecoBanhoDogGrande;

            return somaCachorroG + somaCachorroP;

        }

    }
}
