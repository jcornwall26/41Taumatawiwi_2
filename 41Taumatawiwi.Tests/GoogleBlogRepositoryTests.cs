using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Google.Apis.Services;
using Google.Apis.Blogger.v3;
using System.Text;
using Google.Apis.Auth.OAuth2;

namespace _41Taumatawiwi.Tests
{
    [TestClass]
    public class GoogleBlogRepositoryTests
    {
        [TestMethod]
        [TestCategory("Integration")]
        public void Ensure_blogger_posts_collection_can_be_successfully_retrieved()
        {
            var ini = new Google.Apis.Services.BaseClientService.Initializer();
            ini.ApiKey = "AIzaSyBT6bstW0fA1Y3Jwz3EMziRhk6I0ChByCI";

            var bloggerService = new BloggerService(ini);

            var postsR = new PostsResource(bloggerService);

            var posts =  postsR.List("4414387084121335697").Execute();

            Assert.IsTrue(posts.Items.Any());
        }
    }
}
