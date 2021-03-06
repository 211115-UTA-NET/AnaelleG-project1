using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Api.Dtos
{
    //ConsiderIfullInfo
    public class Customer


    {


        [Required]
        public string? FirstName { get; set; } = "";


        [Required]
        public string? LastName { get; set; } = "";

        [Required]
        public string Address { get; set; } = "";
        
        [Required]
        public string City { get; set; } = "";
        
        [Required]
        public string State { get; set; } = "";
        
        [Required]
        public string Zipcode { get; set; } = "";
    }
}
