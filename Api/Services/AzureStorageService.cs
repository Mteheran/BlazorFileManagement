using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using shared;

namespace api.Services
{
    public class AzureStorageService : IAzureStorageService
    {       
        private readonly IConfiguration Configuration;

        public AzureStorageService(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public async Task SaveFileAsync(BlazorFile file)
        {
            string connectionString = Configuration["AZURE_STORAGE_CONNECTION_STRING"];

            // Create a BlobServiceClient object which will be used to create a container client
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

            //Using existing container
            string containerName = "csvcontainer";

            // Create the container and return a container client object
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName); 

            await containerClient.UploadBlobAsync(file.FileName, new MemoryStream(file.FileInfo));
        }
    }

    public interface IAzureStorageService
    {
        Task SaveFileAsync(BlazorFile file);
    }
}