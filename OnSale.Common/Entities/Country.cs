using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace OnSale.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }
       [MaxLength(50, ErrorMessage = "The Field {0} must contains less than {1} characters.")]
        [Required]
        public string Name { get; set; }

    }
}
