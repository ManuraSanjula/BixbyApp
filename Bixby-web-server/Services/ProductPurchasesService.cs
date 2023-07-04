using Bixby_web_server.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bixby_web_server.Services
{
    public class ProductPurchasesService
    {
        private readonly IMongoCollection<ProductPurchases> _productPurchasesCollection;

        public ProductPurchasesService()
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb+srv://geethaliyanage23:1dJz8r5mX6nfkoG6@cluster0.xdb3qmc.mongodb.net/?retryWrites=true&w=majority"));
            var client = new MongoClient(settings);

            IMongoDatabase database = client.GetDatabase("BixByApp");
            _productPurchasesCollection = database.GetCollection<ProductPurchases>("productPurchases");
        }

        public async Task<List<ProductPurchases>> GetAllProductPurchasesAsync()
        {
            return await _productPurchasesCollection.Find(_ => true).ToListAsync();
        }

        public async Task<ProductPurchases> GetProductPurchaseByIdAsync(ObjectId id)
        {
            return await _productPurchasesCollection.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<ProductPurchases>> GetProductPurchasesByCustomerIdAsync(ObjectId customerId)
        {
            return await _productPurchasesCollection.Find(p => p.cutomerId == customerId).ToListAsync();
        } 
        public async Task<ProductPurchases> GetProductPurchasesByOrderIdAsync(ObjectId orderId)
        {
            return await _productPurchasesCollection.Find(p => p.orderId == orderId).FirstOrDefaultAsync();
        }

        public async Task<List<ProductPurchases>> GetProductPurchasesByOwnerIdAsync(String ownerId)
        {
            return await _productPurchasesCollection.Find(p => p.ownerId == ownerId).ToListAsync();
        }

        public async Task CreateProductPurchaseAsync(ProductPurchases productPurchase)
        {
            await _productPurchasesCollection.InsertOneAsync(productPurchase);
        }

        public async Task<bool> UpdateProductPurchaseAsync(ObjectId id, ProductPurchases updatedProductPurchase)
        {
            var updateResult = await _productPurchasesCollection.ReplaceOneAsync(p => p.Id == id, updatedProductPurchase);
            return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;
        }

        public async Task<bool> DeleteProductPurchaseAsync(ObjectId id)
        {
            var deleteResult = await _productPurchasesCollection.DeleteOneAsync(p => p.Id == id);
            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
        }
    }
}