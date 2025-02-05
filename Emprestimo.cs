
namespace V2_Biblioteca
{
    internal class Emprestimo
    {
        private string codAluno;
        private string codLivro;
        private string dataEmprestimo;
        private string dataDevolucao;

        public Emprestimo(string codAluno, string codLivro, string dataEmprestimo, string dataDevolucao)
        {
            CodAluno = codAluno;
            CodLivro = codLivro;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
        }

        public string CodAluno { get => codAluno; set => codAluno = value; }
        public string CodLivro { get => codLivro; set => codLivro = value; }
        public string DataEmprestimo { get => dataEmprestimo; set => dataEmprestimo = value; }
        public string DataDevolucao { get => dataDevolucao; set => dataDevolucao = value; }
    }
}
