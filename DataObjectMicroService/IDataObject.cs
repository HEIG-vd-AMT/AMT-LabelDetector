namespace DataObjectMicroService
{
    internal interface IDataObject
    {
        Task<Boolean> DoesObjectExist();
        Task UploadObject(string localUri, string remoteUri = "");
        Task DownloadObject(string localUri, string remoteUri);
        Task PublishObject(string remoteUri, int expirationTime = 60);
        Task RemoveObject(string remoteUri, bool recursive=false);
    }
}
