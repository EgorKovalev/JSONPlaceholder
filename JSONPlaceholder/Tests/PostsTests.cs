using JSONPlaceholder.Core;
using JSONPlaceholder.JsonObjects;
using JSONPlaceholder.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace JSONPlaceholder.Tests
{
    [TestClass]
    public class PostsTests
    {
        [TestMethod]
        public void Get_Posts_List()
        {
            // arrange  
            var provider = new HttpProvider();

            // act  
            var posts = provider.ExecuteApiMethod<List<Post>>(Posts.Get());

            // assert  
            Assert.IsTrue(posts.Count > 0);
        }

        [TestMethod]
        public void Get_Third_Post()
        {
            // arrange  
            var provider = new HttpProvider();

            // act  
            var post = provider.ExecuteApiMethod<Post>(Posts.Get("3"));

            // assert  
            Assert.IsTrue(post.id == 3);
        }
    }
}
