using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoList.Bussines;

namespace TodoList.Tests.Mocks
{
    public class ControlarDadosMock : IControlarDados
    {

        private List<Task> ListaTarefas = new List<Bussines.Task>();
        
        public void Inserir(Bussines.Task tarefa)
        {
            tarefa.ID = ListaTarefas.Count + 1;
            ListaTarefas.Add(tarefa);
        }

        public Task RecuperarPorId(int pintID)
        {
            return ListaTarefas.Single(x => x.ID.Equals(pintID));
        }

        public List<Bussines.Task> RecuperaTodasTarefas()
        {
            return ListaTarefas;
        }

        public bool verifica(Bussines.Task tarefa)
        {
            return ListaTarefas.Contains(tarefa);
        }
        
    }
}
