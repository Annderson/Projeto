using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace projeto_lista.Entities
{
    public class Lanche
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nome")]
        public string nome { get; set; }

        [BsonElement("ingredientes")]
        public string[]  ingredientes { get; set; }
    }
}