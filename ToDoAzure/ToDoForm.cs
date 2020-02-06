using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAzure.Data;
using ToDoSpeech;

namespace ToDoAzure
{
    public partial class ToDoForm : Form
    {
        private List<Todo> todos = new List<Todo>();

        public ToDoForm()
        {
            InitializeComponent();
        }


        private string checkToDoStatus(Todo todo)
        {
            var toDoStatus = "";
            if (todo.Completed == false)
                toDoStatus = "ACTIVE";
            else
                toDoStatus = "COMPLETED";
            return toDoStatus;
        }

        private string trimResult(string result)
        {
            char[] trimChars = {' ', '.', ','};
            result = result.TrimEnd(trimChars);
            return result;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void addToDoButton_Click(object sender, EventArgs e)
        {
            SpeechService speechService = new SpeechService();
            var result = await speechService.RecognizeSpeechAsync();
            result = trimResult(result);

            var todo = new Todo(result);
            todos.Add(todo);

            ListViewItem item = new ListViewItem(todo.Title);

            var toDoStatus = checkToDoStatus(todo);
            item.SubItems.Add(toDoStatus);
            listViewAll.Items.Add(item);
        }

        private async void markAsDoneButton_Click(object sender, EventArgs e)
        {
            SpeechService speechService = new SpeechService();
            var result = await speechService.RecognizeSpeechAsync();
            result = trimResult(result);

            var completedTodo = todos.FirstOrDefault(s => s.Title == result);
            if (completedTodo == null)
            {
                MessageBox.Show("Todo with this name doesn't exist");
            }
            else
            {
                completedTodo.Completed = true;
            }
        }

        private void allTodosButton_Click(object sender, EventArgs e)
        {
            listViewAll.Items.Clear();

            foreach (var todo in todos)
            {
                ListViewItem item = new ListViewItem(todo.Title);
                var toDoStatus = checkToDoStatus(todo);
                item.SubItems.Add(toDoStatus);
                listViewAll.Items.Add(item);
            }

            listViewAll.BringToFront();
            toDoStatusLabel.Text = "Todo App | All";
        }

        private void activeTodosButton_Click(object sender, EventArgs e)
        {
            listViewActive.Items.Clear();

            foreach (var todo in todos)
            {
                ListViewItem item = new ListViewItem(todo.Title);
                var toDoStatus = checkToDoStatus(todo);
                item.SubItems.Add(toDoStatus);
                listViewActive.Items.Add(item);
            }

            listViewActive.BringToFront();
            toDoStatusLabel.Text = "Todo App | Active";
            
        }

        private void completedTodosButton_Click(object sender, EventArgs e)
        {
            listViewCompleted.Items.Clear();

            foreach (var todo in todos)
            {
                ListViewItem item = new ListViewItem(todo.Title);
                var toDoStatus = checkToDoStatus(todo);
                item.SubItems.Add(toDoStatus);
                listViewCompleted.Items.Add(item);
            }

            listViewCompleted.BringToFront();
            toDoStatusLabel.Text = "Todo App | Completed";
        }
    }
}
