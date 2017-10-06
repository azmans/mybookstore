using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBookstore.Models
{
    public class AuthorModels
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(40, ErrorMessage = "Up to 40 characters only.")]
        [Required(ErrorMessage = "Field required.")]
        public string LN { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(20, ErrorMessage = "Up to 20 characters only.")]
        [Required(ErrorMessage = "Field required.")]
        public string FN { get; set; }

        [Display(Name = "Phone")]
        [MaxLength(12, ErrorMessage = "Phone number must be 12 digits only.")]
        [Required(ErrorMessage = "Field required.")]
        public string Phone { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        [MaxLength(40, ErrorMessage = "Up to 40 characters only.")]
        public string Address { get; set; }

        [Display(Name = "City")]
        [MaxLength(20, ErrorMessage = "Up to 20 characters only.")]
        public string City { get; set; }

        [Display(Name = "State")]
        [MaxLength(2, ErrorMessage = "2 characters required only.")]
        public string State { get; set; }

        [Display(Name = "Zip")]
        [MaxLength(5, ErrorMessage = "5 characters required only.")]
        public string Zip { get; set; }
    }
}