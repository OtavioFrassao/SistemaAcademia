using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Windows.Forms;
using AcademiaApp.Infra;
using AcademiaDomain;
using AcademiaService.Base;
using Microsoft.Extensions.DependencyInjection;

namespace AcademiaApp
{
    public partial class FormPerfilAluno : Form
    {
        private List<ItemTreino> _itensPerfil = new();
        private List<Treino> _treinosPerfil = new();

        public FormPerfilAluno()
        {
            InitializeComponent();
            btnGerarPdf.Click += btnGerarPdf_Click;
            dgvTreinosPerfil.SelectionChanged += dgvTreinosPerfil_SelectionChanged;
            tabControlPerfil.SelectedIndexChanged += (sender, e) =>
            {
                if (tabControlPerfil.SelectedTab == tabTreinos)
                    SelecionarPrimeiroTreino();
            };
        }

        public FormPerfilAluno(Aluno aluno) : this()
        {
            CarregarDadosAluno(aluno);
            CarregarTreinos(aluno.ID);
            CarregarAvaliacoes(aluno.ID);
        }

        private void CarregarDadosAluno(Aluno aluno)
        {
            lblNomeAluno.Text = aluno.Nome;
            lblIdAluno.Text = $"Aluno #{aluno.ID:D3}";
            lblNomeCompleto.Text = aluno.Nome;
            lblCPF.Text = aluno.CPF;
            lblNascimento.Text = aluno.DataNascimento.ToString("dd/MM/yyyy");
            lblTelefone.Text = aluno.Telefone;
            lblEmail.Text = aluno.Email;
            lblCodigoAluno.Text = aluno.ID.ToString();
        }

