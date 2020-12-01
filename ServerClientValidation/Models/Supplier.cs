using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServerClientValidation.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please fill your name")]
        [MaxLength(6)]
        [EmailAddress]
        [DataType(DataType.Password)]
        public string Name { get; set; }
    }
}