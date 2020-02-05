using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAzure.Data
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

        protected Todo()
        {

        }

        public Todo(string title)
        {
            Id = new Guid();
            Title = title;
        }
    }
}
