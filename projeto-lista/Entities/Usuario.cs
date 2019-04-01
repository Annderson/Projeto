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
        public string nome { get ; set; }

        [BsonElement("cpf")]
        public string cpf { get ; set; }
        
        [BsonElement("dataNasc")]
        public string dataNasc { get ; set; }

        [BsonElement("cep")]
        public string cep { get ; set; }

        [BsonElement("numero")]
        public string numero { get ; set; }

        [BsonElement("endereco")]
        public string endereco { get ; set; }

        [BsonElement("cidade")]
        public string cidade { get ; set; }

        [BsonElement("estado")]
        public string estado { get ; set; }

        [BsonElement("email")]
        public string email { get ; set; }
        
        [BsonElement("senha")]
        public string senha {get ; set; }
    }
}