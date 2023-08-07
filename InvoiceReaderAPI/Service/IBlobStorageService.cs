using Azure.Storage.Blobs.Models;

namespace InvoiceReaderAPI.Service
{
    public interface IBlobStorageService
    {
        Task<Azure.Response<BlobContentInfo>> UploadFile(IFormFile file);
    }
}
