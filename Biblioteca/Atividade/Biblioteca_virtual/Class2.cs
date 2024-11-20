using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Biblioteca_virtual
{
    internal class Usuario{
        private String nome;
        private int numId;
        private List<Livro> usuarioLivros; 

        public Usuario(String nome, int numId) {
            this.Nome = nome;
            this.NumId = numId;
            this.usuarioLivros = new List<Livro>();
        }

        public int NumId { get => numId; set => numId = value; }
        public string Nome { get => nome; set => nome = value; }
        internal List<Livro> UsuarioLivros { get => usuarioLivros; set => usuarioLivros = value; }
        public override String ToString()
        {
            return nome;
        }
    }
    
}
