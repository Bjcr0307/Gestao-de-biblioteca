using Npgsql;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace V2_Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserirAluno_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(tbxNome.Text, mtbCpf.Text, tbxMatricula.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection conn = new NpgsqlConnection(conexao); // Cria uma conexao com o BD

            conn.Open(); // Abre a conexao com o BD

            // Verificar se o CPF já existe no BD
            string verificaCpfQuery = $"SELECT COUNT(*) FROM aluno WHERE cpf = '{aluno.Cpf}'";

            using (NpgsqlCommand verificaCpfCommand = new NpgsqlCommand(verificaCpfQuery, conn))
            {
                int count = Convert.ToInt32(verificaCpfCommand.ExecuteScalar());

                if (count > 0)
                {
                    conn.Close();
                    MessageBox.Show("Aluno com o CPF informado já existe. Não é possível inserir duplicatas.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sair do método se o CPF já existir
                }
            }

            // Se o CPF não existir, realizar a inserção
            string commandText =
                $"INSERT INTO aluno(nome, cpf, matricula)" +
                $" VALUES('{aluno.Nome}', '{aluno.Cpf}', {aluno.Matricula})";

            using (NpgsqlCommand comando = new NpgsqlCommand(commandText, conn))
            {
                comando.ExecuteNonQuery();
            }

            conn.Close();

            MessageBox.Show("Aluno Inserido com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            ExibirDados(dgvDadosAlunos, "aluno");

            LimparTextBox();
        }

        private void btnExibirAlunos_Click(object sender, EventArgs e)
        {
            ExibirDados(dgvDadosAlunos, "aluno");
        }

        private void btnAtualizarAluno_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(tbxNome.Text, mtbCpf.Text, tbxMatricula.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection conn = new NpgsqlConnection(conexao); // Cria uma conexao com o BD

            conn.Open(); // Abre a conexao com o BD

            string commandText =
                $"UPDATE aluno" +
                $" SET nome = '{aluno.Nome}', cpf = '{aluno.Cpf}', matricula = {aluno.Matricula}" +
                $" WHERE id_aluno = {dgvDadosAlunos.SelectedRows[0].Index + 1}";

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, conn))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            conn.Close(); MessageBox.Show("Cadastro Atualizado com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            ExibirDados(dgvDadosAlunos, "aluno");

            LimparTextBox();
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            string cpf = mtbCpf.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection conn = new NpgsqlConnection(conexao); // Cria uma conexao com o BD

            conn.Open(); // Abre a conexao com o BD

            string commandText =
                $"DELETE FROM aluno" +
                $" WHERE cpf = '{cpf}'";

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, conn))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            conn.Close();

            MessageBox.Show("Cadastro Excluído com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            ExibirDados(dgvDadosAlunos, "aluno");

            LimparTextBox();
        }

        private void dgvDadosAlunos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxNome.Text = Convert.ToString(dgvDadosAlunos.Rows[e.RowIndex].Cells[1].Value);
            mtbCpf.Text = Convert.ToString(dgvDadosAlunos.Rows[e.RowIndex].Cells[2].Value);
            tbxMatricula.Text = Convert.ToString(dgvDadosAlunos.Rows[e.RowIndex].Cells[3].Value);
        }

        private void btnInserirLivro_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(tbxTitulo.Text, tbxAutor.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection conn = new NpgsqlConnection(conexao);

            conn.Open();

            // Verificar se o livro já existe no BD
            string verificaLivroQuery = $"SELECT COUNT(*) FROM livro WHERE titulo = '{livro.Titulo}'";

            using (NpgsqlCommand verificaCpfCommand = new NpgsqlCommand(verificaLivroQuery, conn))
            {
                int count = Convert.ToInt32(verificaCpfCommand.ExecuteScalar());

                if (count > 0)
                {
                    conn.Close();
                    MessageBox.Show("Livro com o título informado já existe. Não é possível inserir duplicatas.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Se o livro não existir, realizar a inserção
            string commandText =
                $"INSERT INTO livro(titulo, autor)" +
                $" VALUES('{livro.Titulo}', '{livro.Autor}')";

            using (NpgsqlCommand comando = new NpgsqlCommand(commandText, conn))
            {
                comando.ExecuteNonQuery();
            }

            conn.Close();

            MessageBox.Show("Livro Inserido com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            ExibirDados(dgvDadosLivros, "livro");

            LimparTextBox();
        }

        private void btnExibirLivros_Click(object sender, EventArgs e)
        {
            ExibirDados(dgvDadosLivros, "livro");
        }

        private void btnAtualizarLivro_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(tbxTitulo.Text, tbxAutor.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection conn = new NpgsqlConnection(conexao);

            conn.Open();

            string commandText =
                $"UPDATE livro" +
                $" SET titulo = '{livro.Titulo}', autor = '{livro.Autor}'" +
                $" WHERE id_livro = {dgvDadosLivros.SelectedRows[0].Index + 1}";

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, conn))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            conn.Close(); MessageBox.Show("Livro Atualizado com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            ExibirDados(dgvDadosLivros, "livro");

            LimparTextBox();
        }

        private void btnExcluirLivro_Click(object sender, EventArgs e)
        {
            string titulo = tbxTitulo.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection conn = new NpgsqlConnection(conexao);

            conn.Open();

            string commandText =
                $"DELETE FROM livro" +
                $" WHERE titulo = '{titulo}'";

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, conn))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            conn.Close();

            MessageBox.Show("Livro Excluído com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            ExibirDados(dgvDadosLivros, "livro");

            LimparTextBox();
        }

        private void dgvDadosLivros_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxTitulo.Text = Convert.ToString(dgvDadosLivros.Rows[e.RowIndex].Cells[1].Value);
            tbxAutor.Text = Convert.ToString(dgvDadosLivros.Rows[e.RowIndex].Cells[2].Value);
        }

        private void btnInserirEmprestimo_Click(object sender, EventArgs e)
        {
            DateTime dataEmprestimo = dtpDataEmprestimo.Value;
            DateTime dataDevolucao = dtpDataDevolucao.Value;

            Emprestimo emprestimo = new Emprestimo(tbxCodAluno.Text, tbxCodLivro.Text, dataEmprestimo.ToString("yyyy-MM-dd"), dataDevolucao.ToString("yyyy-MM-dd"));

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection conn = new NpgsqlConnection(conexao);

            conn.Open();

            string commandText =
                $"INSERT INTO emprestimo(id_aluno, id_livro, data_emprestimo, data_devolucao)" +
                $" VALUES('{emprestimo.CodAluno}', '{emprestimo.CodLivro}', '{emprestimo.DataEmprestimo}', '{emprestimo.DataDevolucao}')";

            using (NpgsqlCommand comando = new NpgsqlCommand(commandText, conn))
            {
                comando.ExecuteNonQuery();
            }

            conn.Close();

            MessageBox.Show("Empréstimo Inserido com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            ExibirDados(dgvDadosEmprestimos, "emprestimo");

            LimparTextBox();
        }

        private void btnExibirEmprestimos_Click(object sender, EventArgs e)
        {
            ExibirDados(dgvDadosEmprestimos, "emprestimo");
        }

        private void dgvDadosEmprestimos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxCodAluno.Text = Convert.ToString(dgvDadosEmprestimos.Rows[e.RowIndex].Cells[1].Value);
            tbxCodLivro.Text = Convert.ToString(dgvDadosEmprestimos.Rows[e.RowIndex].Cells[2].Value);
            if (DateTime.TryParseExact(Convert.ToString(dgvDadosEmprestimos.Rows[e.RowIndex].Cells[3].Value), 
                "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataEmprestimo))
            {
                // Atribui a data convertida ao DateTimePicker
                dtpDataEmprestimo.Value = dataEmprestimo;
            }
            if (DateTime.TryParseExact(Convert.ToString(dgvDadosEmprestimos.Rows[e.RowIndex].Cells[4].Value),
                "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataDevolucao))
            {
                // Atribui a data convertida ao DateTimePicker
                dtpDataDevolucao.Value = dataDevolucao;
            }
        }

        void ExibirDados(DataGridView dgv, string tabela)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection conn = new NpgsqlConnection(conexao);

            conn.Open();

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas string

            string commandText = $"SELECT * FROM {tabela} ORDER BY id_{tabela}";

            using (NpgsqlDataAdapter adpt = new NpgsqlDataAdapter(commandText, conn)) // faz a ligacao entre o BD e o DataTable
            {
                adpt.Fill(dt);
            }

            dgv.DataSource = dt;

            conn.Close();
        }

        void LimparTextBox()
        {
            tbxNome.Text = string.Empty;
            mtbCpf.Text = string.Empty;
            tbxMatricula.Text = string.Empty;
            tbxTitulo.Text = string.Empty;
            tbxAutor.Text = string.Empty;
            tbxCodAluno.Text = string.Empty;
            tbxCodLivro.Text = string.Empty;
            dtpDataEmprestimo.Value = DateTime.Now;
            dtpDataDevolucao.Value = DateTime.Now;
        }
    }
}
