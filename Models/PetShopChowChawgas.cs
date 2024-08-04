namespace PetShopBH.Models
{
    public class PetShopChowChawgas
    {
        public string NomePetShop { get; set; } = string.Empty;

        public decimal PrecoBanhoDogGrande { get; set; }
        public decimal PrecoBanhoDogPequeno { get; set; }
        public double Distancia { get; set; }

        public bool MaisBarato { get;set; }
    }
}
