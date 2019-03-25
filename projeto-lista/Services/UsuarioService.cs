using System.Collections.Generic;
using System.Linq;
using projeto_lista.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace projeto_lista.Services
{
    public class UsuarioService
    {
        private readonly IMongoCollection<Usuario> _user;

        public UsuarioService(IConfiguration config) {
            var client = new MongoClient(config.GetConnectionString("lanchonete"));
            var database = client.GetDatabase("lanchonete");
            _user = database.GetCollection<Usuario>("usuarios");
        }
        
        public List<Usuario> Get() {
            return _user.Find(user => true).ToList();
        }

        public Usuario Get(string id) {
            return _user.Find<Usuario>(user => user.Id == id).FirstOrDefault();
        }

        public Usuario GetV(string email, string senha) {
            return _user.Find<Usuario>(user => user.email == email && user.senha == senha).FirstOrDefault();
        }

        public void Add(Usuario usuario)
        {
            _user.InsertOne(usuario);
        }
        
        public Usuario Autenticar(string nome, string senha) {

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha)) {
                return null;
            }

            var user = _user.Find<Usuario>(x => x.nome == nome && x.senha==senha).FirstOrDefault();

            if (user == null) {
                return null;
            }

            return user;
        }

        public void Update(string id, Usuario user) {
            _user.ReplaceOne(u => u.Id == user.Id, user);
        }

         public void Remove(Usuario user)
        {
            _user.DeleteOne(u => u.Id == user.Id);
        }

        public void Remove(string id)
        {
            _user.DeleteOne(u => u.Id == id);
        }        
    }
}