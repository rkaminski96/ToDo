using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAzure.Data;

namespace ToDoAzure
{
    public partial class ActiveTodos : UserControl
    {
        private int poss = 0;
        public ActiveTodos()
        {
            InitializeComponent();

            TodoRepository todoRepository = new TodoRepository();
            var todos = todoRepository.GetTodos();

            foreach (var todo in todos)
            {
                ToDoItem item = new ToDoItem(todo);
                activeToDoPanel.Controls.Add(item);
                item.Top = poss;
                poss = (item.Top + item.Height + 5);
            }
        }
    }
}
