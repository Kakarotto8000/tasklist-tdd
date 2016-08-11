using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Bussines
{
    public interface IControlarDados
    {

        void Inserir(Task tarefa);

        bool verifica(Task tarefa);

        List<Task> RecuperaTodasTarefas();

        Task RecuperarPorId(int pintID);
    }
}
