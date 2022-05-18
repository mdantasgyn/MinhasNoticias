﻿using MinhasNoticias.Application.Requests.Mail;
using System.Threading.Tasks;

namespace MinhasNoticias.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}