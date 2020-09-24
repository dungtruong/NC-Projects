﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalCosmetics.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email/Username")]
        public string EmailOrUsername { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        //public string ReturnUrl { get; set; }
    }
}
