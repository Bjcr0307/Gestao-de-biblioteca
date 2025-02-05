
namespace V2_Biblioteca
{
    internal class Livro
    {
        private string titulo;
        private string autor;

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
    }
}
