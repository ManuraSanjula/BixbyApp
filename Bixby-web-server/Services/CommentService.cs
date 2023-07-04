using Bixby_web_server.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BixbyShop_LK.Models.Comments.Services
{
    public class CommentService
    {
        private readonly IMongoCollection<Comment> commentCollection;

        public CommentService()
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb+srv://geethaliyanage23:1dJz8r5mX6nfkoG6@cluster0.xdb3qmc.mongodb.net/?retryWrites=true&w=majority"));
            var client = new MongoClient(settings);

            IMongoDatabase database = client.GetDatabase("BixByApp");
            this.commentCollection = database.GetCollection<Comment>("Comment");
        }

        public static double CalculateTotalRating(long totalComments, long commentRating)
        {
            if (totalComments == 0)
                return 0;

            // Calculate the average rating per comment
            double averageRating = (double)commentRating / totalComments;

            // Calculate the estimated total rating
            double totalRating = averageRating * totalComments;

            return totalRating;
        }

        public List<Comment> GetAllComments()
        {
            return commentCollection.Find(_ => true).ToList();
        }

        public List<Comment> GetAllCommentsByUserName(ObjectId userId)
        {
            return commentCollection.Find(_ => _.User == userId).ToList();
        }

        public List<Comment> GetAllCommentsByShopItemName(ObjectId item)
        {
            return commentCollection.Find(_ => _.ShopItem == item).ToList();
        }

        public Comment GetCommentById(ObjectId commentId)
        {
            return commentCollection.Find(comment => comment.Id == commentId).FirstOrDefault();
        }

        public async Task CreateComment(Comment comment)
        {
           await commentCollection.InsertOneAsync(comment);
        }

        public void UpdateComment(ObjectId commentId, Comment updatedComment)
        {
            commentCollection.ReplaceOne(comment => comment.Id == commentId, updatedComment);
        }

        public void DeleteComment(ObjectId commentId)
        {
            commentCollection.DeleteOne(comment => comment.Id == commentId);
        }
    }
}
