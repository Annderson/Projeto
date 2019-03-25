using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace projeto_lista.Entities
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }  

        [BsonElement("nome")]
        public string nome {get ; set; }

        [BsonElement("senha")]
        public string senha {get ; set; }
        
        [BsonElement("email")]
        public string email {get ; set; }
    }
}