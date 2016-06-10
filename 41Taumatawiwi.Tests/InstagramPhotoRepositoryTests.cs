using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _41Taumatawiwi.Core.Repositories.Instagram;

namespace _41Taumatawiwi.Tests
{
    [TestClass]
    public class InstagramPhotoRepositoryTests
    {
        [TestMethod]
        [TestCategory("Integration")]
        [Timeout(1000)]
        public void Ensure_all_photos_can_be_retrieved()
        {
            var photoRepository = new InstagramPhotoRepository();

            var photos = photoRepository.GetAll();

            Assert.IsTrue(photos.Count > 0);
        }
    }
}
