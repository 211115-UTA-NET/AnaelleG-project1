using System.ComponentModel.DataAnnotations;

namespace Farmer.Api.Dtos
{
    public class Order
    {
        [Required]
        public string Location { get; set; } = "";

        [Required]
        public int QtyofProduct { get; set; }
        [Required]
        public string Date { get; set; } = "";

    }
}
