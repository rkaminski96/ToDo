using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAzure.Data
{
    public class TodoRepository
    {
        private List<Todo> todos;

        public TodoRepository()
        {
            todos = new List<Todo>()
            {
                new Todo("Do a task"),
                new Todo("Do a important task"),
                new Todo("Do a very important task"),
                new Todo("Do a task"),
                new Todo("Do a important task"),
                new Todo("Do a very important task"),
                new Todo("Do a task"),
                new Todo("Do a important task"),
                new Todo("Do a very important task"),
                new Todo("Do a task"),
                new Todo("Do a important task"),
                new Todo("Do a very important task")
            };
        }

        public void AddTodo(Todo todo)
        {
            todos.Add(todo);
        }

        public List<Todo> GetTodos()
        {
            return todos;
        }
    }
}
