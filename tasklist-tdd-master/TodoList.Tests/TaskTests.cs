using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoList.Bussines;
using TodoList.Tests.Mocks;

namespace TodoList.Tests
{
    [TestClass]
    public class TaskTests
    {

        [TestMethod]
        public void VerificarInsercaoTarefa()
        {
            //Arrange
            var controlarDados = new ControlarDadosMock();
            var tarefa = new Task("TESTE2");
            
            //Act
            controlarDados.Inserir(tarefa);

            //Assert
            Assert.AreEqual(true, controlarDados.verifica(tarefa));            
        }

        //Arrange Act Assert

        [TestMethod]
        public void RecuperarTodasTarefas()
        {
            var controlar = new ControlarDadosMock();
            var tarefa1 = new Task("TESTE1");
            var tarefa2 = new Task("TESTE2");

            controlar.Inserir(tarefa1);
            controlar.Inserir(tarefa2);
            
            
            var tarefas = controlar.RecuperaTodasTarefas();

            Assert.AreEqual(2, tarefas.Count);

            Assert.AreEqual(1, tarefas[0].ID);

            Assert.AreEqual("TESTE1", tarefas[0].Name);

            Assert.AreEqual(2, tarefas[1].ID);

            Assert.AreEqual("TESTE2", tarefas[1].Name);
        }

        [TestMethod]
        public void RecuperarTarefaPorID()
        {
            var lintID = 1;

            var controlar = new ControlarDadosMock();

            var tarefa = new Task("TESTE1");

            controlar.Inserir(tarefa);

            var tarefaRecuperada = controlar.RecuperarPorId(lintID);

            Assert.AreEqual(1, tarefaRecuperada.ID);
            Assert.AreEqual("TESTE1", tarefaRecuperada.Name);
        }

    }
}
