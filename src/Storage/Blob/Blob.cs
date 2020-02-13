using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.IO;
using Microsoft.Extensions.Options;
using Profile4d.Domain;

namespace Profile4d.Storage
{
  public class Blob : IBlob
  {
    private readonly IOptions<Secrets.ConnectionStrings> _connStr;

    public Blob(IOptions<Secrets.ConnectionStrings> ConnectionStrings)
    {
      _connStr = ConnectionStrings;
    }
    public void SaveBase64(Image data)
    {
      MemoryStream ms = new MemoryStream(Convert.FromBase64String(data.Mime.Substring(data.Mime.IndexOf(",") + 1)));

      BlobServiceClient blobServiceClient = new BlobServiceClient(_connStr.Value.Storage);
      BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient("images-staging");
      BlobClient blobClient = containerClient.GetBlobClient(data.Name);
      blobClient.Upload(ms);
    }

    public BlobDownloadInfo ShowImage(string file)
    {
      BlobServiceClient blobServiceClient = new BlobServiceClient(_connStr.Value.Storage);
      BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient("images-staging");
      BlobClient blobClient = containerClient.GetBlobClient(file);

      return blobClient.Download();
    }
  }
}