using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookApi.Domain.Customer.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get;set; }
        [BsonElement("name")]
        public string name { get; set; }
        
        [BsonRepresentation(BsonType.Double)]
        public decimal balance { get; set; }

        public void addAmount(decimal value)
        {
            this.balance = this.balance + value;
        }
    }
}