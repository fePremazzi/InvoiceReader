using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace InvoiceReaderAPI.Service
{
    public class BlobStorageService : IBlobStorageService
    {
        BlobServiceClient _blobServiceClient;
        BlobContainerClient _containerClient;

        public BlobStorageService()
        {
            _blobServiceClient = new BlobServiceClient(Environment.GetEnvironmentVariable("AZURE_CONNECTION_STRING"));
            _containerClient = _blobServiceClient.GetBlobContainerClient(Environment.GetEnvironmentVariable("AZURE_BLOB_IMAGE_PATH"));
        }

        public Task<Response<BlobContentInfo>> UploadFile(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
