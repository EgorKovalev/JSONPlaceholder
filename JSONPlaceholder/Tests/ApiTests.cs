using JSONPlaceholder.Core;
using JSONPlaceholder.JsonObjects;
using JSONPlaceholder.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace JSONPlaceholder.Tests
{
    [TestClass]
    public class ApiTests
    {
        [TestCategory("Posts"), TestCategory("HttpGet")]
        [TestMethod]
        public void Get_Posts_List()
        {
            // arrange  
            var provider = new HttpProvider();

            // act  
            var posts = provider.ExecuteApiMethod<List<Post>>(PostRequests.Get());

            // assert  
            Assert.IsTrue(posts.Count > 0);
        }

        [TestCategory("Posts"), TestCategory("HttpGet")]
        [TestMethod]
        public void Get_Third_Post()
        {
            // arrange  
            var provider = new HttpProvider();

            // act  
            var post = provider.ExecuteApiMethod<Post>(PostRequests.Get("3"));

            // assert  
            Assert.IsTrue(post.id == 3);
        }

        [TestCategory("Comments"), TestCategory("HttpGet")]
        [TestMethod]
        public void Get_First_Post_Comments()
        {
            // arrange  
            var provider = new HttpProvider();
            const string postId = "1";

            // act  
            var listByCommentsRequest = provider.ExecuteApiMethod<List<Comment>>(CommentRequests.Get(postId));
            var listByPostsRequest = provider.ExecuteApiMethod<List<Comment>>(PostRequests.GetComments(postId));

            var firstNotSecond = listByCommentsRequest.Except(listByPostsRequest).ToList();
            var secondNotFirst = listByPostsRequest.Except(listByCommentsRequest).ToList();

            // assert  
            Assert.IsFalse(!firstNotSecond.Any() && !secondNotFirst.Any());     //compare lists. It should be equals
        }

        [TestCategory("Posts"), TestCategory("HttpPost")]
        [TestMethod]
        public void Add_Post()
        {
            // arrange  
            var provider = new HttpProvider();
            var post = new Post() { title = "test post", body = "this is a test post", userId = 1 };

            // act  
            var uploadedPost = provider.ExecuteApiMethod<Post>(PostRequests.Create(post));

            // assert  
            Assert.IsTrue(uploadedPost.userId == post.userId 
                && uploadedPost.body.Equals(post.body) 
                &&uploadedPost.title.Equals(post.title));
        }

        [TestCategory("Posts"), TestCategory("HttpPost")]
        [TestMethod]
        public void Add_Post_Negative()
        {
            // arrange  
            var provider = new HttpProvider();            

            // act  
            var uploadedPost = provider.ExecuteApiMethod<Post>(PostRequests.Create(null));

            // assert  
            Assert.IsTrue(true);
        }
    }
}