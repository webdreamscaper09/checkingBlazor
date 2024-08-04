using System.ComponentModel.DataAnnotations;

namespace PetShopBH.Models
{
    public class DonoCachorros
    {
        [Range(0, 20, ErrorMessage = "A quantidade de cachorros grandes deve estar entre 1 e 20.")]
        public int QuantidadeDogGrande { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "A quantidade de cachorros pequenos deve ser um número positivo.")]
        public int QuantidadeDogPequeno { get; set; }
        public DateTime DiaDaSemana { get; set; }
        
    }
}
