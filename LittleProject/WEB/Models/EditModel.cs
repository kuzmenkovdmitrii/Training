using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WEB.Models
{
    public class EditModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Field can't be empty")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Invalid name length")]
        public string Name { get; set; }

        [Display(Name = "Middle name")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Invalid middle name length")]
        public string MiddleName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Field can't be empty")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Invalid last name length")]
        public string LastName { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "Field can't be empty")]
        [Range(18, 99, ErrorMessage = "Invalid value of age")]
        public byte Age { get; set; }

        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(CustomRegularExpression.PHONE_PATTERN, ErrorMessage = "The phone does not follow the format +(xxx)-xx-xxx-xx-xx")]
        public string Phone { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Field can't be empty")]
        [StringLength(50, MinimumLength = 20, ErrorMessage = "Invalid address length")]
        public string Address { get; set; }
    }
}