        private void CarregarTreinos(int idAluno)
        {
            try
            {
                using var scope = ConfigureDI.ServiceProvider.CreateScope();

                var treinoService = scope.ServiceProvider
                    .GetRequiredService<IBaseService<Treino>>();
                var itemService = scope.ServiceProvider
                    .GetRequiredService<IBaseService<ItemTreino>>();

                _treinosPerfil = treinoService.ReadAll<Treino>()
                    .Where(t => t.Aluno != null && t.Aluno.ID == idAluno)
                    .OrderBy(t => t.NomeTreino)
                    .ToList();

                var idsTreinos = _treinosPerfil.Select(t => t.ID).ToHashSet();

                _itensPerfil = idsTreinos.Count == 0
                    ? new List<ItemTreino>()
                    : itemService.ReadAll<ItemTreino>()
                        .Where(i => i.Treino != null && idsTreinos.Contains(i.Treino.ID))
                        .ToList();

                dgvTreinosPerfil.DataSource = _treinosPerfil.Select(t => new
                {
                    t.ID,
                    Treino = t.NomeTreino,
                    Descricao = t.Descricao,
                    Inicio = t.DataInicio.ToString("dd/MM/yyyy"),
                    Fim = t.DataFim.ToString("dd/MM/yyyy")
                }).ToList();

                SelecionarPrimeiroTreino();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar treinos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarAvaliacoes(int idAluno)
        {
            try
            {
                using var scope = ConfigureDI.ServiceProvider.CreateScope();

                var avaliacaoService = scope.ServiceProvider
                    .GetRequiredService<IBaseService<AvaliacaoFisica>>();

                // Mantém apenas os registros do aluno selecionado.
                // A avaliação mais recente aparece primeiro.
                var dados = avaliacaoService.ReadAll<AvaliacaoFisica>()
                    .Where(a => a.Aluno != null && a.Aluno.ID == idAluno)
                    .OrderByDescending(a => a.DataAvaliacao)
                    .ThenByDescending(a => a.ID)
                    .Select(a => new
                    {
                        a.ID,
                        Data = a.DataAvaliacao,
                        a.Peso,
                        a.Altura,
                        a.PercentualGordura,
                        a.Observacao
                    }).ToList();

                dgvAvaliacoesPerfil.DataSource = dados;
                lblResumoAvaliacoes.Text = dados.Count == 0
                    ? "Nenhuma avaliação física cadastrada para este aluno."
                    : $"Total de avaliações: {dados.Count}";
            }
            catch (Exception ex)
            {
                dgvAvaliacoesPerfil.DataSource = null;
                lblResumoAvaliacoes.Text = "Não foi possível carregar as avaliações.";
                MessageBox.Show(ex.Message, "Erro ao carregar avaliações",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelecionarPrimeiroTreino()
        {
            if (dgvTreinosPerfil.SelectedRows.Count == 0 &&
                dgvTreinosPerfil.Rows.Count > 0)
            {
                dgvTreinosPerfil.CurrentCell = dgvTreinosPerfil.Rows[0].Cells[0];
                dgvTreinosPerfil.Rows[0].Selected = true;
            }

            CarregarExerciciosDoTreino();
        }

        private void dgvTreinosPerfil_SelectionChanged(object sender, EventArgs e)
        {
            CarregarExerciciosDoTreino();
        }


        private void CarregarExerciciosDoTreino()
        {
            if (!ObterIdTreinoSelecionado(out int idTreino))
            {
                dgvItensPerfil.DataSource = null;
                btnGerarPdf.Enabled = false;
                return;
            }

            btnGerarPdf.Enabled = true;

            dgvItensPerfil.DataSource = _itensPerfil
                .Where(i => i.Treino != null &&
                            i.Treino.ID == idTreino)
                .Select(i => new
                {
                    Exercicio = i.Exercicio?.Nome ?? "Não informado",
                    Series = i.Series,
                    Repeticoes = i.Repeticoes,
                    Carga = i.CargaRecomendada
                }).ToList();
        }


        private void btnGerarPdf_Click(object? sender, EventArgs e)
        {
            if (!ObterIdTreinoSelecionado(out int idTreino))
            {
                MessageBox.Show("Selecione um treino primeiro.");
                return;
            }

            var treino = _treinosPerfil.FirstOrDefault(t => t.ID == idTreino);
            if (treino == null)
            {
                MessageBox.Show("Treino não encontrado.");
                return;
            }

            var itens = _itensPerfil
                .Where(i => i.Treino != null && i.Treino.ID == idTreino)
                .ToList();

            using var salvar = new SaveFileDialog
            {
                Title = "Salvar ficha de treino",
                Filter = "Documento PDF (*.pdf)|*.pdf",
                DefaultExt = "pdf",
                AddExtension = true,
                OverwritePrompt = true,
                FileName = $"Ficha_Treino_{idTreino}.pdf"
            };

            if (salvar.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                GerarFichaPdf(salvar.FileName, treino, itens);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao gerar PDF",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("PDF salvo com sucesso! Deseja abrir a ficha?",
                "Ficha de treino", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    Process.Start(new ProcessStartInfo(salvar.FileName)
                    {
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("O PDF foi salvo, mas não foi possível abri-lo.\n" +
                        ex.Message, "Aviso");
                }
            }
        }

        private void GerarFichaPdf(string caminho, Treino treino,
            List<ItemTreino> itens)
        {
            // Licença Community para este projeto acadêmico individual.
            QuestPDF.Settings.License = LicenseType.Community;

            const string rosa = "#BE185D";
            const string rosaClaro = "#FDF2F8";
            const string cinza = "#404040";

            Document.Create(documento =>
            {
                documento.Page(pagina =>
                {
                    pagina.Size(PageSizes.A4);
                    pagina.Margin(36);
                    pagina.PageColor(Colors.White);
                    pagina.DefaultTextStyle(x => x.FontSize(11).FontColor(cinza));

                    pagina.Header().PaddingBottom(18).Column(cabecalho =>
                    {
                        cabecalho.Item().Text("Hello Kitty Gym")
                            .FontSize(25).Bold().FontColor(rosa);
                        cabecalho.Item().Text("SistemaAcademia | Ficha de treino")
                            .FontSize(11).FontColor(rosa);
                        cabecalho.Item().PaddingTop(8).LineHorizontal(2)
                            .LineColor(rosa);
                    });

                    pagina.Content().Column(conteudo =>
                    {
                        conteudo.Spacing(12);
                        conteudo.Item().AlignCenter().Text("FICHA DE TREINO")
                            .FontSize(19).Bold().FontColor(rosa);

                        conteudo.Item().Background(rosaClaro).Padding(12).Column(dados =>
                        {
                            dados.Spacing(5);
                            dados.Item().Text($"Aluno: {lblNomeAluno.Text}");
                            dados.Item().Text($"Código do aluno: {lblCodigoAluno.Text}");
                            dados.Item().Text($"Treino: {treino.NomeTreino} (ID {treino.ID})").Bold();
                            dados.Item().Text($"Descrição: {treino.Descricao}");
                            dados.Item().Text($"Período: {treino.DataInicio:dd/MM/yyyy} a {treino.DataFim:dd/MM/yyyy}");
                        });

                        conteudo.Item().Text("Exercícios cadastrados")
                            .FontSize(14).Bold().FontColor(rosa);

                        conteudo.Item().Table(tabela =>
                        {
                            tabela.ColumnsDefinition(colunas =>
                            {
                                colunas.RelativeColumn(4);
                                colunas.RelativeColumn(1.4f);
                                colunas.RelativeColumn(2);
                                colunas.RelativeColumn(2);
                            });

                            tabela.Header(cabecalho =>
                            {
                                foreach (var titulo in new[]
                                    { "Exercício", "Séries", "Repetições", "Carga" })
                                {
                                    cabecalho.Cell().Background(rosa).Padding(8)
                                        .Text(titulo).Bold().FontColor(Colors.White);
                                }
                            });

                            for (int i = 0; i < itens.Count; i++)
                            {
                                var item = itens[i];
                                string fundo = i % 2 == 0 ? "#FFFFFF" : rosaClaro;
                                tabela.Cell().Background(fundo).Padding(8)
                                    .Text(item.Exercicio?.Nome ?? "Não informado");
                                tabela.Cell().Background(fundo).Padding(8)
                                    .Text(item.Series.ToString());
                                tabela.Cell().Background(fundo).Padding(8)
                                    .Text(item.Repeticoes ?? "");
                                tabela.Cell().Background(fundo).Padding(8)
                                    .Text(item.CargaRecomendada ?? "");
                            }

                            if (itens.Count == 0)
                            {
                                tabela.Cell().ColumnSpan(4).Padding(8)
                                    .Text("Nenhum exercício cadastrado neste treino.");
                            }
                        });

                        conteudo.Item().PaddingTop(12).Text("Observações do instrutor")
                            .Bold().FontColor(rosa);
                        conteudo.Item().PaddingTop(12).LineHorizontal(1)
                            .LineColor("#D1D5DB");
                        conteudo.Item().PaddingTop(12).LineHorizontal(1)
                            .LineColor("#D1D5DB");
                        conteudo.Item().PaddingTop(22).AlignCenter().Width(230)
                            .Column(assinatura =>
                            {
                                assinatura.Item().LineHorizontal(1).LineColor(cinza);
                                assinatura.Item().PaddingTop(4).AlignCenter()
                                    .Text("Assinatura do responsável").FontSize(10);
                            });
                    });

                    pagina.Footer().AlignCenter().Text(texto =>
                    {
                        texto.DefaultTextStyle(x => x.FontSize(9).FontColor(cinza));
                        texto.Span($"SistemaAcademia | {DateTime.Now:dd/MM/yyyy} | Página ");
                        texto.CurrentPageNumber();
                        texto.Span(" de ");
                        texto.TotalPages();
                    });
                });
            }).GeneratePdf(caminho);

        }

        private bool ObterIdTreinoSelecionado(out int idTreino)
        {
            idTreino = 0;

            if (dgvTreinosPerfil.SelectedRows.Count == 0)
                return false;

            var coluna = dgvTreinosPerfil.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(c =>
                    c.DataPropertyName == "ID" ||
                    c.Name == "colTreinoID" ||
                    c.Name == "ID");

            if (coluna == null)
                return false;

            var valor = dgvTreinosPerfil.SelectedRows[0]
                .Cells[coluna.Index].Value;

            return int.TryParse(valor?.ToString(), out idTreino);
        }

    }
}
