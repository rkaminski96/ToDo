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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void addToDoButton_Click(object sender, EventArgs e)
        {
            SpeechService speechService = new SpeechService();
            var result = await speechService.RecognizeSpeechAsync();

            var todo = new Todo(result);
            todos.Add(todo);

            ListViewItem item = new ListViewItem(todo.Title);
            
            item.SubItems.Add(todo.Completed.ToString());
            listViewAll.Items.Add(item);
        }
    }
}
