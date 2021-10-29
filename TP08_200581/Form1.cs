using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP08_200581
{
    public partial class FrmCadastroNotas : Form
    {
        #region Inicialização
        public FrmCadastroNotas()
        {
            InitializeComponent();
        }
        #endregion

        #region Evento Form Closing
        private void FrmCadastroDeNotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair ?", "Encerrando o Cadastro de Notas...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region Variáveis Globais
        double ntb1 = 0, ntb2 = 0, ntb3 = 0, ntb4 = 0;
        double media;
        #endregion

        #region Filtro
        private void TxtBxFiltro_TextChanged(object sender, EventArgs e)
        {
            switch(CmbBxProcurarPor.Text)
            {
                case "Série":
                    BndSrcCadastroDados.Filter = "Série like '%" + TxtBxFiltro.Text + "%'";
                    break;
                case "Matrícula":
                    BndSrcCadastroDados.Filter = "Matrícula like '%" + TxtBxFiltro.Text + "%'";
                    break;
                case "Disciplina":
                    BndSrcCadastroDados.Filter = "Disciplina like '%" + TxtBxFiltro.Text + "%'";
                    break;
                default:
                    TxtBxFiltro.Clear();
                    MessageBox.Show("Escolha uma opção", "Erro");
                    break;
            }
        }
        #endregion

        #region Validating, Evento na Entrada das Notas verificando o range de 0 até 10
        private void TxtBx1Semestre_Validating(object sender, CancelEventArgs e)
        {
            ntb1 = Convert.ToDouble(TxtBx1Semestre.Text);
            if(ntb1 > 10)
            {
                MessageBox.Show("As notas vão de 0 até 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBx1Semestre.Clear();TxtBx1Semestre.Focus();
            }
            else
            {
                return;
            }
        }

        private void TxtBx2Semestre_Validating(object sender, CancelEventArgs e)
        {
            ntb2 = Convert.ToDouble(TxtBx2Semestre.Text);
            if (ntb2 > 10)
            {
                MessageBox.Show("As notas vão de 0 até 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBx2Semestre.Clear(); TxtBx2Semestre.Focus();
            }
            else
            {
                return;
            }
        }

        private void TxtBx3Semestre_Validating(object sender, CancelEventArgs e)
        {
            ntb3 = Convert.ToDouble(TxtBx3Semestre.Text);
            if (ntb3 > 10)
            {
                MessageBox.Show("As notas vão de 0 até 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBx3Semestre.Clear(); TxtBx3Semestre.Focus();
            }
            else
            {
                return;
            }
        }

        private void TxtBx4Semestre_Validating(object sender, CancelEventArgs e)
        {
            ntb4 = Convert.ToDouble(TxtBx4Semestre.Text);
            if (ntb4 > 10)
            {
                MessageBox.Show("As notas vão de 0 até 10.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBx4Semestre.Clear(); TxtBx4Semestre.Focus();
            }
            else
            {
                return;
            }
        }
        #endregion

        #region Exportar registros por linha
        private void porLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < DtStCadastroDados.Tables["DadosAlunos"].Rows.Count; i++)
                {
                    SW.WriteLine("Disciplina: "+(DtStCadastroDados.Tables["DadosAlunos"].Rows[i]["Disciplina"]));
                    SW.WriteLine("Série: "+(DtStCadastroDados.Tables["DadosAlunos"].Rows[i]["Série"]));
                    SW.WriteLine("Número de matrícula: "+(DtStCadastroDados.Tables["DadosAlunos"].Rows[i]["Matrícula"]));
                    SW.WriteLine("Nota 1ºBimestre: "+(DtStCadastroDados.Tables["DadosAlunos"].Rows[i]["Nota 1ºBimestre"]));
                    SW.WriteLine("Nota 2ºBimestre: "+(DtStCadastroDados.Tables["DadosAlunos"].Rows[i]["Nota 2ºBimestre"]));
                    SW.WriteLine("Nota 3ºBimestre: "+(DtStCadastroDados.Tables["DadosAlunos"].Rows[i]["Nota 3ºBimestre"]));
                    SW.WriteLine("Nota 4ºBimestre: "+(DtStCadastroDados.Tables["DadosAlunos"].Rows[i]["Nota 4ºBimestre"]));
                    SW.WriteLine("Média: "+(DtStCadastroDados.Tables["DadosAlunos"].Rows[i]["Média"]));
                    SW.WriteLine("Conceito: "+(DtStCadastroDados.Tables["DadosAlunos"].Rows[i]["Conceito"]));
                    SW.WriteLine(string.Empty);
                }
                SW.Dispose();
            }
        }
        #endregion

        #region Exportar registros por coluna
        private void porColunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < DtStCadastroDados.Tables["DadosAlunos"].Rows.Count; i++)
                {
                    string disciplina = DtGrdViewDados.Rows[i].Cells[0].Value.ToString();
                    string serie = DtGrdViewDados.Rows[i].Cells[1].Value.ToString();
                    string matricula = DtGrdViewDados.Rows[i].Cells[2].Value.ToString();
                    string nota1 = DtGrdViewDados.Rows[i].Cells[3].Value.ToString();
                    string nota2 = DtGrdViewDados.Rows[i].Cells[4].Value.ToString();
                    string nota3 = DtGrdViewDados.Rows[i].Cells[5].Value.ToString();
                    string nota4 = DtGrdViewDados.Rows[i].Cells[6].Value.ToString();
                    string media = DtGrdViewDados.Rows[i].Cells[7].Value.ToString();
                    string conceito = DtGrdViewDados.Rows[i].Cells[8].Value.ToString();
                    SW.WriteLine(disciplina+"|"+serie+"|"+matricula+"|"+nota1 +"|"+nota2+"|"+nota3+"|"+nota4 +"|"+media+"|"+conceito+"|");
                }
                SW.Dispose();
            }
        }
        #endregion

        #region Sobre
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TP09_200581 - Continuação da TP08 \nNome: Mateus Salles Novaes Rocha \nRa:200581 \nDisciplina: Prog.Visual e Games", "Detalhes", MessageBoxButtons.OK);
        }

        #endregion

        #region Botão Calcular
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtBxNomeDisciplina.Text.Length > 0 && TxtBxNumeroMatricula.Text.Length > 0 && TxtBxSerie.Text.Length > 0 &&
                TxtBx1Semestre.Text.Length > 0 && TxtBx2Semestre.Text.Length > 0 && TxtBx3Semestre.Text.Length > 0 &&
                TxtBx4Semestre.Text.Length > 0)
            {
                ntb1 = Convert.ToDouble(TxtBx1Semestre.Text);
                ntb2 = Convert.ToDouble(TxtBx2Semestre.Text);
                ntb3 = Convert.ToDouble(TxtBx3Semestre.Text);
                ntb4 = Convert.ToDouble(TxtBx4Semestre.Text);

                media = (ntb1 + ntb2 + ntb3 + ntb4) / 4;

                TxtBxMediaFinal.Text = Convert.ToString(media);

                if (media >= 6)
                {
                    TxtBxConceito.ForeColor = Color.Blue;
                    TxtBxConceito.Text = ("Aprovado");
                }
                else
                {
                    TxtBxConceito.ForeColor = Color.Red;
                    TxtBxConceito.Text = ("Reprovado");
                }
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }

        #endregion

        #region Botão Cadastrar
        private void BtnCadastrarAluno_Click(object sender, EventArgs e)
        {
            if (TxtBxNomeDisciplina.Text.Length > 0 && TxtBxNumeroMatricula.Text.Length > 0 && TxtBxSerie.Text.Length > 0 &&
                TxtBx1Semestre.Text.Length >= 0 && TxtBx2Semestre.Text.Length >= 0 && TxtBx3Semestre.Text.Length >= 0 &&
                TxtBx4Semestre.Text.Length >= 0)
            {
                DtGrdViewDados.Enabled = true;
                DataRow novalinha = DtStCadastroDados.Tables["DadosAlunos"].NewRow();

                novalinha["Disciplina"] = TxtBxNomeDisciplina.Text.ToString();
                novalinha["Matrícula"] = TxtBxNumeroMatricula.Text.ToString();
                novalinha["Nota 1ºBimestre"] = TxtBx1Semestre.Text.ToString();
                novalinha["Nota 2ºBimestre"] = TxtBx2Semestre.Text.ToString();
                novalinha["Nota 3ºBimestre"] = TxtBx3Semestre.Text.ToString();
                novalinha["Nota 4ºBimestre"] = TxtBx4Semestre.Text.ToString();

                novalinha["Série"] = TxtBxSerie.Text.ToString();

                novalinha["Média"] = Convert.ToString(media);

               

                if (media >= 6)
                {
                    //novalinha["Conceito"] = ForeColor = Color.Blue;
                    novalinha["Conceito"] = ("Aprovado");
                }
                else
                {
                    //novalinha["Conceito"] = ForeColor = Color.Red;
                    novalinha["Conceito"] = ("Reprovado");
                }

                 DtStCadastroDados.Tables[0].Rows.Add(novalinha);
                 TxtBxNomeDisciplina.Clear();
                 TxtBxNumeroMatricula.Clear();
                 TxtBx1Semestre.Clear();
                 TxtBx2Semestre.Clear();
                 TxtBx3Semestre.Clear();
                 TxtBx4Semestre.Clear();
                 TxtBxSerie.Clear();
                 TxtBxMediaFinal.Clear();
                 TxtBxConceito.Clear();
                 media = 0;
                 DtGrdViewDados.Enabled = false;
                 
 
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region Validando, Evento KeyPress
        private void Verifica(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 44 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion
    }
}
