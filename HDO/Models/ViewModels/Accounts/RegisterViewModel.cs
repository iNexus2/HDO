﻿namespace Models.ViewModels.Accounts
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class RegisterViewModel
    {
      //  [Required]
       // [DataType(DataType.Text)]
        //[MinLength(3, ErrorMessage = "The {0} must be at least {1} characters long.")]
        //[RegularExpression("[a-zA-Z0-9-_.*~]+")]
        [Display(Name = "Име")]
        public string FirstName { get; set; }

        //[Required]
        //[DataType(DataType.Text)]
       // [MinLength(3, ErrorMessage = "The {0} must be at least {1} characters long.")]
        //[RegularExpression("[a-zA-Z0-9-_.*~]+")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

       // [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }


      // [Required]
       // [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
      //  [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //[Required]
        //[DataType(DataType.Password)]
       // [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }


        public string PicturePath { get; set; }
        public string UserName { get; set; }
    }

}