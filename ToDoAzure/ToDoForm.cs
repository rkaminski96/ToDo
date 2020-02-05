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
        public ToDoForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ToDoForm_Load(object sender, EventArgs e)
        {

        }

        private void activeTodosButton_Click(object sender, EventArgs e)
        {
            activeTodos1.BringToFront();
        }

        private void completedTodosButton_Click(object sender, EventArgs e)
        {
            completedTodos1.BringToFront();
        }

        private async void addToDoButton_Click(object sender, EventArgs e)
        {
            SpeechService speechService = new SpeechService();
            var result = await speechService.RecognizeSpeechAsync();
        }
    }
}
