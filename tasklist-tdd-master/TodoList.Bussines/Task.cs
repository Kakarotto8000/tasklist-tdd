using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoList.Bussines
{
    public class Task
    {

        public int ID { get; set; }
        public string Name { get; set; }


        public Task(string nome)
        {
            this.Name = nome;
        }
    }
}