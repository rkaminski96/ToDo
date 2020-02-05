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
    public partial class ToDoItem : UserControl
    {
        public ToDoItem(Todo todo)
        {
            InitializeComponent();
            toDoLabel.Text = todo.Title;
        }
    }
}
