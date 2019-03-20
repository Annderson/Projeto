using System.Collections.Generic;
using System.Linq;
using projeto_lista.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace projeto_lista.Services
{
    public class LancheService
    {
        private readonly IMongoCollection<Lanche> _lanche;

        public LancheService(IConfiguration config) {
            var client = new MongoClient(config.GetConnectionString("lanchonete"));
            var database = client.GetDatabase("lanchonete");
            _lanche = database.GetCollection<Lanche>("lanches");
        }

        public List<Lanche> Get() {
            return _lanche.Find(lanche => true).ToList();
        }

        public Lanche Get(string id) {
            return _lanche.Find<Lanche>(lanche => lanche.Id == id).FirstOrDefault();
        }
        
        public Lanche Craate(Lanche lanche) {
            _lanche.InsertOne(lanche);
            return lanche;
        }

        public void Update(string id, Lanche lanche) {
            _lanche.ReplaceOne(lan => lan.Id == lanche.Id, lanche);
        }

         public void Remove(Lanche lanche)
        {
            _lanche.DeleteOne(lan => lan.Id == lanche.Id);
        }

        public void Remove(string id)
        {
            _lanche.DeleteOne(lan => lan.Id == id);
        }
    }
}