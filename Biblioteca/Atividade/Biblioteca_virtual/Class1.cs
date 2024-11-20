using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Biblioteca_virtual
{
    internal class Livro{
        private String titulo;
        private String autor;
        private String categoria;
        private bool status;
        private int anoPublicacao;
        public bool Status { get => status; set => status = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int AnoPublicacao { get => anoPublicacao; set => anoPublicacao = value; }

        public Livro(String titulo, String autor, String categoria, int anoPublicacao ) {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Categoria = categoria;
            this.Status = true;
            this.AnoPublicacao = anoPublicacao;
        }

        public override string ToString()
        {
            return $"Titulo: {Titulo}";
        }


    }
}
