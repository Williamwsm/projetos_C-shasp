using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade.Biblioteca_virtual;

namespace Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            Usuario usuario = new Usuario("Rita", 276);
            Usuario usuario1 = new Usuario("malu", 323);

            Livro livro = new Livro("o manco que passou a perna", "Nilton Cesar","terror", 2023);
            Livro livro1 = new Livro("Loucuras da paixao", "Janny Raissa", "romance", 2025);
            Livro livro2 = new Livro("Como ser um viado com estilo", "Pedrao","tutorial", 2022);
            Livro livro3 = new Livro("Do pao ao seu primeiro estagio", "Kaylaine Assuncao","drama", 2025);
            biblioteca.addLivro(livro);
            biblioteca.addLivro(livro1);
            biblioteca.addLivro(livro2);
            biblioteca.addLivro(livro3);
            Console.WriteLine(biblioteca.mostrarLivrosDisp());
        

        }
    }
}
