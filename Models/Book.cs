using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookApi.Models
{
    public class Book {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set;}
        [BsonElement("name")]
        public string name { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }
        public string author { get; set; }
    }
}