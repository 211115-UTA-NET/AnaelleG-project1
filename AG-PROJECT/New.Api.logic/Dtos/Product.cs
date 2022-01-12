using System.ComponentModel.DataAnnotations;

namespace Farmer.Api.Dtos
{
    public class Product
    {
        [Required]
        string Productname { get; set; } = "";

        [Required]
        int ProductID { get; set; }



    }
}
