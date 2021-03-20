using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1_JoseRivera.Models
{
    public class Product
    {
        [Key]
        [Range(1,99999)]
        public int IdentityID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Description { get; set; }
        public Currency Price { get; set; }
    }
}