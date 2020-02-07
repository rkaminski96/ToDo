using System;
using System.Collections.Generic;
using System.Linq;
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

        private string checkSelectedLanguage()
        {
            if (chooseLanguageComboBox.SelectedIndex == 0)
                return "en-GB";
            return "pl-PL";
        }

        private void addItemsToListView(ListView listView, Todo todo)
        { 
            ListViewItem item = new ListViewItem(todo.Title);
            var toDoStatus = checkToDoStatus(todo);
            item.SubItems.Add(toDoStatus);
            listView.Items.Add(item);
        }

        private void ToDoForm_Load(object sender, EventArgs e)
        {
            chooseLanguageComboBox.SelectedIndex = 0;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void addToDoButton_Click(object sender, EventArgs e)
        {
            var selectedLanguage = checkSelectedLanguage();
            SpeechService speechService = new SpeechService();
            var result = await speechService.RecognizeSpeechAsync(selectedLanguage);
            result = trimResult(result);

            var newTodo = todos.FirstOrDefault(s => s.Title == result);
            if (newTodo == null)
            {
                var todo = new Todo(result);
                todos.Add(todo);

                ListViewItem item = new ListViewItem(todo.Title);

                var toDoStatus = checkToDoStatus(todo);
                item.SubItems.Add(toDoStatus);
                listViewAll.Items.Add(item);

                updateListViewActive();
                updateListViewAll();
                updateListViewCompleted();
            }
            else
                MessageBox.Show($"Todo { result } already exists");
        }

        private async void markAsDoneButton_Click(object sender, EventArgs e)
        {
            var selectedLanguage = checkSelectedLanguage();
            SpeechService speechService = new SpeechService();
            var result = await speechService.RecognizeSpeechAsync(selectedLanguage);
            result = trimResult(result);

            var completedTodo = todos.FirstOrDefault(s => s.Title == result);
            if (completedTodo == null)
                MessageBox.Show("Todo with this title does not exist");
            else
            {
                completedTodo.Completed = true;
                updateListViewActive();
                updateListViewAll();
                updateListViewCompleted();
            }
        }

        private void allTodosButton_Click(object sender, EventArgs e)
        {
            listViewAll.Items.Clear();

            foreach (var todo in todos)
            {
                addItemsToListView(listViewAll, todo);
            }

            listViewAll.BringToFront();
            toDoStatusLabel.Text = "Todo App | All";
        }

        private void updateListViewAll()
        {
            listViewAll.Items.Clear();

            foreach (var todo in todos)
            {
                addItemsToListView(listViewAll, todo);
            }
        }


        private void activeTodosButton_Click(object sender, EventArgs e)
        {
            listViewActive.Items.Clear();

            foreach (var todo in todos)
            {
                if (!todo.Completed)
                {
                    addItemsToListView(listViewActive, todo);
                }
            }

            listViewActive.BringToFront();
            toDoStatusLabel.Text = "Todo App | Active";
            
        }

        private void updateListViewActive()
        {
            listViewActive.Items.Clear();

            foreach (var todo in todos)
            {
                if (!todo.Completed)
                {
                    addItemsToListView(listViewActive, todo);
                }
            }
        }

        private void completedTodosButton_Click(object sender, EventArgs e)
        {
            listViewCompleted.Items.Clear();

            foreach (var todo in todos)
            {
                if (todo.Completed)
                {
                    addItemsToListView(listViewCompleted, todo);
                }
            }

            listViewCompleted.BringToFront();
            toDoStatusLabel.Text = "Todo App | Completed";
        }

        private void updateListViewCompleted()
        {
            listViewCompleted.Items.Clear();

            foreach (var todo in todos)
            {
                if (todo.Completed)
                {
                    addItemsToListView(listViewCompleted, todo);
                }
            }
        }
    }
}
