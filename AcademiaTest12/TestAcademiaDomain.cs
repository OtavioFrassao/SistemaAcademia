using AcademiaDomain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AcademiaTest
{
    [TestClass]
    /*A palavra sealed (selado) na declaração public sealed class TestAcademiaDomain significa que nenhuma outra classe no sistema pode herdar dela. Em projetos de teste, o próprio Visual Studio costuma recomendar colocar o sealed nas classes de teste*/
    public sealed class TestAcademiaDomain
    {
        /*Para que serve o private JsonSerializerOptions OptionsJson() e por que está no teste?
        Este bloco de código cria uma configuração para a conversão de dados. O comando WriteIndented = true diz ao sistema: "Quando for transformar meu objeto em texto, por favor, quebre as linhas e coloque espaços para ficar bonito e legível" (o que chamamos de pretty print).*/
        private JsonSerializerOptions OptionsJson()
        {
            return new JsonSerializerOptions { WriteIndented = true };
        }

        [TestMethod]

        public void TestAluno()
        {
            var aluno = new Aluno
            {
                ID = 1,
                Nome = "Otavio",
                Email = "otavio-frassao@hotmail.com",
                Telefone = "14 997081218",
                DataNascimento = new DateTime(2005, 3, 11),
                StatusMatricula = true,
                CPF = "49319662843"
                /*O Treino apareceu como null no seu JSON porque, no C#, qualquer lista ou coleção (como o ICollection<Treino>) nasce completamente nula ("vazia" de memória) até que você a instancie explicitamente.*/
            };

            var alunoJson = JsonSerializer.Serialize(aluno, OptionsJson());
            Debug.WriteLine(alunoJson);
            Assert.IsNotNull(alunoJson);
        }

        [TestMethod]
        public void TestDivisao()
        {

            var divisao = new Divisao
            {
                ID = 1,
                Descricao = "Emagrecimento e Ganho de massa muscular"
            };

            var divisaoJson = JsonSerializer.Serialize(divisao, OptionsJson());
            Debug.WriteLine(divisaoJson);
            Assert.IsNotNull(divisaoJson);

        }

        [TestMethod]
        public void TestExercicio()
        {

            var exercicio = new Exercicio
            {
                ID = 1,
                Nome = "Supino Reto com Barra",
                GrupoMuscular = "Peito"
            };

            var exercicioJson = JsonSerializer.Serialize(exercicio, OptionsJson());
            Debug.WriteLine(exercicioJson);
            Assert.IsNotNull(exercicioJson);
        }

        [TestMethod]
        public void TestTreino()
        {

            var treino = new Treino
            {
                ID = 1,
                Descricao = "Treino A - Peito e Triceps",
                DataInicio = new DateTime(2026, 10, 20),
                DataFim = new DateTime(2026, 11, 20), // Vence em 1 mês
                AlunoID = 1, //ID do aluno Otávio
                DivisaoID = 1 //ID da divisão Emagrecimento e Ganho de massa muscular
            };

            var treinoJson = JsonSerializer.Serialize(treino, OptionsJson());
            Debug.WriteLine(treinoJson);
            Assert.IsNotNull(treinoJson);
        }

        [TestMethod]
        public void TestItemTreino()
        {

            var item = new ItemTreino
            {
                ID = 1,
                TreinoID = 1,
                ExercicioID = 1,
                Series = 4,
                Repeticoes = "10 a 12",
                CargaRecomendada = "20kg de cada lado"
            };

            var itemTreinoJson = JsonSerializer.Serialize(item, OptionsJson());
            Debug.WriteLine(itemTreinoJson);
            Assert.IsNotNull(itemTreinoJson);
        }
    }
}
