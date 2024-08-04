using PetShopBH.Enum;

namespace PetShopBH.Models
{
        public class MelhorCanil
        {
            public string NomePetShop { get; set; } = string.Empty;

            public int QntG { get; set; }
            public int QntP { get; set; }

            public decimal PrecoTotal { get; set; }
            public double Distancia { get; set; }

            public bool MaisBarato { get; set; }
         public EDiaSemana DiaDaSemana { get; set; }

        }
        public class CanilMaisBarato
        {
            public string NomePetShop { get; set; } = string.Empty;
            public decimal PrecoTotal { get; set; }
            public decimal Distancia { get; set; }

        }
    
}
