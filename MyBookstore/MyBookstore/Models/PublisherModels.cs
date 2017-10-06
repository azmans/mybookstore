using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBookstore.Models
{
    public class PublisherModels
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [MaxLength(40, ErrorMessage = "Up to 40 characters only.")]
        [Required(ErrorMessage = "Field required.")]
        public string Name { get; set; }
    }
}