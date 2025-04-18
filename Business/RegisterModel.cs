﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RegisterModel
    {
        [Required, MaxLength(100)]
        public string FirstName { get; set; }
        [Required, MaxLength(100)]
        public string LastName { get; set; }
        [Required, MaxLength(50)]
        public string UserName {  get; set; }
        [Required, MaxLength(120)]
        public string Email { get; set; }
        [Required, MaxLength(300)]
        public string Password { get; set; }
    }
}
