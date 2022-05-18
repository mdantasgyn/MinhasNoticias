using MinhasNoticias.Application.Requests;

namespace MinhasNoticias.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}