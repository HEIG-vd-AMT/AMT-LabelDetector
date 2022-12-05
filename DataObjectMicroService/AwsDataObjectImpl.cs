namespace DataObjectMicroService
{
    public class AwsDataObjectImpl : IDataObject
    {
        public Task<bool> DoesObjectExist()
        {
            throw new NotImplementedException();
        }

        public Task DownloadObject(string localUri, string remoteUri)
        {
            throw new NotImplementedException();
        }

        public Task PublishObject(string remoteUri, int expirationTime = 60)
        {
            throw new NotImplementedException();
        }

        public Task RemoveObject(string remoteUri, bool recursive = false)
        {
            throw new NotImplementedException();
        }

        public Task UploadObject(string localUri, string remoteUri = "")
        {
            throw new NotImplementedException();
        }
    }
}