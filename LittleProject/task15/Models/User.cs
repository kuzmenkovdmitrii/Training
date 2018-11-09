using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task15.Models
{
    public class User
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

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Field can't be empty")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "It is not the password")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "The password must be at least 6 characters long")]
        [RegularExpression(CustomRegularExpression.PASSWORD_PATTERN , ErrorMessage= "The password must contain at least one letter and a number")]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Confirm password")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "Field can't be empty")]
        [Range(18,99, ErrorMessage = "Invalid value of age")]
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