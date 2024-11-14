using System;

namespace Core.Models {
    public class UsuarioModels {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        private UsuarioModels() { }

        public UsuarioModels(string id, string nome, string email, string telefone, string cpf, string senha) {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cpf;
            Senha = senha;
        }

        public UsuarioModels(string nome, string email, string telefone) {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}
