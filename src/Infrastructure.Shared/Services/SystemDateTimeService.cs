using MinhasNoticias.Application.Interfaces.Services;
using System;

namespace MinhasNoticias.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}