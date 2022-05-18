using MinhasNoticias.Application.Interfaces.Common;

namespace MinhasNoticias.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}