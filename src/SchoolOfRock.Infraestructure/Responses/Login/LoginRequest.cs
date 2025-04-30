﻿using System.ComponentModel.DataAnnotations;

namespace SchoolOfRock.Infraestructure.Responses.Login
{
    public class LoginRequest
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public required string Login { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}