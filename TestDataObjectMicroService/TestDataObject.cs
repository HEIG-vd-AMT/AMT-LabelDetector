namespace TestDataObjectMicroService
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        #region DoesExist
        [Test]
        public async Task DoesObjectExist_RootObjectExists_Exists()
        {
            //given

            //when

            //then          
        }

        [Test]
        public async Task DoesObjectExist_RootObjectDoesntExist_DoesntExist()
        {
            //given

            //when

            //then
        }

        [Test]
        public async Task DoesObjectExist_RootObjectAndObjectExist_Exists()
        {
            //given

            //when

            //then
        }

        [Test]
        public async Task DoesObjectExist_RootObjectExistObjectDoesntExist_DoesntExist()
        {
            //given

            //when

            //then
        }
        #endregion DoesExist

        #region uploadObject
        [Test]
        public async Task UploadObject_RootObjectExistsNewObject_Uploaded()
        {
            //given

            //when

            //then
        }

        [Test]
        public async Task UploadObject_RootObjectExistsObjectAlreadyExists_ThrowException()
        {
            //given

            //when

            //then
        }

        [Test]
        public async Task UploadObject_RootObjectDoesntExist_Uploaded()
        {
            //given

            //when

            //then
        }
        #endregion uploadObject

        #region downloadObject
        [Test]
        public async Task DownloadObject_ObjectExists_Downloaded()
        {
            //given

            //when

            //then
        }

        [Test]
        public async Task DownloadObject_ObjectDoesntExist_ThrowException()
        {
            //given

            //when

            //then
        }
        #endregion downloadObject

        #region publishObject
        [Test]
        public async Task PublishObject_ObjectExists_Published()
        {
            //given

            //when

            //then
        }

        [Test]
        public async Task PublishObject_ObjectDoesntExist_ThrowException()
        {
            //given

            //when

            //then
        }
        #endregion publishObject

        #region removeObject
        [Test]
        public async Task RemoveObject_SingleObjectExists_Removed()
        {
            //given

            //when

            //then
        }

        [Test]
        public async Task RemoveObject_SingleObjectDoesntExist_ThrowException()
        {
            //given

            //when

            //then
        }

        [Test]
        public async Task RemoveObject_FolderObjectExistWithoutRecursiveOption_ThrowException()
        {
            //given

            //when

            //then
        }

        [Test]
        public async Task RemoveObject_FolderObjectExistWithRecursiveOption_Removed()
        {
            //given

            //when

            //then
        }

        [Test]
        public async Task RemoveObject_RootObjectNotEmptyWithoutRecursiveOption_ThrowException()
        {
            //given

            //when

            //then
        }

        [Test]
        public async Task RemoveObject_RootObjectNotEmptyWithRecursiveOption_Removed()
        {
            //given

            //when

            //then
        }

        [Test]
        public async Task RemoveObject_ObjectNotExists_ThrowException()
        {
            //given

            //when

            //then
        }
        #endregion removeObject
    }
}