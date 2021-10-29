namespace TP08_200581
{
    partial class FrmCadastroNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroNotas));
            this.PnlEntradaDeDados = new System.Windows.Forms.Panel();
            this.TxtBxSerie = new System.Windows.Forms.TextBox();
            this.LblOnlyView4 = new System.Windows.Forms.Label();
            this.GrpBoxEntradaNotas = new System.Windows.Forms.GroupBox();
            this.TxtBx4Semestre = new System.Windows.Forms.TextBox();
            this.LblOnlyView7 = new System.Windows.Forms.Label();
            this.LblOnlyView6 = new System.Windows.Forms.Label();
            this.TxtBx3Semestre = new System.Windows.Forms.TextBox();
            this.TxtBx2Semestre = new System.Windows.Forms.TextBox();
            this.LblOnlyView5 = new System.Windows.Forms.Label();
            this.TxtBx1Semestre = new System.Windows.Forms.TextBox();
            this.LblOnlyView3 = new System.Windows.Forms.Label();
            this.TxtBxNumeroMatricula = new System.Windows.Forms.TextBox();
            this.LblOnlyView2 = new System.Windows.Forms.Label();
            this.TxtBxNomeDisciplina = new System.Windows.Forms.TextBox();
            this.LblOnlyView1 = new System.Windows.Forms.Label();
            this.MnStrExportar = new System.Windows.Forms.MenuStrip();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porLinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porColunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnCadastrarAluno = new System.Windows.Forms.Button();
            this.TxtBxConceito = new System.Windows.Forms.TextBox();
            this.LblOnlyView9 = new System.Windows.Forms.Label();
            this.TxtBxMediaFinal = new System.Windows.Forms.TextBox();
            this.LblOnlyView8 = new System.Windows.Forms.Label();
            this.PnlGuiDePesquisa = new System.Windows.Forms.Panel();
            this.TxtBxFiltro = new System.Windows.Forms.TextBox();
            this.CmbBxProcurarPor = new System.Windows.Forms.ComboBox();
            this.LblOnlyView11 = new System.Windows.Forms.Label();
            this.LblOnlyView10 = new System.Windows.Forms.Label();
            this.DtStCadastroDados = new System.Data.DataSet();
            this.DtDadosAlunos = new System.Data.DataTable();
            this.DtClnNomeDaDisciplina = new System.Data.DataColumn();
            this.DtClnSerie = new System.Data.DataColumn();
            this.DtClnMatricula = new System.Data.DataColumn();
            this.DtCln1Bimestre = new System.Data.DataColumn();
            this.DtCln2Bimestre = new System.Data.DataColumn();
            this.DtCln3Bimestre = new System.Data.DataColumn();
            this.DtCln4Bimestre = new System.Data.DataColumn();
            this.DtClnMedia = new System.Data.DataColumn();
            this.DtClnConceito = new System.Data.DataColumn();
            this.BndSrcCadastroDados = new System.Windows.Forms.BindingSource(this.components);
            this.DtGrdViewDados = new System.Windows.Forms.DataGridView();
            this.disciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sérieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matrículaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1ºBimestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2ºBimestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3ºBimestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota4ºBimestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.médiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlEntradaDeDados.SuspendLayout();
            this.GrpBoxEntradaNotas.SuspendLayout();
            this.MnStrExportar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlGuiDePesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtStCadastroDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtDadosAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BndSrcCadastroDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdViewDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlEntradaDeDados
            // 
            this.PnlEntradaDeDados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PnlEntradaDeDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlEntradaDeDados.Controls.Add(this.TxtBxSerie);
            this.PnlEntradaDeDados.Controls.Add(this.LblOnlyView4);
            this.PnlEntradaDeDados.Controls.Add(this.GrpBoxEntradaNotas);
            this.PnlEntradaDeDados.Controls.Add(this.TxtBxNumeroMatricula);
            this.PnlEntradaDeDados.Controls.Add(this.LblOnlyView2);
            this.PnlEntradaDeDados.Controls.Add(this.TxtBxNomeDisciplina);
            this.PnlEntradaDeDados.Controls.Add(this.LblOnlyView1);
            this.PnlEntradaDeDados.Controls.Add(this.MnStrExportar);
            this.PnlEntradaDeDados.Location = new System.Drawing.Point(2, 3);
            this.PnlEntradaDeDados.Name = "PnlEntradaDeDados";
            this.PnlEntradaDeDados.Size = new System.Drawing.Size(720, 246);
            this.PnlEntradaDeDados.TabIndex = 0;
            // 
            // TxtBxSerie
            // 
            this.TxtBxSerie.Location = new System.Drawing.Point(541, 45);
            this.TxtBxSerie.MaxLength = 4;
            this.TxtBxSerie.Name = "TxtBxSerie";
            this.TxtBxSerie.Size = new System.Drawing.Size(54, 20);
            this.TxtBxSerie.TabIndex = 6;
            this.TxtBxSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            // 
            // LblOnlyView4
            // 
            this.LblOnlyView4.AutoSize = true;
            this.LblOnlyView4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOnlyView4.Location = new System.Drawing.Point(486, 48);
            this.LblOnlyView4.Name = "LblOnlyView4";
            this.LblOnlyView4.Size = new System.Drawing.Size(39, 15);
            this.LblOnlyView4.TabIndex = 5;
            this.LblOnlyView4.Text = "Série:";
            // 
            // GrpBoxEntradaNotas
            // 
            this.GrpBoxEntradaNotas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GrpBoxEntradaNotas.Controls.Add(this.TxtBx4Semestre);
            this.GrpBoxEntradaNotas.Controls.Add(this.LblOnlyView7);
            this.GrpBoxEntradaNotas.Controls.Add(this.LblOnlyView6);
            this.GrpBoxEntradaNotas.Controls.Add(this.TxtBx3Semestre);
            this.GrpBoxEntradaNotas.Controls.Add(this.TxtBx2Semestre);
            this.GrpBoxEntradaNotas.Controls.Add(this.LblOnlyView5);
            this.GrpBoxEntradaNotas.Controls.Add(this.TxtBx1Semestre);
            this.GrpBoxEntradaNotas.Controls.Add(this.LblOnlyView3);
            this.GrpBoxEntradaNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrpBoxEntradaNotas.Location = new System.Drawing.Point(10, 137);
            this.GrpBoxEntradaNotas.Name = "GrpBoxEntradaNotas";
            this.GrpBoxEntradaNotas.Size = new System.Drawing.Size(677, 92);
            this.GrpBoxEntradaNotas.TabIndex = 4;
            this.GrpBoxEntradaNotas.TabStop = false;
            this.GrpBoxEntradaNotas.Text = "Entrada das Notas:";
            // 
            // TxtBx4Semestre
            // 
            this.TxtBx4Semestre.Location = new System.Drawing.Point(613, 42);
            this.TxtBx4Semestre.MaxLength = 4;
            this.TxtBx4Semestre.Name = "TxtBx4Semestre";
            this.TxtBx4Semestre.Size = new System.Drawing.Size(54, 20);
            this.TxtBx4Semestre.TabIndex = 7;
            this.TxtBx4Semestre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TxtBx4Semestre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBx4Semestre_Validating);
            // 
            // LblOnlyView7
            // 
            this.LblOnlyView7.AutoSize = true;
            this.LblOnlyView7.Location = new System.Drawing.Point(544, 45);
            this.LblOnlyView7.Name = "LblOnlyView7";
            this.LblOnlyView7.Size = new System.Drawing.Size(63, 13);
            this.LblOnlyView7.TabIndex = 6;
            this.LblOnlyView7.Text = "4º Bimestre:";
            // 
            // LblOnlyView6
            // 
            this.LblOnlyView6.AutoSize = true;
            this.LblOnlyView6.Location = new System.Drawing.Point(354, 45);
            this.LblOnlyView6.Name = "LblOnlyView6";
            this.LblOnlyView6.Size = new System.Drawing.Size(63, 13);
            this.LblOnlyView6.TabIndex = 5;
            this.LblOnlyView6.Text = "3º Bimestre:";
            // 
            // TxtBx3Semestre
            // 
            this.TxtBx3Semestre.Location = new System.Drawing.Point(423, 42);
            this.TxtBx3Semestre.MaxLength = 4;
            this.TxtBx3Semestre.Name = "TxtBx3Semestre";
            this.TxtBx3Semestre.Size = new System.Drawing.Size(54, 20);
            this.TxtBx3Semestre.TabIndex = 4;
            this.TxtBx3Semestre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TxtBx3Semestre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBx3Semestre_Validating);
            // 
            // TxtBx2Semestre
            // 
            this.TxtBx2Semestre.Location = new System.Drawing.Point(247, 42);
            this.TxtBx2Semestre.MaxLength = 4;
            this.TxtBx2Semestre.Name = "TxtBx2Semestre";
            this.TxtBx2Semestre.Size = new System.Drawing.Size(54, 20);
            this.TxtBx2Semestre.TabIndex = 3;
            this.TxtBx2Semestre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TxtBx2Semestre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBx2Semestre_Validating);
            // 
            // LblOnlyView5
            // 
            this.LblOnlyView5.AutoSize = true;
            this.LblOnlyView5.Location = new System.Drawing.Point(178, 45);
            this.LblOnlyView5.Name = "LblOnlyView5";
            this.LblOnlyView5.Size = new System.Drawing.Size(63, 13);
            this.LblOnlyView5.TabIndex = 2;
            this.LblOnlyView5.Text = "2º Bimestre:";
            // 
            // TxtBx1Semestre
            // 
            this.TxtBx1Semestre.Location = new System.Drawing.Point(75, 42);
            this.TxtBx1Semestre.MaxLength = 4;
            this.TxtBx1Semestre.Name = "TxtBx1Semestre";
            this.TxtBx1Semestre.Size = new System.Drawing.Size(54, 20);
            this.TxtBx1Semestre.TabIndex = 1;
            this.TxtBx1Semestre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TxtBx1Semestre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBx1Semestre_Validating);
            // 
            // LblOnlyView3
            // 
            this.LblOnlyView3.AutoSize = true;
            this.LblOnlyView3.Location = new System.Drawing.Point(6, 45);
            this.LblOnlyView3.Name = "LblOnlyView3";
            this.LblOnlyView3.Size = new System.Drawing.Size(63, 13);
            this.LblOnlyView3.TabIndex = 0;
            this.LblOnlyView3.Text = "1º Bimestre:";
            // 
            // TxtBxNumeroMatricula
            // 
            this.TxtBxNumeroMatricula.Location = new System.Drawing.Point(223, 67);
            this.TxtBxNumeroMatricula.MaxLength = 10;
            this.TxtBxNumeroMatricula.Name = "TxtBxNumeroMatricula";
            this.TxtBxNumeroMatricula.Size = new System.Drawing.Size(94, 20);
            this.TxtBxNumeroMatricula.TabIndex = 3;
            this.TxtBxNumeroMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            // 
            // LblOnlyView2
            // 
            this.LblOnlyView2.AutoSize = true;
            this.LblOnlyView2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOnlyView2.Location = new System.Drawing.Point(34, 69);
            this.LblOnlyView2.Name = "LblOnlyView2";
            this.LblOnlyView2.Size = new System.Drawing.Size(177, 15);
            this.LblOnlyView2.TabIndex = 2;
            this.LblOnlyView2.Text = "Número de matricula do aluno:";
            // 
            // TxtBxNomeDisciplina
            // 
            this.TxtBxNomeDisciplina.Location = new System.Drawing.Point(158, 29);
            this.TxtBxNomeDisciplina.MaxLength = 50;
            this.TxtBxNomeDisciplina.Name = "TxtBxNomeDisciplina";
            this.TxtBxNomeDisciplina.Size = new System.Drawing.Size(159, 20);
            this.TxtBxNomeDisciplina.TabIndex = 1;
            // 
            // LblOnlyView1
            // 
            this.LblOnlyView1.AutoSize = true;
            this.LblOnlyView1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOnlyView1.Location = new System.Drawing.Point(34, 33);
            this.LblOnlyView1.Name = "LblOnlyView1";
            this.LblOnlyView1.Size = new System.Drawing.Size(117, 15);
            this.LblOnlyView1.TabIndex = 0;
            this.LblOnlyView1.Text = "Nome da disciplina:";
            // 
            // MnStrExportar
            // 
            this.MnStrExportar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.MnStrExportar.Location = new System.Drawing.Point(0, 0);
            this.MnStrExportar.Name = "MnStrExportar";
            this.MnStrExportar.Size = new System.Drawing.Size(716, 24);
            this.MnStrExportar.TabIndex = 7;
            this.MnStrExportar.Text = "menuStrip1";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textpToolStripMenuItem});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // textpToolStripMenuItem
            // 
            this.textpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porLinhaToolStripMenuItem,
            this.porColunaToolStripMenuItem});
            this.textpToolStripMenuItem.Name = "textpToolStripMenuItem";
            this.textpToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.textpToolStripMenuItem.Text = "Texto";
            // 
            // porLinhaToolStripMenuItem
            // 
            this.porLinhaToolStripMenuItem.Name = "porLinhaToolStripMenuItem";
            this.porLinhaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.porLinhaToolStripMenuItem.Text = "Por Linha";
            this.porLinhaToolStripMenuItem.Click += new System.EventHandler(this.porLinhaToolStripMenuItem_Click);
            // 
            // porColunaToolStripMenuItem
            // 
            this.porColunaToolStripMenuItem.Name = "porColunaToolStripMenuItem";
            this.porColunaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.porColunaToolStripMenuItem.Text = "Por Coluna";
            this.porColunaToolStripMenuItem.Click += new System.EventHandler(this.porColunaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnCalcular);
            this.panel1.Controls.Add(this.BtnCadastrarAluno);
            this.panel1.Controls.Add(this.TxtBxConceito);
            this.panel1.Controls.Add(this.LblOnlyView9);
            this.panel1.Controls.Add(this.TxtBxMediaFinal);
            this.panel1.Controls.Add(this.LblOnlyView8);
            this.panel1.Location = new System.Drawing.Point(728, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 244);
            this.panel1.TabIndex = 1;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(54, 171);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(113, 23);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "Calcular Média";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnCadastrarAluno
            // 
            this.BtnCadastrarAluno.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarAluno.Location = new System.Drawing.Point(54, 205);
            this.BtnCadastrarAluno.Name = "BtnCadastrarAluno";
            this.BtnCadastrarAluno.Size = new System.Drawing.Size(113, 23);
            this.BtnCadastrarAluno.TabIndex = 4;
            this.BtnCadastrarAluno.Text = "Adicionar Cadastro";
            this.BtnCadastrarAluno.UseVisualStyleBackColor = true;
            this.BtnCadastrarAluno.Click += new System.EventHandler(this.BtnCadastrarAluno_Click);
            // 
            // TxtBxConceito
            // 
            this.TxtBxConceito.Location = new System.Drawing.Point(97, 96);
            this.TxtBxConceito.MaxLength = 20;
            this.TxtBxConceito.Name = "TxtBxConceito";
            this.TxtBxConceito.Size = new System.Drawing.Size(95, 20);
            this.TxtBxConceito.TabIndex = 3;
            // 
            // LblOnlyView9
            // 
            this.LblOnlyView9.AutoSize = true;
            this.LblOnlyView9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOnlyView9.Location = new System.Drawing.Point(19, 98);
            this.LblOnlyView9.Name = "LblOnlyView9";
            this.LblOnlyView9.Size = new System.Drawing.Size(59, 15);
            this.LblOnlyView9.TabIndex = 2;
            this.LblOnlyView9.Text = "Conceito:";
            // 
            // TxtBxMediaFinal
            // 
            this.TxtBxMediaFinal.Location = new System.Drawing.Point(97, 30);
            this.TxtBxMediaFinal.MaxLength = 5;
            this.TxtBxMediaFinal.Name = "TxtBxMediaFinal";
            this.TxtBxMediaFinal.Size = new System.Drawing.Size(70, 20);
            this.TxtBxMediaFinal.TabIndex = 1;
            // 
            // LblOnlyView8
            // 
            this.LblOnlyView8.AutoSize = true;
            this.LblOnlyView8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOnlyView8.Location = new System.Drawing.Point(19, 33);
            this.LblOnlyView8.Name = "LblOnlyView8";
            this.LblOnlyView8.Size = new System.Drawing.Size(73, 15);
            this.LblOnlyView8.TabIndex = 0;
            this.LblOnlyView8.Text = "Média Final:";
            // 
            // PnlGuiDePesquisa
            // 
            this.PnlGuiDePesquisa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PnlGuiDePesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlGuiDePesquisa.Controls.Add(this.TxtBxFiltro);
            this.PnlGuiDePesquisa.Controls.Add(this.CmbBxProcurarPor);
            this.PnlGuiDePesquisa.Controls.Add(this.LblOnlyView11);
            this.PnlGuiDePesquisa.Controls.Add(this.LblOnlyView10);
            this.PnlGuiDePesquisa.Location = new System.Drawing.Point(4, 254);
            this.PnlGuiDePesquisa.Name = "PnlGuiDePesquisa";
            this.PnlGuiDePesquisa.Size = new System.Drawing.Size(485, 50);
            this.PnlGuiDePesquisa.TabIndex = 2;
            // 
            // TxtBxFiltro
            // 
            this.TxtBxFiltro.Location = new System.Drawing.Point(342, 16);
            this.TxtBxFiltro.MaxLength = 50;
            this.TxtBxFiltro.Name = "TxtBxFiltro";
            this.TxtBxFiltro.Size = new System.Drawing.Size(115, 20);
            this.TxtBxFiltro.TabIndex = 3;
            this.TxtBxFiltro.TextChanged += new System.EventHandler(this.TxtBxFiltro_TextChanged);
            // 
            // CmbBxProcurarPor
            // 
            this.CmbBxProcurarPor.FormattingEnabled = true;
            this.CmbBxProcurarPor.Items.AddRange(new object[] {
            "Série",
            "Matrícula",
            "Disciplina"});
            this.CmbBxProcurarPor.Location = new System.Drawing.Point(88, 16);
            this.CmbBxProcurarPor.Name = "CmbBxProcurarPor";
            this.CmbBxProcurarPor.Size = new System.Drawing.Size(123, 21);
            this.CmbBxProcurarPor.TabIndex = 2;
            // 
            // LblOnlyView11
            // 
            this.LblOnlyView11.AutoSize = true;
            this.LblOnlyView11.Location = new System.Drawing.Point(304, 19);
            this.LblOnlyView11.Name = "LblOnlyView11";
            this.LblOnlyView11.Size = new System.Drawing.Size(32, 13);
            this.LblOnlyView11.TabIndex = 1;
            this.LblOnlyView11.Text = "Filtro:";
            // 
            // LblOnlyView10
            // 
            this.LblOnlyView10.AutoSize = true;
            this.LblOnlyView10.Location = new System.Drawing.Point(14, 19);
            this.LblOnlyView10.Name = "LblOnlyView10";
            this.LblOnlyView10.Size = new System.Drawing.Size(68, 13);
            this.LblOnlyView10.TabIndex = 0;
            this.LblOnlyView10.Text = "Procurar por:";
            // 
            // DtStCadastroDados
            // 
            this.DtStCadastroDados.DataSetName = "CadastroDados";
            this.DtStCadastroDados.Tables.AddRange(new System.Data.DataTable[] {
            this.DtDadosAlunos});
            // 
            // DtDadosAlunos
            // 
            this.DtDadosAlunos.Columns.AddRange(new System.Data.DataColumn[] {
            this.DtClnNomeDaDisciplina,
            this.DtClnSerie,
            this.DtClnMatricula,
            this.DtCln1Bimestre,
            this.DtCln2Bimestre,
            this.DtCln3Bimestre,
            this.DtCln4Bimestre,
            this.DtClnMedia,
            this.DtClnConceito});
            this.DtDadosAlunos.TableName = "DadosAlunos";
            // 
            // DtClnNomeDaDisciplina
            // 
            this.DtClnNomeDaDisciplina.ColumnName = "Disciplina";
            // 
            // DtClnSerie
            // 
            this.DtClnSerie.ColumnName = "Série";
            // 
            // DtClnMatricula
            // 
            this.DtClnMatricula.ColumnName = "Matrícula";
            // 
            // DtCln1Bimestre
            // 
            this.DtCln1Bimestre.ColumnName = "Nota 1ºBimestre";
            // 
            // DtCln2Bimestre
            // 
            this.DtCln2Bimestre.ColumnName = "Nota 2ºBimestre";
            // 
            // DtCln3Bimestre
            // 
            this.DtCln3Bimestre.ColumnName = "Nota 3ºBimestre";
            // 
            // DtCln4Bimestre
            // 
            this.DtCln4Bimestre.ColumnName = "Nota 4ºBimestre";
            // 
            // DtClnMedia
            // 
            this.DtClnMedia.ColumnName = "Média";
            // 
            // DtClnConceito
            // 
            this.DtClnConceito.ColumnName = "Conceito";
            // 
            // BndSrcCadastroDados
            // 
            this.BndSrcCadastroDados.DataMember = "DadosAlunos";
            this.BndSrcCadastroDados.DataSource = this.DtStCadastroDados;
            // 
            // DtGrdViewDados
            // 
            this.DtGrdViewDados.AutoGenerateColumns = false;
            this.DtGrdViewDados.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DtGrdViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdViewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disciplinaDataGridViewTextBoxColumn,
            this.sérieDataGridViewTextBoxColumn,
            this.matrículaDataGridViewTextBoxColumn,
            this.nota1ºBimestreDataGridViewTextBoxColumn,
            this.nota2ºBimestreDataGridViewTextBoxColumn,
            this.nota3ºBimestreDataGridViewTextBoxColumn,
            this.nota4ºBimestreDataGridViewTextBoxColumn,
            this.médiaDataGridViewTextBoxColumn,
            this.conceitoDataGridViewTextBoxColumn});
            this.DtGrdViewDados.DataSource = this.BndSrcCadastroDados;
            this.DtGrdViewDados.Location = new System.Drawing.Point(4, 310);
            this.DtGrdViewDados.Name = "DtGrdViewDados";
            this.DtGrdViewDados.Size = new System.Drawing.Size(954, 150);
            this.DtGrdViewDados.StandardTab = true;
            this.DtGrdViewDados.TabIndex = 3;
            // 
            // disciplinaDataGridViewTextBoxColumn
            // 
            this.disciplinaDataGridViewTextBoxColumn.DataPropertyName = "Disciplina";
            this.disciplinaDataGridViewTextBoxColumn.HeaderText = "Disciplina";
            this.disciplinaDataGridViewTextBoxColumn.Name = "disciplinaDataGridViewTextBoxColumn";
            // 
            // sérieDataGridViewTextBoxColumn
            // 
            this.sérieDataGridViewTextBoxColumn.DataPropertyName = "Série";
            this.sérieDataGridViewTextBoxColumn.HeaderText = "Série";
            this.sérieDataGridViewTextBoxColumn.Name = "sérieDataGridViewTextBoxColumn";
            // 
            // matrículaDataGridViewTextBoxColumn
            // 
            this.matrículaDataGridViewTextBoxColumn.DataPropertyName = "Matrícula";
            this.matrículaDataGridViewTextBoxColumn.HeaderText = "Matrícula";
            this.matrículaDataGridViewTextBoxColumn.Name = "matrículaDataGridViewTextBoxColumn";
            // 
            // nota1ºBimestreDataGridViewTextBoxColumn
            // 
            this.nota1ºBimestreDataGridViewTextBoxColumn.DataPropertyName = "Nota 1ºBimestre";
            this.nota1ºBimestreDataGridViewTextBoxColumn.HeaderText = "Nota 1ºBimestre";
            this.nota1ºBimestreDataGridViewTextBoxColumn.Name = "nota1ºBimestreDataGridViewTextBoxColumn";
            // 
            // nota2ºBimestreDataGridViewTextBoxColumn
            // 
            this.nota2ºBimestreDataGridViewTextBoxColumn.DataPropertyName = "Nota 2ºBimestre";
            this.nota2ºBimestreDataGridViewTextBoxColumn.HeaderText = "Nota 2ºBimestre";
            this.nota2ºBimestreDataGridViewTextBoxColumn.Name = "nota2ºBimestreDataGridViewTextBoxColumn";
            // 
            // nota3ºBimestreDataGridViewTextBoxColumn
            // 
            this.nota3ºBimestreDataGridViewTextBoxColumn.DataPropertyName = "Nota 3ºBimestre";
            this.nota3ºBimestreDataGridViewTextBoxColumn.HeaderText = "Nota 3ºBimestre";
            this.nota3ºBimestreDataGridViewTextBoxColumn.Name = "nota3ºBimestreDataGridViewTextBoxColumn";
            // 
            // nota4ºBimestreDataGridViewTextBoxColumn
            // 
            this.nota4ºBimestreDataGridViewTextBoxColumn.DataPropertyName = "Nota 4ºBimestre";
            this.nota4ºBimestreDataGridViewTextBoxColumn.HeaderText = "Nota 4ºBimestre";
            this.nota4ºBimestreDataGridViewTextBoxColumn.Name = "nota4ºBimestreDataGridViewTextBoxColumn";
            // 
            // médiaDataGridViewTextBoxColumn
            // 
            this.médiaDataGridViewTextBoxColumn.DataPropertyName = "Média";
            this.médiaDataGridViewTextBoxColumn.HeaderText = "Média";
            this.médiaDataGridViewTextBoxColumn.Name = "médiaDataGridViewTextBoxColumn";
            // 
            // conceitoDataGridViewTextBoxColumn
            // 
            this.conceitoDataGridViewTextBoxColumn.DataPropertyName = "Conceito";
            this.conceitoDataGridViewTextBoxColumn.HeaderText = "Conceito";
            this.conceitoDataGridViewTextBoxColumn.Name = "conceitoDataGridViewTextBoxColumn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP08_200581.Properties.Resources.logo_etec;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(495, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCadastroNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtGrdViewDados);
            this.Controls.Add(this.PnlGuiDePesquisa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlEntradaDeDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnStrExportar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroNotas";
            this.Text = "Cadastro de Notas - Instituição x ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroDeNotas_FormClosing);
            this.PnlEntradaDeDados.ResumeLayout(false);
            this.PnlEntradaDeDados.PerformLayout();
            this.GrpBoxEntradaNotas.ResumeLayout(false);
            this.GrpBoxEntradaNotas.PerformLayout();
            this.MnStrExportar.ResumeLayout(false);
            this.MnStrExportar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlGuiDePesquisa.ResumeLayout(false);
            this.PnlGuiDePesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtStCadastroDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtDadosAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BndSrcCadastroDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdViewDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlEntradaDeDados;
        private System.Windows.Forms.TextBox TxtBxNomeDisciplina;
        private System.Windows.Forms.Label LblOnlyView1;
        private System.Windows.Forms.GroupBox GrpBoxEntradaNotas;
        private System.Windows.Forms.TextBox TxtBxNumeroMatricula;
        private System.Windows.Forms.Label LblOnlyView2;
        private System.Windows.Forms.TextBox TxtBxSerie;
        private System.Windows.Forms.Label LblOnlyView4;
        private System.Windows.Forms.TextBox TxtBx4Semestre;
        private System.Windows.Forms.Label LblOnlyView7;
        private System.Windows.Forms.Label LblOnlyView6;
        private System.Windows.Forms.TextBox TxtBx3Semestre;
        private System.Windows.Forms.TextBox TxtBx2Semestre;
        private System.Windows.Forms.Label LblOnlyView5;
        private System.Windows.Forms.TextBox TxtBx1Semestre;
        private System.Windows.Forms.Label LblOnlyView3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCadastrarAluno;
        private System.Windows.Forms.TextBox TxtBxConceito;
        private System.Windows.Forms.Label LblOnlyView9;
        private System.Windows.Forms.TextBox TxtBxMediaFinal;
        private System.Windows.Forms.Label LblOnlyView8;
        private System.Windows.Forms.Panel PnlGuiDePesquisa;
        private System.Windows.Forms.ComboBox CmbBxProcurarPor;
        private System.Windows.Forms.Label LblOnlyView11;
        private System.Windows.Forms.Label LblOnlyView10;
        private System.Windows.Forms.TextBox TxtBxFiltro;
        private System.Data.DataSet DtStCadastroDados;
        private System.Data.DataTable DtDadosAlunos;
        private System.Data.DataColumn DtClnNomeDaDisciplina;
        private System.Data.DataColumn DtClnSerie;
        private System.Data.DataColumn DtClnMatricula;
        private System.Data.DataColumn DtCln1Bimestre;
        private System.Data.DataColumn DtCln2Bimestre;
        private System.Data.DataColumn DtCln3Bimestre;
        private System.Data.DataColumn DtCln4Bimestre;
        private System.Data.DataColumn DtClnMedia;
        private System.Data.DataColumn DtClnConceito;
        private System.Windows.Forms.BindingSource BndSrcCadastroDados;
        private System.Windows.Forms.DataGridView DtGrdViewDados;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sérieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrículaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1ºBimestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2ºBimestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3ºBimestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota4ºBimestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn médiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip MnStrExportar;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porLinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porColunaToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

