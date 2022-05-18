﻿using System.ComponentModel.DataAnnotations;

namespace MinhasNoticias.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}