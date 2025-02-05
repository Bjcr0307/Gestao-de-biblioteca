
namespace V2_Biblioteca
{
    internal class Aluno
    {
        private string nome;
        private string cpf;
        private string matricula;

        public Aluno(string nome, string cpf, string matricula)
        {
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Matricula { get => matricula; set => matricula = value; }
    }
}
