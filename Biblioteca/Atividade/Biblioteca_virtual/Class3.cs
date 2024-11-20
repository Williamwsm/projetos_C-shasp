using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Atividade.Biblioteca_virtual
        {
            internal class Biblioteca{
        private List<Livro> livrosDisponiveis;
        private List<Livro> livrosEmprestados;

        internal List<Livro> LivrosDisponiveis { get => livrosDisponiveis; set => livrosDisponiveis = value; }
        internal List<Livro> LivrosEmprestados { get => livrosEmprestados; set => livrosEmprestados = value; }

        public Biblioteca(){
            this.LivrosDisponiveis = new List<Livro>();
            this.LivrosEmprestados = new List<Livro>();
        }

        public void addLivro(Livro livro){
            LivrosDisponiveis.Add(livro);
        }
        public void emprestarLivro(Livro livro, Usuario usuario)
        {
            if(livro.Status == true) {
                LivrosEmprestados.Add(livro);
                livro.Status = false;
                LivrosDisponiveis.Remove(livro);
                usuario.UsuarioLivros.Add(livro);
            }
            else
            {
                throw new Exception("livro indisponivel no momento");
            }
        }

        public void devolverLivro(Livro livro, Usuario usuario)
        {
            if(livro.Status == true)
            {
                throw new Exception("Esse livro ja foi devolvido");
            }
            else
            {
                if (!usuario.UsuarioLivros.Contains(livro) ) { throw new Exception("Voce nao possui esse livro"); } else
                {
                    usuario.UsuarioLivros.Remove(livro);
                    LivrosEmprestados.Remove(livro);
                    LivrosDisponiveis.Add(livro);
                    livro.Status = true;
                       
                }
                
            }

        }
        public String mostrarLivrosDisp()
        {
            String listaLivros = "";
            foreach (var l in LivrosDisponiveis)
            {
                listaLivros += l.Titulo +"\n";
            }
            return listaLivros;
        }
        public bool buscarLivro(String titulo) {foreach (var l in LivrosDisponiveis)
            {
                if (l.Titulo.Equals(titulo)) { return true; }
            } return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
