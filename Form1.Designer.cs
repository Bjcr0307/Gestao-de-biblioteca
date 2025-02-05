namespace V2_Biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAlunos = new System.Windows.Forms.TabPage();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnAtualizarAluno = new System.Windows.Forms.Button();
            this.btnExibirAlunos = new System.Windows.Forms.Button();
            this.dgvDadosAlunos = new System.Windows.Forms.DataGridView();
            this.btnInserirAluno = new System.Windows.Forms.Button();
            this.tbxMatricula = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLivros = new System.Windows.Forms.TabPage();
            this.btnExcluirLivro = new System.Windows.Forms.Button();
            this.btnAtualizarLivro = new System.Windows.Forms.Button();
            this.btnExibirLivros = new System.Windows.Forms.Button();
            this.dgvDadosLivros = new System.Windows.Forms.DataGridView();
            this.btnInserirLivro = new System.Windows.Forms.Button();
            this.tbxAutor = new System.Windows.Forms.TextBox();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabEmprestimos = new System.Windows.Forms.TabPage();
            this.btnExibirEmprestimos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDadosEmprestimos = new System.Windows.Forms.DataGridView();
            this.btnInserirEmprestimo = new System.Windows.Forms.Button();
            this.tbxCodLivro = new System.Windows.Forms.TextBox();
            this.tbxCodAluno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosAlunos)).BeginInit();
            this.tabLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosLivros)).BeginInit();
            this.tabEmprestimos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAlunos);
            this.tabControl1.Controls.Add(this.tabLivros);
            this.tabControl1.Controls.Add(this.tabEmprestimos);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 479);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAlunos
            // 
            this.tabAlunos.Controls.Add(this.btnExcluirAluno);
            this.tabAlunos.Controls.Add(this.btnAtualizarAluno);
            this.tabAlunos.Controls.Add(this.btnExibirAlunos);
            this.tabAlunos.Controls.Add(this.dgvDadosAlunos);
            this.tabAlunos.Controls.Add(this.btnInserirAluno);
            this.tabAlunos.Controls.Add(this.tbxMatricula);
            this.tabAlunos.Controls.Add(this.tbxNome);
            this.tabAlunos.Controls.Add(this.mtbCpf);
            this.tabAlunos.Controls.Add(this.label3);
            this.tabAlunos.Controls.Add(this.label2);
            this.tabAlunos.Controls.Add(this.label1);
            this.tabAlunos.Location = new System.Drawing.Point(4, 22);
            this.tabAlunos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAlunos.Name = "tabAlunos";
            this.tabAlunos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAlunos.Size = new System.Drawing.Size(438, 453);
            this.tabAlunos.TabIndex = 0;
            this.tabAlunos.Text = "Alunos";
            this.tabAlunos.UseVisualStyleBackColor = true;
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Location = new System.Drawing.Point(337, 144);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(90, 30);
            this.btnExcluirAluno.TabIndex = 33;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // btnAtualizarAluno
            // 
            this.btnAtualizarAluno.Location = new System.Drawing.Point(230, 144);
            this.btnAtualizarAluno.Name = "btnAtualizarAluno";
            this.btnAtualizarAluno.Size = new System.Drawing.Size(90, 30);
            this.btnAtualizarAluno.TabIndex = 32;
            this.btnAtualizarAluno.Text = "Atualizar";
            this.btnAtualizarAluno.UseVisualStyleBackColor = true;
            this.btnAtualizarAluno.Click += new System.EventHandler(this.btnAtualizarAluno_Click);
            // 
            // btnExibirAlunos
            // 
            this.btnExibirAlunos.Location = new System.Drawing.Point(124, 144);
            this.btnExibirAlunos.Name = "btnExibirAlunos";
            this.btnExibirAlunos.Size = new System.Drawing.Size(90, 30);
            this.btnExibirAlunos.TabIndex = 31;
            this.btnExibirAlunos.Text = "Exibir";
            this.btnExibirAlunos.UseVisualStyleBackColor = true;
            this.btnExibirAlunos.Click += new System.EventHandler(this.btnExibirAlunos_Click);
            // 
            // dgvDadosAlunos
            // 
            this.dgvDadosAlunos.AllowUserToAddRows = false;
            this.dgvDadosAlunos.AllowUserToDeleteRows = false;
            this.dgvDadosAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosAlunos.Location = new System.Drawing.Point(18, 202);
            this.dgvDadosAlunos.Name = "dgvDadosAlunos";
            this.dgvDadosAlunos.ReadOnly = true;
            this.dgvDadosAlunos.RowHeadersWidth = 51;
            this.dgvDadosAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosAlunos.Size = new System.Drawing.Size(409, 236);
            this.dgvDadosAlunos.TabIndex = 16;
            this.dgvDadosAlunos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDadosAlunos_CellMouseClick);
            // 
            // btnInserirAluno
            // 
            this.btnInserirAluno.Location = new System.Drawing.Point(18, 144);
            this.btnInserirAluno.Name = "btnInserirAluno";
            this.btnInserirAluno.Size = new System.Drawing.Size(90, 30);
            this.btnInserirAluno.TabIndex = 13;
            this.btnInserirAluno.Text = "Inserir";
            this.btnInserirAluno.UseVisualStyleBackColor = true;
            this.btnInserirAluno.Click += new System.EventHandler(this.btnInserirAluno_Click);
            // 
            // tbxMatricula
            // 
            this.tbxMatricula.Location = new System.Drawing.Point(94, 101);
            this.tbxMatricula.Name = "tbxMatricula";
            this.tbxMatricula.Size = new System.Drawing.Size(333, 20);
            this.tbxMatricula.TabIndex = 11;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(94, 18);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(333, 20);
            this.tbxNome.TabIndex = 10;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(94, 59);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(333, 20);
            this.mtbCpf.TabIndex = 9;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPF:";
            // 
            // tabLivros
            // 
            this.tabLivros.Controls.Add(this.btnExcluirLivro);
            this.tabLivros.Controls.Add(this.btnAtualizarLivro);
            this.tabLivros.Controls.Add(this.btnExibirLivros);
            this.tabLivros.Controls.Add(this.dgvDadosLivros);
            this.tabLivros.Controls.Add(this.btnInserirLivro);
            this.tabLivros.Controls.Add(this.tbxAutor);
            this.tabLivros.Controls.Add(this.tbxTitulo);
            this.tabLivros.Controls.Add(this.label4);
            this.tabLivros.Controls.Add(this.label5);
            this.tabLivros.Location = new System.Drawing.Point(4, 22);
            this.tabLivros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabLivros.Name = "tabLivros";
            this.tabLivros.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabLivros.Size = new System.Drawing.Size(438, 453);
            this.tabLivros.TabIndex = 1;
            this.tabLivros.Text = "Livros";
            this.tabLivros.UseVisualStyleBackColor = true;
            // 
            // btnExcluirLivro
            // 
            this.btnExcluirLivro.Location = new System.Drawing.Point(335, 97);
            this.btnExcluirLivro.Name = "btnExcluirLivro";
            this.btnExcluirLivro.Size = new System.Drawing.Size(90, 30);
            this.btnExcluirLivro.TabIndex = 33;
            this.btnExcluirLivro.Text = "Excluir";
            this.btnExcluirLivro.UseVisualStyleBackColor = true;
            this.btnExcluirLivro.Click += new System.EventHandler(this.btnExcluirLivro_Click);
            // 
            // btnAtualizarLivro
            // 
            this.btnAtualizarLivro.Location = new System.Drawing.Point(229, 97);
            this.btnAtualizarLivro.Name = "btnAtualizarLivro";
            this.btnAtualizarLivro.Size = new System.Drawing.Size(90, 30);
            this.btnAtualizarLivro.TabIndex = 32;
            this.btnAtualizarLivro.Text = "Atualizar";
            this.btnAtualizarLivro.UseVisualStyleBackColor = true;
            this.btnAtualizarLivro.Click += new System.EventHandler(this.btnAtualizarLivro_Click);
            // 
            // btnExibirLivros
            // 
            this.btnExibirLivros.Location = new System.Drawing.Point(123, 97);
            this.btnExibirLivros.Name = "btnExibirLivros";
            this.btnExibirLivros.Size = new System.Drawing.Size(90, 30);
            this.btnExibirLivros.TabIndex = 31;
            this.btnExibirLivros.Text = "Exibir";
            this.btnExibirLivros.UseVisualStyleBackColor = true;
            this.btnExibirLivros.Click += new System.EventHandler(this.btnExibirLivros_Click);
            // 
            // dgvDadosLivros
            // 
            this.dgvDadosLivros.AllowUserToAddRows = false;
            this.dgvDadosLivros.AllowUserToDeleteRows = false;
            this.dgvDadosLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosLivros.Location = new System.Drawing.Point(16, 150);
            this.dgvDadosLivros.Name = "dgvDadosLivros";
            this.dgvDadosLivros.ReadOnly = true;
            this.dgvDadosLivros.RowHeadersWidth = 51;
            this.dgvDadosLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosLivros.Size = new System.Drawing.Size(409, 288);
            this.dgvDadosLivros.TabIndex = 24;
            this.dgvDadosLivros.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDadosLivros_CellMouseClick);
            // 
            // btnInserirLivro
            // 
            this.btnInserirLivro.Location = new System.Drawing.Point(16, 97);
            this.btnInserirLivro.Name = "btnInserirLivro";
            this.btnInserirLivro.Size = new System.Drawing.Size(90, 30);
            this.btnInserirLivro.TabIndex = 23;
            this.btnInserirLivro.Text = "Inserir";
            this.btnInserirLivro.UseVisualStyleBackColor = true;
            this.btnInserirLivro.Click += new System.EventHandler(this.btnInserirLivro_Click);
            // 
            // tbxAutor
            // 
            this.tbxAutor.Location = new System.Drawing.Point(68, 57);
            this.tbxAutor.Name = "tbxAutor";
            this.tbxAutor.Size = new System.Drawing.Size(358, 20);
            this.tbxAutor.TabIndex = 22;
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(68, 20);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(358, 20);
            this.tbxTitulo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Autor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Título:";
            // 
            // tabEmprestimos
            // 
            this.tabEmprestimos.Controls.Add(this.dtpDataDevolucao);
            this.tabEmprestimos.Controls.Add(this.dtpDataEmprestimo);
            this.tabEmprestimos.Controls.Add(this.btnExibirEmprestimos);
            this.tabEmprestimos.Controls.Add(this.label9);
            this.tabEmprestimos.Controls.Add(this.dgvDadosEmprestimos);
            this.tabEmprestimos.Controls.Add(this.btnInserirEmprestimo);
            this.tabEmprestimos.Controls.Add(this.tbxCodLivro);
            this.tabEmprestimos.Controls.Add(this.tbxCodAluno);
            this.tabEmprestimos.Controls.Add(this.label6);
            this.tabEmprestimos.Controls.Add(this.label7);
            this.tabEmprestimos.Controls.Add(this.label8);
            this.tabEmprestimos.Location = new System.Drawing.Point(4, 22);
            this.tabEmprestimos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabEmprestimos.Name = "tabEmprestimos";
            this.tabEmprestimos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabEmprestimos.Size = new System.Drawing.Size(438, 453);
            this.tabEmprestimos.TabIndex = 2;
            this.tabEmprestimos.Text = "Empréstimos";
            this.tabEmprestimos.UseVisualStyleBackColor = true;
            // 
            // btnExibirEmprestimos
            // 
            this.btnExibirEmprestimos.Location = new System.Drawing.Point(123, 183);
            this.btnExibirEmprestimos.Name = "btnExibirEmprestimos";
            this.btnExibirEmprestimos.Size = new System.Drawing.Size(90, 30);
            this.btnExibirEmprestimos.TabIndex = 28;
            this.btnExibirEmprestimos.Text = "Exibir";
            this.btnExibirEmprestimos.UseVisualStyleBackColor = true;
            this.btnExibirEmprestimos.Click += new System.EventHandler(this.btnExibirEmprestimos_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Data Devolução:";
            // 
            // dgvDadosEmprestimos
            // 
            this.dgvDadosEmprestimos.AllowUserToAddRows = false;
            this.dgvDadosEmprestimos.AllowUserToDeleteRows = false;
            this.dgvDadosEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosEmprestimos.Location = new System.Drawing.Point(16, 239);
            this.dgvDadosEmprestimos.Name = "dgvDadosEmprestimos";
            this.dgvDadosEmprestimos.ReadOnly = true;
            this.dgvDadosEmprestimos.RowHeadersWidth = 51;
            this.dgvDadosEmprestimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosEmprestimos.Size = new System.Drawing.Size(409, 200);
            this.dgvDadosEmprestimos.TabIndex = 24;
            this.dgvDadosEmprestimos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDadosEmprestimos_CellMouseClick);
            // 
            // btnInserirEmprestimo
            // 
            this.btnInserirEmprestimo.Location = new System.Drawing.Point(16, 183);
            this.btnInserirEmprestimo.Name = "btnInserirEmprestimo";
            this.btnInserirEmprestimo.Size = new System.Drawing.Size(90, 30);
            this.btnInserirEmprestimo.TabIndex = 23;
            this.btnInserirEmprestimo.Text = "Inserir";
            this.btnInserirEmprestimo.UseVisualStyleBackColor = true;
            this.btnInserirEmprestimo.Click += new System.EventHandler(this.btnInserirEmprestimo_Click);
            // 
            // tbxCodLivro
            // 
            this.tbxCodLivro.Location = new System.Drawing.Point(156, 61);
            this.tbxCodLivro.Name = "tbxCodLivro";
            this.tbxCodLivro.Size = new System.Drawing.Size(270, 20);
            this.tbxCodLivro.TabIndex = 22;
            // 
            // tbxCodAluno
            // 
            this.tbxCodAluno.Location = new System.Drawing.Point(156, 20);
            this.tbxCodAluno.Name = "tbxCodAluno";
            this.tbxCodAluno.Size = new System.Drawing.Size(270, 20);
            this.tbxCodAluno.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data Empréstimo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cód. Aluno:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cod. Livro:";
            // 
            // dtpDataEmprestimo
            // 
            this.dtpDataEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmprestimo.Location = new System.Drawing.Point(156, 99);
            this.dtpDataEmprestimo.Name = "dtpDataEmprestimo";
            this.dtpDataEmprestimo.Size = new System.Drawing.Size(269, 20);
            this.dtpDataEmprestimo.TabIndex = 29;
            // 
            // dtpDataDevolucao
            // 
            this.dtpDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDevolucao.Location = new System.Drawing.Point(156, 139);
            this.dtpDataDevolucao.Name = "dtpDataDevolucao";
            this.dtpDataDevolucao.Size = new System.Drawing.Size(269, 20);
            this.dtpDataDevolucao.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 498);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Gerenciamento de Biblioteca";
            this.tabControl1.ResumeLayout(false);
            this.tabAlunos.ResumeLayout(false);
            this.tabAlunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosAlunos)).EndInit();
            this.tabLivros.ResumeLayout(false);
            this.tabLivros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosLivros)).EndInit();
            this.tabEmprestimos.ResumeLayout(false);
            this.tabEmprestimos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosEmprestimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAlunos;
        private System.Windows.Forms.TabPage tabLivros;
        private System.Windows.Forms.TabPage tabEmprestimos;
        private System.Windows.Forms.TextBox tbxMatricula;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDadosAlunos;
        private System.Windows.Forms.Button btnInserirAluno;
        private System.Windows.Forms.DataGridView dgvDadosLivros;
        private System.Windows.Forms.Button btnInserirLivro;
        private System.Windows.Forms.TextBox tbxAutor;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDadosEmprestimos;
        private System.Windows.Forms.Button btnInserirEmprestimo;
        private System.Windows.Forms.TextBox tbxCodLivro;
        private System.Windows.Forms.TextBox tbxCodAluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExibirEmprestimos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnAtualizarAluno;
        private System.Windows.Forms.Button btnExibirAlunos;
        private System.Windows.Forms.Button btnExcluirLivro;
        private System.Windows.Forms.Button btnAtualizarLivro;
        private System.Windows.Forms.Button btnExibirLivros;
        private System.Windows.Forms.DateTimePicker dtpDataDevolucao;
        private System.Windows.Forms.DateTimePicker dtpDataEmprestimo;
    }
}

