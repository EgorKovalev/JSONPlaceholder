using JSONPlaceholder.Core;
using JSONPlaceholder.JsonObjects;
using JSONPlaceholder.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace JSONPlaceholder.Tests
{
    [TestClass]
    public class PostsTests
    {
        [TestCategory("Posts"), TestMethod()]
        public void Get_Posts_List()
        {
            // arrange  
            var provider = new HttpProvider();

            // act  
            var posts = provider.ExecuteApiMethod<List<Post>>(Posts.Get());

            // assert  
            Assert.IsTrue(posts.Count > 0);
        }

        [TestCategory("Posts"), TestMethod()]
        public void Get_Third_Post()
        {
            // arrange  
            var provider = new HttpProvider();

            // act  
            var post = provider.ExecuteApiMethod<Post>(Posts.Get("3"));

            // assert  
            Assert.IsTrue(post.id == 3);
        }

        [TestCategory("Comments"), TestMethod()]
        public void Get_Comment_For_First_Post()
        {
            // arrange  
            var provider = new HttpProvider();

            // act  
            var comment = provider.ExecuteApiMethod<List<Comment>>(Comments.Get("1"));

            // assert  
            Assert.IsTrue(comment.Any(c => c.postId == 1));
        }
    }
}
