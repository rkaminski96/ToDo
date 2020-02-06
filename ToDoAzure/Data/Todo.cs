using System;

namespace ToDoAzure.Data
{
    public class Todo
    {
        public string Title { get; set; }
        public bool Completed { get; set; }

        protected Todo()
        {

        }

        public Todo(string title)
        {
            Title = title;
        }
    }
}
